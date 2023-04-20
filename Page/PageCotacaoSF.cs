using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnidasTestProject.Page
{
    public class PageCotacaoSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Oportunidade')]")]
        [CacheLookup]
        public IWebElement? _cabOportunidade;
  
        //Contrutor da classe
        public PageCotacaoSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
