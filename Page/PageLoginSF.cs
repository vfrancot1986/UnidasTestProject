using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageLoginSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        private IWebElement _txtNomeDoUsuario;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement _txtSenha;

        [FindsBy(How = How.Id, Using = "Login")]
        [CacheLookup]
        private IWebElement _btnFacaLoginNoSandbox;

        //Contrutor da classe
        public PageLoginSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void FazerLogin(string _usuario, string _senha)
        {
            TestBase.thisElement(_txtNomeDoUsuario, action.SendKey, _usuario);
            TestBase.thisElement(_txtSenha, action.SendKey, _senha);
            TestBase.thisElement(_btnFacaLoginNoSandbox, action.Click);
        }
    }
}