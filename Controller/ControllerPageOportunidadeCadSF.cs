using OpenQA.Selenium;
using UnidasTestProject.Page;
using UnidasTestProject.Resource;

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
            TestBase.thisElement(_PageOportunidadeCadSF._btnEditarCampos, action.Click);


            //TestBase.thisElement(_PageOportunidadeCadSF._selTipoOportunidadeLocacao, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._selSubtipoDaOpp, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._selSubtipoDaOppAcrescimo, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._selCategoriaDoDispositivo, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF.CategoriaDoDispositivoOpcoesNovo, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._txtNomeDaOportunidade, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._txtNomeDaOportunidade, action.SendKey, "TesteAutomacao_New_OPR");
            TestBase.thisElement(_PageOportunidadeCadSF._selFaseOpp2, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._optFirstContact, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._txtDataDeFechamento, action.Click);
            TestBase.thisElement(_PageOportunidadeCadSF._txtDataDeFechamento, action.SendKey, "01/01/2001");
            TestBase.thisElement(_PageOportunidadeCadSF._btnAvancar, action.Click);
        }
        public bool ValidarMsgUsuarioNaoPossuiAreaNegocio()
        {
            TestBase.thisElement(_PageOportunidadeCadSF._msgUsuarioNaoPossuiAreaNegocio, action.Wait);
            return true;
        }
            
    }
}
