using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics;
using UnidasTestProject.Settings;


namespace UnidasTestProject.Resource
{
    public abstract class TestBase
    {
        //Declaração de variáveis
        public static IWebDriver? _driver;
        public static WebDriverWait? _espera;
        public static IWebElement? _element;
        public ServiceProvider ServiceProvider { get; }
        private static readonly string TestResultsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net6.0", "\\TestResults"), $"Deploy_{DateTime.Now:ddMMyyyyThhmmss}");
        public string ExtentFileName;
        public ExtentReports Extent;
        public static ExtentTest? Test;
        private static readonly ExtentV3HtmlReporter HtmlReporter = new ExtentV3HtmlReporter(Path.Combine(TestResultsDirectory, $"TEST_{DateTime.Now:ddMMyyyy_hhmmss}.html"));
        public static Screenshot? Screenshot;
        public static string? EvidenceFileName;
        public static string? TestInfo;
        public static string Logger = string.Empty;

        //Construtor
        public TestBase()
        {
            // Configuração do AppSettings
            var services = new ServiceCollection().AddTransient<IConfiguration>(sp => new ConfigurationBuilder().AddJsonFile("appSettings.json").Build());

            ServiceProvider = services.BuildServiceProvider();

            IConfiguration? config = ServiceProvider.GetService<IConfiguration>();

            AppSettings.UrlQA = config["UrlQA"];
            AppSettings.UrlDEV = config["UrlDEV"];
            AppSettings.UrlHOM = config["UrlHOM"];
            AppSettings.UserQA = config["UserQA"];
            AppSettings.UserDEV = config["UserDEV"];
            AppSettings.UserHOM = config["UserHOM"];
            AppSettings.PasswordQA = config["PasswordQA"];
            AppSettings.PasswordDEV = config["PasswordDEV"];
            AppSettings.PasswordHOM = config["PasswordHOM"];
        }

        //Antes do teste
        [SetUp]
        public void Initialize()
        {

            // Configuração do WebDriver
            _driver = new ChromeDriver();
            _espera = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
                        
            ExtentFileName = Path.Combine(TestResultsDirectory, "TEST" + '_' + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".html");

            if (!Directory.Exists(TestResultsDirectory))
            {
                Directory.CreateDirectory(TestResultsDirectory);
            }

            if (!File.Exists(ExtentFileName))
            {
                File.Create(ExtentFileName);
            }

            Extent = new ExtentReports();
            Extent.AttachReporter(HtmlReporter);

            Test = Extent.CreateTest("TEST" + DateTime.Now.ToString("ddMMyyyyThhmmss"));
        }

        public void AbrirSF(string _url)
        {
            _driver.Navigate().GoToUrl(_url);
        }

        //Depois do Teste
        [TearDown]
        public void CleanUp()
        {

            // Finalização do teste no ExtentReports
            Extent.Flush();

            // Encerramento do WebDriver
            _driver.Close();
            _driver.Quit();
            ExecuteCmd("taskkill /im chromedriver.exe /f /t");
        }

        public static void Checkpoint(bool condition, string message)
        {

            Thread.Sleep(1000);
            Screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
            EvidenceFileName = Path.Combine(TestResultsDirectory, "evidence" + DateTime.Now.ToString("ddMMyyyyThhmmss") + ".png");
            Screenshot.SaveAsFile(EvidenceFileName, ScreenshotImageFormat.Png);

            TestInfo = Logger + message;

            if (condition)
            {
                Test.Log(Status.Pass, TestInfo, MediaEntityBuilder.CreateScreenCaptureFromPath(EvidenceFileName).Build());
            }
            else
            {
                Test.Log(Status.Fail, TestInfo, MediaEntityBuilder.CreateScreenCaptureFromPath(EvidenceFileName).Build());
                Assert.Fail();
            }

        }
        public static void thisElement(IWebElement? element, action action, string text = "")
        {
            try
            {
                if (element.Displayed && element.Enabled)
                {
                    switch (action)
                    {
                        case action.Click:
                            element.Click();
                            break;
                        case action.ClickPoint:
                            new Actions(_driver).MoveToElement(element).Click().Build().Perform();
                            break;
                        case action.SendKey:
                            element.SendKeys(text);
                            break;
                        case action.Clear:
                            element.Clear();
                            break;
                        case action.Submit:
                            element.Submit();
                            break;
                        case action.Enter:
                            element.SendKeys(Keys.Enter);
                            break;
                    }
                    Checkpoint(true, "Ação " + action + " realizada com sucesso no elemento");
                }
                else
                {
                    Checkpoint(false, "Ação inválida para o elemento");
                }
            }
            catch (NoSuchElementException e)
            {
                Checkpoint(false, e.Message);
            }
            catch (Exception e)
            {
                Checkpoint(false, "An unexpected error occurred: " + e.Message);
            }
        }

        public List<KeyValuePair<string, string>> ExecuteCmd(string command)
        {
            Process process = new Process();
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            process.WaitForExit();

            list.Add(new KeyValuePair<string, string>("Output", process.StandardOutput.ReadToEnd()));
            list.Add(new KeyValuePair<string, string>("Error", process.StandardError.ReadToEnd()));

            Thread.Sleep(3000);

            return list;
        }

    }
    public enum action
    {
        Click,
        ClickPoint,
        SendKey,
        Clear,
        Submit,
        Wait,
        Enter
    }
}
