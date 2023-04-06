using OpenQA.Selenium;
using UnidasTestProject.Page;
using UnidasTestProject.Resource;

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
            TestBase.thisElement(_PageLoginSF._txtNomeDoUsuario, action.SendKey, _usuario);
            TestBase.thisElement(_PageLoginSF._txtSenha, action.SendKey, _senha);
            TestBase.thisElement(_PageLoginSF._btnFacaLoginNoSandbox, action.Click);
        }
    }
}