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
        public void PrencherCamposNovaOportunidade()
        {
            ThisElement(_PageOportunidadeSF._btnEditOportunidade, Action.DoubleClick);
            ThisElement(_PageOportunidadeSF._txtPrazoContratual, Action.Click);
            ThisElement(_PageOportunidadeSF._txtPrazoContratual, Action.SendKey,"60");
            ThisElement(_PageOportunidadeSF._cmbChanceFechamentoNenhum, Action.Click);
            ThisElement(_PageOportunidadeSF._cmbChanceFechamentoAlta, Action.Click);
            ThisElement(_PageOportunidadeSF._btnSalvar, Action.Click);

        }
        public void CadNovaCotacao()
        {

        }   
    }
}
