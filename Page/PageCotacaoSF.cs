using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnidasTestProject.Page
{
    public class PageCotacaoSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Nome de Cotação')]//following::input[1]")]
        [CacheLookup]
        public IWebElement? _txtNomeCotacao;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Nome de Cotação')]//following::input[5]")]
        [CacheLookup]
        public IWebElement? _txtPrazoContratual;

        [FindsBy(How = How.XPath, Using = "//button[@title='Salvar']")]
        [CacheLookup]
        public IWebElement? _btnSalvar;        

        //Contrutor da classe
        public PageCotacaoSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
