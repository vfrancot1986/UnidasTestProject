using OpenQA.Selenium;
using UnidasTestProject.Resource;
using UnidasTestProject.Page;

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
            TestBase.thisElement(_PageContaSF._btnNovaOportunidade, action.ClickPoint);
        }
    }
}
