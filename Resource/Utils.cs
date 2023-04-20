using OpenQA.Selenium;
using System.Diagnostics;
using System.Xml.Linq;

namespace UnidasTestProject.Resource
{
    public static class Utils
    {
        public static List<KeyValuePair<string, string>> ExecuteCmd(string command)
        {
            Process process = new();
            List<KeyValuePair<string, string>> list = new();

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
        public static void RunJavaScript(IWebDriver driver, IWebElement? element, string javascript)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(javascript, element); 
        }
    }
}
