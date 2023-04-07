using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

namespace UnidasTestProject.Controller
{
    public class ControllerPageContaSF
    {
        //Declaracao de variaveis
        public PageContaSF _PageContaSF;

        //Contrutor da classe
        public ControllerPageContaSF(IWebDriver driver)
        {
            _PageContaSF = new PageContaSF(driver);
        }
        //Acoes da pagina
        public void NovaOportunidade()
        {
            ThisElement(_PageContaSF._btnNovaOportunidade, Action.ClickPoint);
        }
    }
}
