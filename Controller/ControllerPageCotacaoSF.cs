using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

namespace UnidasTestProject.Controller
{
    public class ControllerPageCotacaoSF
    {

        //Declaracao de variaveis
        public PageCotacaoSF _PageCotacaoSF;
        //Contrutor da classe
        public ControllerPageCotacaoSF(IWebDriver driver)
        {
            _PageCotacaoSF = new PageCotacaoSF(driver);
        }

        //Acoes da pagina
        public void PrencherCamposCotacao()
        {
            ThisElement(_PageOportunidadeSF._btnEditOportunidade, Action.ClickPoint);
        }  
    }
}
