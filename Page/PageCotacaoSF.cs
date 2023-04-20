using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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

        [FindsBy(How = How.XPath, Using = "//button[@title='Editar Prazo contratual']")]
        [CacheLookup]
        public IWebElement? _btnEditOportunidade;

        [FindsBy(How = How.XPath, Using = "//input[@name='Name]")]
        [CacheLookup]
        public IWebElement? _txtNmOportunidade;

        [FindsBy(How = How.XPath, Using = "//input[@name='PrazoContratual__c']")]
        [CacheLookup]
        public IWebElement? _txtPrazoContratual;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Chance de fechamento, --Nenhum--']")]
        [CacheLookup]
        public IWebElement? _cmbChanceFechamentoNenhum;

        [FindsBy(How = How.XPath, Using = "//lightning-base-combobox-item[@data-value='Alta']")]
        [CacheLookup]
        public IWebElement? _cmbChanceFechamentoAlta;

        [FindsBy(How = How.XPath, Using = "//button[@name='SaveEdit']")]
        [CacheLookup]
        public IWebElement? _btnSalvar;

        [FindsBy(How = How.XPath, Using = "//button[@name='SaveEdit']")]
        [CacheLookup]
        public IWebElement? _btnNavaCotacao;

        //Contrutor da classe
        public PageOportunidadeSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
