using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageOportunidadeSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Oportunidade')]")]
        [CacheLookup]
        public IWebElement? _cabOportunidade;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Relacionado')]")]
        [CacheLookup]
        public IWebElement? _lkRelacionado;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Nova cotação')]")]
        [CacheLookup]
        public IWebElement? _btnNovaCotacao;

        [FindsBy(How = How.XPath, Using = "//button[@title='Editar Nome da oportunidade']")]
        [CacheLookup]
        public IWebElement? _btnEditNmOportunidade;
        
        //Contrutor da classe
        public PageOportunidadeSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
