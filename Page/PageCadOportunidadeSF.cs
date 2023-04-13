using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageCadOportunidadeSF
    {

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//*[@name='TipoDeOportunidade']")]
        [CacheLookup]
        public IWebElement? _selTipoOportunidade;

        [FindsBy(How = How.XPath, Using = "//*[@value='TipoDaOppOpcoes.Locação']")]
        [CacheLookup]
        public IWebElement? _selTipoOportunidadeLocacao;

        [FindsBy(How = How.XPath, Using = "//*[@name='SubtipoDaOpp']")]
        [CacheLookup]
        public IWebElement? _selSubtipoDaOpp;

        [FindsBy(How = How.XPath, Using = "//*[@value='SubtipodaOppOpcoes.Acréscimo']")]
        [CacheLookup]
        public IWebElement? _selSubtipoDaOppAcrescimo;

        [FindsBy(How = How.XPath, Using = "//*[@name='CategoriaDoDispositivo']")]
        [CacheLookup]
        public IWebElement? _selCategoriaDoDispositivo;

        [FindsBy(How = How.XPath, Using = "//*[@value='CategoriaDoDispositivoOpcoes.Novo']")]
        [CacheLookup]
        public IWebElement? CategoriaDoDispositivoOpcoesNovo;

        [FindsBy(How = How.XPath, Using = "//*[@name='NomeDaOportunidade']")]
        [CacheLookup]
        public IWebElement? _txtNomeDaOportunidade;

        [FindsBy(How = How.XPath, Using = "//*[@name='FaseOpp2']")]
        [CacheLookup]
        public IWebElement? _selFaseOpp2;

        [FindsBy(How = How.XPath, Using = "//*[@value='optFirstContact']")]
        [CacheLookup]
        public IWebElement? _optFirstContact;

        [FindsBy(How = How.XPath, Using = "//*[@name='DataDeFechamento']")]
        [CacheLookup]
        public IWebElement? _txtDataDeFechamento;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Avançar')]")]
        [CacheLookup]
        public IWebElement? _btnAvancar;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Seu usuario não possui área de negócio preenchido! Impossível prosseguir.')]")]
        [CacheLookup]
        public IWebElement? _msgUsuarioNaoPossuiAreaNegocio;

        //Contrutor da classe
        public PageCadOportunidadeSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
