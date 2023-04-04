using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageOportunidadeSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//*[@name='TipoDeOportunidade']")]
        [CacheLookup]
        private IWebElement _selTipoOportunidade;

        [FindsBy(How = How.XPath, Using = "//*[@value='TipoDaOppOpcoes.Locação']")]
        [CacheLookup]
        private IWebElement _selTipoOportunidadeLocação;        



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
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void CadNovaOportunidade()
        {
            TestBase.thisElement(_selTipoOportunidade, action.Click);
            TestBase.thisElement(_selTipoOportunidadeLocação, action.Click);

            //TestBase.thisElement(_selSubtipoDaOpp, action.Click);
            //TestBase.thisElement(_selCategoriaDoDispositivo, action.Click);
            //TestBase.thisElement(_txtNomeDaOportunidade, action.SendKey, "TesteAutomacao_New_OPR");
            //TestBase.thisElement(_selFaseOpp2, action.Click);
            //TestBase.thisElement(_txtDataDeFechamento, action.SendKey, "01/01/2001");
            //TestBase.thisElement(_btnAvancar, action.Click);
        }
    }
}
