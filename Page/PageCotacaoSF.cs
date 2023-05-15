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

        [FindsBy(How = How.XPath, Using = "//span[@title='Itens da linha de cotação']")]
        [CacheLookup]
        public IWebElement? _ItensLinhaCotacao;

        [FindsBy(How = How.XPath, Using = "//div[@title='Adicionar produtos']")]
        [CacheLookup]
        public IWebElement? _AdicionarProdutos;

        [FindsBy(How = How.XPath, Using = "//input[@role='combobox']")]
        [CacheLookup]
        public IWebElement? _FiltrarProdutos;

        [FindsBy(How = How.XPath, Using = "//td[@tabindex='-1']//input[@tabindex='0']")]
        [CacheLookup]
        public IWebElement? _SelecionarProduto;

        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Avançar')]")]
        [CacheLookup]
        public IWebElement? _BtnAvancar;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Tipo de rodagem: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtTipoRodagem;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Quantidade: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtQuantidade;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Tipo de uso: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtTipoUso;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Valor de Venda: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtValorVenda;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Uso mensal: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtUsoMensal;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar UF de entrega: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtUfEntrega;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Tipo município entrega: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtTpMunicipioEntrega;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Quantidade de pneus: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtQtdPneus;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Manutenção: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtManutencao;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Grupo: Item 1 editado')]")]
        [CacheLookup]
        public IWebElement? _txtGrupo;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Tipo de reserva: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtTpReserva;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Editar Quantidade diárias de reserva: Item 1')]")]
        [CacheLookup]
        public IWebElement? _txtQtdDiariaReserva;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Salvar')]")]
        [CacheLookup]
        public IWebElement? _btnSalvarItensLinha;

        //Contrutor da classe
        public PageCotacaoSF(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }            
    }
}
