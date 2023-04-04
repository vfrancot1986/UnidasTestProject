using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageInicioSF
    {

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
