using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageLoginSF
    {
        //Declaração de variáveis
        private IWebDriver _driver;
        private WebDriverWait _espera;

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

        [FindsBy(How = How.Id, Using = "logo")]
        [CacheLookup]
        private IWebElement _imgLogo;

        //Contrutor da classe
        public PageLoginSF(IWebDriver driver)
        {
            _driver = driver;
            _espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void FazerLogin(string _usuario, string _senha)
        {
            TestBase.thisElement(_txtNomeDoUsuario, action.SendKey, _usuario);
            TestBase.thisElement(_txtSenha, action.SendKey, _senha);
            TestBase.thisElement(_btnFacaLoginNoSandbox, action.Click);
        }
        public void AguardaPagina()
        {
            TestBase.thisElement(_imgLogo);
        }
    }
}