using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class OnboardingComunidadesPage
    {
        private IWebDriver driver;
        private By byComunidades;
        private By byCausasSociais;
        private By byRaca;
        private By byGenero;
        private By byOrientacao;
        private By byDefciencia;
        private By byBtnScoreCard;
        private By byBtnProximo;


        public OnboardingComunidadesPage(IWebDriver driver)
        {
            this.driver = driver;
            byComunidades = By.XPath("//div[@id='__next']/div[3]/div/div/div/div/div[2]/form/div/div/div/div/div/div");
            byCausasSociais = By.Id("react-select-3-input");
            byRaca = By.Id("race");
            byGenero = By.Id("gender");
            byOrientacao = By.Id("sexual_orientation");
            byDefciencia = (By.Id("disabilities.type"));
            byBtnScoreCard = By.LinkText("Responder agora");
            byBtnProximo = By.XPath("/html/body/div[1]/div[4]/div/div/div/div/button[2]");
        }

        public void OnboradingDois(/*string comunidades,*/ string causasS)
        {
            Thread.Sleep(1000);
            //driver.FindElement(byComunidades).SendKeys(comunidades + Keys.Enter); //nao obrigatorio
            driver.FindElement(byCausasSociais).SendKeys(causasS + Keys.Enter);
            driver.FindElement(byRaca).Click();
            new SelectElement(driver.FindElement(byRaca)).SelectByText("Pessoa Parda"); //selecionar Raça/Cor
            Thread.Sleep(0300);
            driver.FindElement(byGenero).Click();
            new SelectElement(driver.FindElement(byGenero)).SelectByText("Homem"); //selecionar Genero
            Thread.Sleep(0300);
            driver.FindElement(byOrientacao).Click();
            new SelectElement(driver.FindElement(byOrientacao)).SelectByText("Heterossexual"); //selecionar Orientação Sexual
            Thread.Sleep(0500);
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0, 950)");
            Thread.Sleep(0900);
            driver.FindElement(byDefciencia).Click();
            new SelectElement(driver.FindElement(byDefciencia)).SelectByText("Nenhuma deficiência"); //selecionar Deficiencia
        }

        public void ScoreCard()
        {
            Thread.Sleep(1500);
            driver.FindElement(byBtnScoreCard).Click();
        }

        public void Proximo()
        {
            driver.FindElement(byBtnProximo).Click();
        }
    }
}
