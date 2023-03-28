﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using UnidasTestProject.Resource;

namespace UnidasTestProject.Page
{
    public class PageContaSF
    {
        //Declaração de variáveis
        private IWebDriver _driver;
        private WebDriverWait _espera;

        //Mapeamento dos elementos
        [FindsBy(How = How.XPath, Using = "//lightning-formatted-text[@class='custom-truncate']")]
        [CacheLookup]
        private IWebElement _txtTituloConta;

        [FindsBy(How = How.XPath, Using = "//button[@title='Neutral action']")]
        [CacheLookup]
        private IWebElement? _btnNovaOportunidade;

        //Contrutor da classe
        public PageContaSF(IWebDriver driver)
        {
            _driver = driver;
            _espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        //Ações da página
        public void AguardaPagina() {
            TestBase.thisElement(_txtTituloConta);            
        }
        public void NovaOportunidade()
        {
            TestBase.thisElement(_btnNovaOportunidade, action.Click);     
        }
    }
}
