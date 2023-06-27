using NUnit.Framework;
using UnidasTestProject.Controller;
using UnidasTestProject.Resource;
using UnidasTestProject.Settings;

namespace UnidasTestProject.Test
{
    //Feature de Teste
    [TestFixture, Parallelizable(ParallelScope.Fixtures)]
    public class FluxoCotacaoSF : TestBase
    {

        //TestCase
        [Test]
        public void TestFluxoCotacao()
        {
            //Arrange - Pre-condicao do teste
            SetAmbiente(Environment.Web);
            ControllerPageLoginSF ControllerPageLoginSF = new ControllerPageLoginSF(_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new ControllerPageInicioSF(_driver);
            ControllerPageContaSF ControllerPageContaSF = new ControllerPageContaSF(_driver);
            ControllerPageOportunidadeCadSF ControllerPageOportunidadeCadSF = new ControllerPageOportunidadeCadSF(_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new ControllerPageOportunidadeSF(_driver);
            ControllerPageCotacaoSF ControllerPageCotacaoSF = new ControllerPageCotacaoSF(_driver);

            string _usuario = AppSettings.UserQA;
            string _senha = AppSettings.PasswordQA;
            string _nmOportunidade = AppSettings.NmOportunidade;
            string _nmCotacao = AppSettings.NmCotacao;
            string _prazoContrautual = AppSettings.PrazoContratual;
            string _produto = AppSettings.Produto;
            string _tpRodagem = AppSettings.TpRodagem;
            string _quantidade = AppSettings.Quantidade;
            string _tipoUso = AppSettings.TipoUso;
            string _valorVenda = AppSettings.ValorVenda;
            string _usoMensal = AppSettings.UsoMensal;
            string _ufEntrega = AppSettings.UfEntrega;
            string _pMunicipioEntrega = AppSettings.PMunicipioEntrega;
            string _qtdPneus = AppSettings.QtdPneus;
            string _manutencao = AppSettings.Manutencao;
            string _grupo = AppSettings.Grupo;
            string _tpReserva = AppSettings.TpReserva;
            string _qtdDiariaReserva = AppSettings.QtdDiariaReserva;
            

            //Act - Acoes do teste
            ControllerPageLoginSF.FazerLogin(_usuario, _senha);
            ControllerPageInicioSF.PesquisarConta();
            ControllerPageContaSF.NovaOportunidade();
            ControllerPageOportunidadeCadSF.CadNovaOportunidade(_nmOportunidade);
            ControllerPageOportunidadeSF.PrencherCamposNovaOportunidade();
            ControllerPageOportunidadeSF.CadNovaCotacao();
            ControllerPageCotacaoSF.PrencherCamposCotacao(_nmCotacao, _prazoContrautual);
            ControllerPageCotacaoSF.FinalizarCotacao(_produto);
            ControllerPageCotacaoSF.PreencherItensLinhaCotacao(_tpRodagem, _quantidade, _tipoUso, _valorVenda, _usoMensal, _ufEntrega, _pMunicipioEntrega, _qtdPneus, _manutencao, _grupo, _tpReserva, _qtdDiariaReserva);

            //Assert - Validacao do teste
            Assert.IsTrue(true);
        }
        //TestCase
        //[Test]
        //public void OportunidadeUsuarioSemInodadeNegocio()
        //{
        //    //Arrange - Pre-condicao do teste
        //    ControllerPageLoginSF ControllerPageLoginSF = new (_driver);
        //    ControllerPageInicioSF ControllerPageInicioSF = new (_driver);
        //    ControllerPageContaSF ControllerPageContaSF = new (_driver);
        //    ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new (_driver);

        //    string? _usuario = AppSettings.UserQA;
        //    string? _senha = AppSettings.PasswordQA;

        //    //Act - Acoes do teste
        //    ControllerPageLoginSF.FazerLogin(_usuario, _senha);
        //    ControllerPageInicioSF.PesquisarConta();
        //    ControllerPageContaSF.NovaOportunidade();
        //    ControllerPageOportunidadeSF.CadNovaOportunidade();

        //    //Assert - Validacao do teste

        //    Assert.IsTrue(ControllerPageOportunidadeSF.ValidarMsgUsuarioNaoPossuiAreaNegocio());
        //}
       
    }
}