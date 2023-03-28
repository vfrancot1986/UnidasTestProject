using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageInicioSF
    {

        //Declaração de variáveis
        private IWebDriver _driver;
        private WebDriverWait _espera;

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//span[@title='Sales Console']")]
        [CacheLookup]
        private IWebElement _txtSalesConsole;

        [FindsBy(How = How.XPath, Using = "//div[@class='slds-icon-waffle']")]
        [CacheLookup]
        private IWebElement _btnIniciadorDeAplicativos;

        [FindsBy(How = How.XPath, Using = "//button[(@class='slds-button slds-button_neutral search-button slds-truncate')]")]
        [CacheLookup]
        private IWebElement _btnPesquisar;
        

        [FindsBy(How = How.XPath, Using = "//input[(@class='slds-input')]")]
        [CacheLookup]
        private IWebElement _txtPesquisar;

        [FindsBy(How = How.Id, Using = "input-1002")]
        [CacheLookup]
        private IWebElement _txtPesquisarConta;

        [FindsBy(How = How.XPath, Using = "//a[@title='SEMAR SUPERMERCADO LTDA']")]
        [CacheLookup]
        private IWebElement _linkConta;
        
        //Contrutor da classe
        public PageInicioSF(IWebDriver driver)
        {
            _driver = driver;
            _espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void AguardaPagina() {
            TestBase.thisElement(_txtSalesConsole);
        }
        public void PesquisarConta()
        {
            TestBase.thisElement(_btnPesquisar, action.Click);
            TestBase.thisElement(_btnPesquisar, action.SendKey, "SEMAR");
            TestBase.thisElement(_btnPesquisar, action.SendKey, "Enter");
        }
    }
}
