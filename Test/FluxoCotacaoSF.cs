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
            ControllerPageLoginSF ControllerPageLoginSF = new (_driver);
            ControllerPageInicioSF ControllerPageInicioSF = new (_driver);
            ControllerPageContaSF ControllerPageContaSF = new (_driver);
            ControllerPageOportunidadeCadSF ControllerPageOportunidadeCadSF = new (_driver);
            ControllerPageOportunidadeSF ControllerPageOportunidadeSF = new(_driver);
            ControllerPageCotacaoSF ControllerPageCatacaoSF = new(_driver);

            string _usuario = AppSettings.UserQA;
            string _senha = AppSettings.PasswordQA;
            string _nmOportunidade = AppSettings.NmOportunidade;
            string _nmCotacacao = AppSettings.NmCotacao;
            string _prazoContrautual = AppSettings.PrazoContratual;

            //Act - Acoes do teste
            ControllerPageLoginSF.FazerLogin(_usuario, _senha);
            ControllerPageInicioSF.PesquisarConta();
            ControllerPageContaSF.NovaOportunidade();
            ControllerPageOportunidadeCadSF.CadNovaOportunidade(_nmOportunidade);
            ControllerPageOportunidadeSF.PrencherCamposNovaOportunidade();
            ControllerPageOportunidadeSF.CadNovaCotacao();
            ControllerPageCatacaoSF.PrencherCamposCotacao(_nmCotacacao, _prazoContrautual);

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