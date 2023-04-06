using OpenQA.Selenium;
using UnidasTestProject.Page;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Controller
{
    public class ControllerPageOportunidadeSF
    {

        //Declaracao de variaveis
        public PageOportunidadeSF _PageOportunidadeSF;
        //Contrutor da classe
        public ControllerPageOportunidadeSF(IWebDriver driver)
        {
            _PageOportunidadeSF = new PageOportunidadeSF(driver);
        }

        //Acoes da pagina
        public void CadNovaOportunidade()
        {
            TestBase.thisElement(_PageOportunidadeSF._selTipoOportunidade, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._selTipoOportunidadeLocacao, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._selSubtipoDaOpp, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._selSubtipoDaOppAcrescimo, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._selCategoriaDoDispositivo, action.Click);
            TestBase.thisElement(_PageOportunidadeSF.CategoriaDoDispositivoOpcoesNovo, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._txtNomeDaOportunidade, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._txtNomeDaOportunidade, action.SendKey, "TesteAutomacao_New_OPR");
            TestBase.thisElement(_PageOportunidadeSF._selFaseOpp2, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._optFirstContact, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._txtDataDeFechamento, action.Click);
            TestBase.thisElement(_PageOportunidadeSF._txtDataDeFechamento, action.SendKey, "01/01/2001");
            TestBase.thisElement(_PageOportunidadeSF._btnAvancar, action.Click);
        }
        public bool ValidarMsgUsuarioNaoPossuiAreaNegocio()
        {
            TestBase.thisElement(_PageOportunidadeSF._msgUsuarioNaoPossuiAreaNegocio, action.Wait);
            return true;
        }
            
    }
}
