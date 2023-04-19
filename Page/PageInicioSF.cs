using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageInicioSF
    {

        [FindsBy(How = How.XPath, Using = "//button[@class='slds-button slds-icon-waffle_container slds-context-bar__button slds-button forceHeaderButton salesforceIdentityAppLauncherHeader']")]
        [CacheLookup]
        public IWebElement? _btnSalesConsole;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Pesquisar aplicativos e itens…']")]
        [CacheLookup]
        public IWebElement? _cpPesquisarApp;

        [FindsBy(How = How.XPath, Using = "//button[@title='Mostrar Menu de navegação']")]
        [CacheLookup]
        public IWebElement? _btnMenuNavegacao;

        [FindsBy(How = How.XPath, Using = "//a[@title='Contas']")]
        [CacheLookup]
        public IWebElement? _optContas;


        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//force-list-view-manager-search-bar//div//lightning-input")]
        [CacheLookup]
        public IWebElement? _cpPesquisar;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a/span[@class='slds-truncate' and contains(text(), 'Contas')]")]
        public IWebElement? _txtCabecalhoConta;


        [FindsBy(How = How.XPath, Using = "//*[@id='brandBand_1']//a[@title='SEMAR SUPERMERCADO LTDA']")]
        [CacheLookup]
        public IWebElement? _linkConta;

        //Contrutor da classe
        public PageInicioSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
