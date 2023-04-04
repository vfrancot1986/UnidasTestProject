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

        [FindsBy(How = How.XPath, Using = "//*[@value='TipoDaOppOpcoes.Locacao']")]
        [CacheLookup]
        private IWebElement _selTipoOportunidadeLocacao;

        [FindsBy(How = How.XPath, Using = "//*[@name='SubtipoDaOpp']")]
        [CacheLookup]
        private IWebElement _selSubtipoDaOpp;

        [FindsBy(How = How.XPath, Using = "//*[@value='SubtipodaOppOpcoes.Acrescimo']")]
        [CacheLookup]
        private IWebElement _selSubtipoDaOppAcrescimo;

        [FindsBy(How = How.XPath, Using = "//*[@name='CategoriaDoDispositivo']")]
        [CacheLookup]
        private IWebElement _selCategoriaDoDispositivo;

        [FindsBy(How = How.XPath, Using = "//*[@value='CategoriaDoDispositivoOpcoes.Novo']")]
        [CacheLookup]
        private IWebElement CategoriaDoDispositivoOpcoesNovo;

        [FindsBy(How = How.XPath, Using = "//*[@name='NomeDaOportunidade']")]
        [CacheLookup]
        private IWebElement _txtNomeDaOportunidade;

        [FindsBy(How = How.XPath, Using = "//*[@name='FaseOpp2']")]
        [CacheLookup]
        private IWebElement _selFaseOpp2;

        [FindsBy(How = How.XPath, Using = "//*[@value='optFirstContact']")]
        [CacheLookup]
        private IWebElement _optFirstContact;

        [FindsBy(How = How.XPath, Using = "//*[@name='DataDeFechamento']")]
        [CacheLookup]
        private IWebElement _txtDataDeFechamento;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Avancar')]")]
        [CacheLookup]
        private IWebElement _btnAvancar;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Seu usuario nao possui area de negócio preenchido! Impossivel prosseguir.')]")]
        [CacheLookup]
        private IWebElement _msgUsuarioNaoPossuiAreaNegocio;

        

        //Contrutor da classe
        public PageOportunidadeSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Acoes da pagina
        public void CadNovaOportunidade()
        {
            TestBase.thisElement(_selTipoOportunidade, action.Click);
            TestBase.thisElement(_selTipoOportunidadeLocacao, action.Click);
            TestBase.thisElement(_selSubtipoDaOpp, action.Click);
            TestBase.thisElement(_selSubtipoDaOppAcrescimo, action.Click);
            TestBase.thisElement(_selCategoriaDoDispositivo, action.Click);
            TestBase.thisElement(CategoriaDoDispositivoOpcoesNovo, action.Click);
            TestBase.thisElement(_txtNomeDaOportunidade, action.Click);
            TestBase.thisElement(_txtNomeDaOportunidade, action.SendKey, "TesteAutomacao_New_OPR");
            TestBase.thisElement(_selFaseOpp2, action.Click);
            TestBase.thisElement(_optFirstContact, action.Click);
            TestBase.thisElement(_txtDataDeFechamento, action.Click);
            TestBase.thisElement(_txtDataDeFechamento, action.SendKey, "01/01/2001");
            TestBase.thisElement(_btnAvancar, action.Click);
        }
        public bool ValidarMsgUsuarioNaoPossuiAreaNegocio()
        {
            TestBase.thisElement(_msgUsuarioNaoPossuiAreaNegocio, action.Wait);
                
            //if ()
            //{
                return true;

            //}
            //else
            //{
            //    return false;
            //}

        }
            
    }
}
