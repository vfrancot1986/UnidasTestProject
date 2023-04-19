using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

namespace UnidasTestProject.Controller
{
    public class ControllerPageOportunidadeCadSF
    {

        //Declaracao de variaveis
        public PageOportunidadeCadSF _PageOportunidadeCadSF;
        //Contrutor da classe
        public ControllerPageOportunidadeCadSF(IWebDriver driver)
        {
            _PageOportunidadeCadSF = new PageOportunidadeCadSF(driver);
        }

        //Acoes da pagina
        public void CadNovaOportunidade()
        {
            ThisElement(_PageOportunidadeCadSF._selTipoDaOpp, Action.Click);
            ThisElement(_PageOportunidadeCadSF._selTipoDaOppLocacao, Action.Click);
            ThisElement(_PageOportunidadeCadSF._selSubtipoDaOpp, Action.Click);
            ThisElement(_PageOportunidadeCadSF._selSubtipoDaOppAcrescimo, Action.Click);
            ThisElement(_PageOportunidadeCadSF._selCategoriaDoDispositivo, Action.Click);
            ThisElement(_PageOportunidadeCadSF.CategoriaDoDispositivoOpcoesNovo, Action.Click);
            ThisElement(_PageOportunidadeCadSF._txtNomeDaOportunidade, Action.Click);
            ThisElement(_PageOportunidadeCadSF._txtNomeDaOportunidade, Action.SendKey, "TesteAutomacao_New_OPR" + $"{DateTime.Now:ddMMyyyyThhmmss}");
            ThisElement(_PageOportunidadeCadSF._selFaseOpp2, Action.Click);
            ThisElement(_PageOportunidadeCadSF._optFirstContact, Action.Click);
            ThisElement(_PageOportunidadeCadSF._txtDataDeFechamento, Action.Click);
            ThisElement(_PageOportunidadeCadSF._txtDataDeFechamento, Action.SendKey, "20/04/2023");
            ThisElement(_PageOportunidadeCadSF._btnAvancar, Action.Click);
        }
        public bool ValidarMsgUsuarioNaoPossuiAreaNegocio()
        {
            ThisElement(_PageOportunidadeCadSF._msgUsuarioNaoPossuiAreaNegocio, Action.Wait);
            return true;
        }
            
    }
}
