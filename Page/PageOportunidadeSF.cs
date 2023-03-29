using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageOportunidadeSF
    {
        //Declaração de variáveis
        private IWebDriver _driver;
        private WebDriverWait _espera;

        //Mapeamento dos elementos
        [FindsBy(How = How.Name, Using = "TipoDeOportunidade")]
        [CacheLookup]
        private IWebElement _selTipoOportunidade;

        [FindsBy(How = How.Name, Using = "SubtipoDaOpp")]
        [CacheLookup]
        private IWebElement _selSubtipoDaOpp;

        [FindsBy(How = How.Name, Using = "CategoriaDoDispositivo")]
        [CacheLookup]
        private IWebElement _selCategoriaDoDispositivo;

        [FindsBy(How = How.Name, Using = "NomeDaOportunidade")]
        [CacheLookup]
        private IWebElement _txtNomeDaOportunidade;

        [FindsBy(How = How.Name, Using = "FaseOpp2")]
        [CacheLookup]
        private IWebElement _selFaseOpp2;

        [FindsBy(How = How.Name, Using = "DataDeFechamento")]
        [CacheLookup]
        private IWebElement _txtDataDeFechamento;

        [FindsBy(How = How.XPath, Using = "//button[@class='slds-button slds-button_brand flow-button__NEXT']")]
        [CacheLookup]
        private IWebElement _btnAvancar;

        //Contrutor da classe
        public PageOportunidadeSF(IWebDriver driver)
        {
            _driver = driver;
            _espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void CadNovaOportunidade()
        {
            TestBase.thisElement(_selTipoOportunidade, action.Click);
            TestBase.thisElement(_selSubtipoDaOpp, action.Click);
            TestBase.thisElement(_selCategoriaDoDispositivo, action.Click);
            TestBase.thisElement(_txtNomeDaOportunidade, action.SendKey, "TesteAutomacao_New_OPR");
            TestBase.thisElement(_selFaseOpp2, action.Click);
            TestBase.thisElement(_txtDataDeFechamento, action.SendKey, "01/01/2001");
            TestBase.thisElement(_btnAvancar, action.Click);
        }
    }
}
