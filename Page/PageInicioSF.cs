using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageInicioSF
    {

        [FindsBy(How = How.XPath, Using = "//button[@class='slds-button slds-icon-waffle_container slds-context-bar__button slds-button forceHeaderButton salesforceIdentityAppLauncherHeader']")]
        [CacheLookup]
        private IWebElement _btnSalesConsole;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Pesquisar aplicativos e itens…']")]
        [CacheLookup]
        private IWebElement _cpPesquisarApp;

        [FindsBy(How = How.XPath, Using = "//button[@title='Mostrar Menu de navegação']")]
        [CacheLookup]
        private IWebElement _btnMenuNavegacao;

        [FindsBy(How = How.XPath, Using = "//a[@data-label='Contas']")]
        [CacheLookup]
        private IWebElement _optContas;


        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//force-list-view-manager-search-bar//div//lightning-input")]
        [CacheLookup]
        private IWebElement _cpPesquisar;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a/span[@class='slds-truncate' and contains(text(), 'Contas')]")]
        private IWebElement _txtCabecalhoConta;


        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//a[@title='SEMAR SUPERMERCADO LTDA']")]
        [CacheLookup]
        private IWebElement _linkConta;

        //Contrutor da classe
        public PageInicioSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Acoes da pagina
        public void PesquisarConta()
        {
            TestBase.thisElement(_btnSalesConsole, action.Click);
            TestBase.thisElement(_cpPesquisarApp, action.Click);
            TestBase.thisElement(_cpPesquisarApp, action.SendKey, "Sales Console");
            TestBase.thisElement(_cpPesquisarApp, action.Enter);
            TestBase.thisElement(_btnMenuNavegacao, action.Click);
            TestBase.thisElement(_optContas, action.Click);
            TestBase.thisElement(_txtCabecalhoConta, action.Click);
            TestBase.thisElement(_cpPesquisar, action.Click);
            TestBase.thisElement(_cpPesquisar, action.SendKey, "SEMAR SUPERMERCADO LTDA");
            TestBase.thisElement(_cpPesquisar, action.Enter);
            TestBase.thisElement(_linkConta, action.Click);
        }
    }
}
