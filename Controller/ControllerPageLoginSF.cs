using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

namespace UnidasTestProject.Controller
{
    public class ControllerPageLoginSF
    {
        //Declaracao de variaveis
        public PageLoginSF _PageLoginSF;

        //Contrutor da classe
        public ControllerPageLoginSF(IWebDriver driver)
        {
            _PageLoginSF = new PageLoginSF(driver);
        }

        //Acoes da pagina
        public void FazerLogin(string _usuario, string _senha)
        {
            ThisElement(_PageLoginSF._txtNomeDoUsuario, Action.SendKey, _usuario);
            ThisElement(_PageLoginSF._txtSenha, Action.SendKey, _senha);
            ThisElement(_PageLoginSF._btnFacaLoginNoSandbox, Action.Click);
        }
    }
}