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
        [FindsBy(How = How.Name, Using = "Account-search-input")]
        [CacheLookup]
        private IWebElement _txtPesquisar;

        [FindsBy(How = How.XPath, Using = "//button[(@class='slds-button slds-button_neutral search-button slds-truncate')]")]
        [CacheLookup]
        private IWebElement _btnPesquisar;
        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//force-list-view-manager-search-bar//div//lightning-input")]
        [CacheLookup]
        private IWebElement _cpPesquisar;

        [FindsBy(How = How.XPath, Using = "//a[@title='Criar']")]
        [CacheLookup]
        private IWebElement _btnCriar;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a/span[@class='slds-truncate' and contains(text(), 'Contas')]")]
        private IWebElement _txtCabecalhoConta;


        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//a[@title='SEMAR SUPERMERCADO LTDA']")]
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
        public void PesquisarConta()
        {
            TestBase.thisElement(_txtCabecalhoConta, action.Click);
            TestBase.thisElement(_cpPesquisar, action.Click);
            TestBase.thisElement(_cpPesquisar, action.SendKey, "SEMAR SUPERMERCADO LTDA");
            TestBase.thisElement(_cpPesquisar, action.Enter);
            TestBase.thisElement(_linkConta, action.Click);
        }
    }
}
