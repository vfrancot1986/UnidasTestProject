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
            ThisElement(_PageOportunidadeSF._btnEditNmOportunidade, Action.Click);

        }
        public void CadNovaCatacao()
        {

        }   
    }
}
