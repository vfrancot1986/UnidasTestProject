using MongoDB.Bson.Serialization.Serializers;
using OpenQA.Selenium;
using UnidasTestProject.Page;
using static UnidasTestProject.Resource.TestBase;
using Action = UnidasTestProject.Resource.TestBase.Action;

namespace UnidasTestProject.Controller
{
    public class ControllerPageCotacaoSF
    {

        //Declaracao de variaveis
        public PageCotacaoSF _PageCotacaoSF;
        //Contrutor da classe
        public ControllerPageCotacaoSF(IWebDriver driver)
        {
            _PageCotacaoSF = new PageCotacaoSF(driver);
        }

        //Acoes da pagina
        public void PrencherCamposCotacao(string nmCotacao, string prazoContratual)
        {
            ThisElement(_PageCotacaoSF._txtNomeCotacao, Action.SendKey, nmCotacao);
            ThisElement(_PageCotacaoSF._txtPrazoContratual, Action.SendKey, prazoContratual);
            ThisElement(_PageCotacaoSF._btnSalvar, Action.Click);
        }
        public void FinalizarCotacao(string produto)
        {
            ThisElement(_PageCotacaoSF._ItensLinhaCotacao, Action.Click);
            ThisElement(_PageCotacaoSF._AdicionarProdutos, Action.Click);
            ThisElement(_PageCotacaoSF._FiltrarProdutos, Action.SendKey, produto);
            ThisElement(_PageCotacaoSF._FiltrarProdutos, Action.Enter);
            ThisElement(_PageCotacaoSF._SelecionarProduto, Action.ClickJs);
            ThisElement(_PageCotacaoSF._BtnAvancar, Action.Click);
        }
        public void PreencherItensLinhaCotacao(string tpRodagem, string quantidade, string tipoUso, string valorVenda, string usoMensal, string ufEntrega, string pMunicipioEntrega, string qtdPneus, string manutencao, string grupo, string tpReserva, string qtdDiariaReserva)
        {
            ThisElement(_PageCotacaoSF._txtTipoRodagem, Action.Click);
            ThisElement(_PageCotacaoSF._txtTipoRodagem, Action.SendKey, tpRodagem);
            ThisElement(_PageCotacaoSF._txtQuantidade, Action.Click);
            ThisElement(_PageCotacaoSF._txtQuantidade, Action.SendKey, quantidade);
            ThisElement(_PageCotacaoSF._txtTipoUso, Action.Click);
            ThisElement(_PageCotacaoSF._txtTipoUso, Action.SendKey, tipoUso);
            ThisElement(_PageCotacaoSF._txtValorVenda, Action.Click);
            ThisElement(_PageCotacaoSF._txtValorVenda, Action.SendKey, valorVenda);
            ThisElement(_PageCotacaoSF._txtUsoMensal, Action.Click);
            ThisElement(_PageCotacaoSF._txtUsoMensal, Action.SendKey, usoMensal);
            ThisElement(_PageCotacaoSF._txtUfEntrega, Action.Click);
            ThisElement(_PageCotacaoSF._txtUfEntrega, Action.SendKey, ufEntrega);
            ThisElement(_PageCotacaoSF._txtTpMunicipioEntrega, Action.Click);
            ThisElement(_PageCotacaoSF._txtTpMunicipioEntrega, Action.SendKey, pMunicipioEntrega);
            ThisElement(_PageCotacaoSF._txtQtdPneus, Action.Click);
            ThisElement(_PageCotacaoSF._txtQtdPneus, Action.SendKey, qtdPneus);
            ThisElement(_PageCotacaoSF._txtManutencao, Action.Click);
            ThisElement(_PageCotacaoSF._txtManutencao, Action.SendKey, manutencao);
            ThisElement(_PageCotacaoSF._txtGrupo, Action.Click);
            ThisElement(_PageCotacaoSF._txtGrupo, Action.SendKey, grupo);
            ThisElement(_PageCotacaoSF._txtTpReserva, Action.Click);
            ThisElement(_PageCotacaoSF._txtTpReserva, Action.SendKey, tpReserva);
            ThisElement(_PageCotacaoSF._txtQtdDiariaReserva, Action.Click);
            ThisElement(_PageCotacaoSF._txtQtdDiariaReserva, Action.SendKey, qtdDiariaReserva);
            ThisElement(_PageCotacaoSF._btnSalvarItensLinha, Action.Click);

        }
    }
}
