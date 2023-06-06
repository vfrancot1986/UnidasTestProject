using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using UnidasTestProject.Settings;


namespace UnidasTestProject.Resource
{
    public abstract class TestBase
    {
        //Declaracao de variaveis
        public static IWebDriver _driver = null!;
        private static string _timeStamp = $"{DateTime.Now:ddMMyyyyThhmmss}";
        public ServiceProvider ServiceProvider { get; }
        private static readonly string TestResultsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net6.0", "\\TestResults"), $"Deploy_" + _timeStamp);
        public string ExtentFileName = null!;
        public ExtentReports Extent = null!;
        private static ExtentTest? Test;
        private static ExtentHtmlReporter? HtmlReporter;
        private static Screenshot? Screenshot;
        private static string? EvidenceFileName;
        private static string? TestInfo;
        private static readonly string Logger = string.Empty;
        public enum Action{ Click, ClickPoint, ClickJs, DoubleClick, DoubleClickJs, SendKey, Clear, Submit, Wait, Enter }
        public enum Request { Get, Post, Put, Patch, Delete, Head, Options}
        public enum Environment { Web, Api, Mobile, Desktop }

        //Construtor
        protected TestBase()
        {
            // Configuracao do AppSettings
            var services = new ServiceCollection().AddTransient<IConfiguration>(sp => new ConfigurationBuilder().AddJsonFile("appSettings.json").Build());

            ServiceProvider = services.BuildServiceProvider();

            IConfiguration? config = ServiceProvider.GetService<IConfiguration>();
            if (IsNotNull(config))
            {
                AppSettings.UrlQA = config["UrlQA"];
                AppSettings.UrlDEV = config["UrlDEV"];
                AppSettings.UrlHOM = config["UrlHOM"];
                AppSettings.UserQA = config["UserQA"];
                AppSettings.UserDEV = config["UserDEV"];
                AppSettings.UserHOM = config["UserHOM"];
                AppSettings.PasswordQA = config["PasswordQA"];
                AppSettings.PasswordDEV = config["PasswordDEV"];
                AppSettings.PasswordHOM = config["PasswordHOM"];
                AppSettings.PrazoContratual = config["PrazoContratual"];
                AppSettings.NmCotacao = config["NmCotacao"] + _timeStamp;
                AppSettings.NmOportunidade = config["NmOportunidade"] + _timeStamp;
                AppSettings.Produto = config["Produto"];
                AppSettings.TpRodagem = config["TpRodagem"];
                AppSettings.Quantidade = config["Quantidade"];
                AppSettings.TipoUso = config["TipoUso"];
                AppSettings.ValorVenda = config["ValorVenda"];
                AppSettings.UsoMensal = config["UsoMensal"];
                AppSettings.UfEntrega = config["UfEntrega"];
                AppSettings.PMunicipioEntrega = config["PMunicipioEntrega "];
                AppSettings.QtdPneus = config["QtdPneus"];
                AppSettings.Manutencao = config["Manutencao"];
                AppSettings.Grupo = config["Grupo"];
                AppSettings.TpReserva = config["TpReserva"];
                AppSettings.QtdDiariaReserva = config["QtdDiariaReserva"];
            }
        }

        //Antes de todos os testes
        [OneTimeSetUp]
        public void Setup()
        {
            try
            {
                ExtentFileName = Path.Combine(TestResultsDirectory, GetType().Name + '_' + _timeStamp + ".html");

                if (!Directory.Exists(TestResultsDirectory))
                {
                    Directory.CreateDirectory(TestResultsDirectory);
                }

                if (!File.Exists(ExtentFileName))
                {
                    File.Create(ExtentFileName);
                }

                Extent = new ExtentReports();
                HtmlReporter = new ExtentHtmlReporter(ExtentFileName);
                Extent.AttachReporter(HtmlReporter);
            }
            catch (Exception)
            {
                throw;

            }
        }

        //Antes de Cada Teste
        [SetUp]
        public void BeforeTest()
        {
            // Configuracao do WebDriver
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments( "start-maximized",
                                        "enable-automation",                                        
                                        "--no-sandbox",
                                        "--disable-infobars",
                                        "--disable-dev-shm-usage",
                                        "--disable-browser-side-navigation",
                                        "--ignore-certificate-errors");
            _driver = new ChromeDriver(chromeOptions);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(AppSettings.UrlQA);

            try
            {
                Test = Extent.CreateTest(TestContext.CurrentContext.Test.Name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //depois de Cada Teste
        [TearDown]
        public void AfterTest()
        {
            if (IsNotNull(Test))
            {
                try
                {
                    var status = TestContext.CurrentContext.Result.Outcome.Status;
                    var errorMessage = TestContext.CurrentContext.Result.Message;
                    Status logstatus;
                    switch (status)
                    {
                        case TestStatus.Failed:
                            logstatus = Status.Fail;
                            Test.Log(logstatus, "Test ended with " + logstatus + " – " + errorMessage);
                            break;
                        case TestStatus.Skipped:
                            logstatus = Status.Skip;
                            Test.Log(logstatus, "Test ended with " + logstatus);
                            break;
                        default:
                            logstatus = Status.Pass;
                            Test.Log(logstatus, "Test ended with " + logstatus);
                            break;
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }

            // Encerramento do WebDriver
            if (IsNotNull(_driver))
            {
                _driver.Close();
                _driver.Quit();
            }
            Utils.ExecuteCmd("taskkill /im chromedriver.exe /f /t");
        }

        //Depois de Todos os Teste
        [OneTimeTearDown]
        public void TearDown()
        {
            try
            {
                // Finalizacao do teste no ExtentReports
                Extent.Flush();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Checkpoint(bool condition, string message)
        {   
            if (IsNotNull(_driver))
            {
                _timeStamp = $"{DateTime.Now:ddMMyyyyThhmmss}";
                Screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                EvidenceFileName = Path.Combine(TestResultsDirectory, "evidence" + _timeStamp + ".png");
                Screenshot.SaveAsFile(EvidenceFileName, ScreenshotImageFormat.Png);
            }
            TestInfo = Logger + message;

            if (IsNotNull(Test))
            {
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

        }
        public static void ThisElement(IWebElement? element, Action action, string text = "")
        {
            
            int tries = 0;
            while (tries < 3)
            {
                try
                {
                    Thread.Sleep(3000);
                    var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("body")));
                    wait.Until(driver =>
                    {
                        if (element.Displayed)
                        {
                            switch (action)
                            {
                                case Action.Click:
                                    element.Click();
                                    break;
                                case Action.ClickPoint:
                                    new Actions(_driver).MoveToElement(element).Click().Perform();
                                    break;
                                case Action.DoubleClick:
                                    new Actions(_driver).MoveToElement(element).DoubleClick().Perform();
                                    break;
                                case Action.DoubleClickJs:
                                    Utils.RunJavaScript(_driver, element, "arguments[0].style.height='auto'; arguments[0].style.visibility='visible'; arguments[0].dbclick();");
                                    break;
                                case Action.ClickJs:
                                    Utils.RunJavaScript(_driver, element, "arguments[0].style.height='auto'; arguments[0].style.visibility='visible'; arguments[0].click();");
                                    break;
                                case Action.SendKey:
                                    element.SendKeys(text);
                                    break;
                                case Action.Clear:
                                    element.Clear();
                                    break;
                                case Action.Submit:
                                    element.Submit();
                                    break;
                                case Action.Enter:
                                    element.SendKeys(Keys.Enter);
                                    break;
                                case Action.Wait:
                                    break;
                            }
                            Checkpoint(true, "Acao " + action + " realizada com sucesso no elemento " + element);
                            tries = 3;
                            return element;
                        }
                        else
                        {
                            Utils.RunJavaScript(_driver, element, "arguments[0].style.height='auto'; arguments[0].style.visibility='visible';");
                        }                        
                        return null;
                    });
                }
                catch (Exception e)
                    {
                    By locator = GetLocatorFromPageObject(element);
                    element = ReFindElement(element);

                    Utils.RunJavaScript(_driver, element, "arguments[0].style.height='auto'; arguments[0].style.visibility='visible';");
                    tries++;
                    if (tries == 3)
                    {
                        Checkpoint(false, "Erro: " + e.Message + " " + tries + " tentativas");
                        throw;
                    }
                }
            }                                   
        }
        public static IWebElement WaitForElementToBeVisible(IWebElement element)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }


        private static bool IsNotNull([NotNullWhen(true)] object? obj) => obj != null;

        public static By GetLocatorFromPageObject(IWebElement element)
        {
            if (element == null) throw new NullReferenceException();

            var attributes = Utils.RunJavaScript2(_driver,element,"var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;") as Dictionary<string, object>;
            if (attributes == null) throw new NullReferenceException();

            var selector = "//" + element.TagName;
            selector = attributes.Aggregate(selector, (current, attribute) =>
                 current + "[@" + attribute.Key + "='" + attribute.Value + "']");

            return By.XPath(selector);
        }

        private static IWebElement ReFindElement(IWebElement element)
        {
            var locator = GetLocatorFromPageObject(element);
            return _driver.FindElement(locator);
        }
    }
}
