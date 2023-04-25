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
    }
}
