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
        public IWebElement _txtNomeDoUsuario;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement _txtSenha;

        [FindsBy(How = How.Id, Using = "Login")]
        [CacheLookup]
        public IWebElement _btnFacaLoginNoSandbox;

        //Contrutor da classe
        public PageLoginSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}