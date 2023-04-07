using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

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
            ThisElement(_PageOportunidadeSF._selTipoOportunidade, Action.Click);
            ThisElement(_PageOportunidadeSF._selTipoOportunidadeLocacao, Action.Click);
            ThisElement(_PageOportunidadeSF._selSubtipoDaOpp, Action.Click);
            ThisElement(_PageOportunidadeSF._selSubtipoDaOppAcrescimo, Action.Click);
            ThisElement(_PageOportunidadeSF._selCategoriaDoDispositivo, Action.Click);
            ThisElement(_PageOportunidadeSF.CategoriaDoDispositivoOpcoesNovo, Action.Click);
            ThisElement(_PageOportunidadeSF._txtNomeDaOportunidade, Action.Click);
            ThisElement(_PageOportunidadeSF._txtNomeDaOportunidade, Action.SendKey, "TesteAutomacao_New_OPR");
            ThisElement(_PageOportunidadeSF._selFaseOpp2, Action.Click);
            ThisElement(_PageOportunidadeSF._optFirstContact, Action.Click);
            ThisElement(_PageOportunidadeSF._txtDataDeFechamento, Action.Click);
            ThisElement(_PageOportunidadeSF._txtDataDeFechamento, Action.SendKey, "01/01/2001");
            ThisElement(_PageOportunidadeSF._btnAvancar, Action.Click);
        }
        public bool ValidarMsgUsuarioNaoPossuiAreaNegocio()
        {
            ThisElement(_PageOportunidadeSF._msgUsuarioNaoPossuiAreaNegocio, Action.Wait);
            return true;
        }
            
    }
}
