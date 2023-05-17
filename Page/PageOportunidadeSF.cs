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

        //button[@title='Editar Prazo contratual']//span[@class='inline-edit-trigger-icon slds-button__icon slds-button__icon_hint']
        [FindsBy(How = How.XPath, Using = "//section[@class='tabContent active oneConsoleTab']//button[@title='Editar Prazo contratual']//span[1]")]
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

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Regional, --Nenhum--']")]
        [CacheLookup]
        public IWebElement? _txtRegional;

        [FindsBy(How = How.XPath, Using = "//span[@title='Regional Leves Hunters 3 Sul+CO']")]
        [CacheLookup]
        public IWebElement? _txtRegionalHunters3;

        //Contrutor da classe
        public PageOportunidadeSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
