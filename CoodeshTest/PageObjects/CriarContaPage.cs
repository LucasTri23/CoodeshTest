using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class CriarContaPage
    {
        private IWebDriver driver;
        private By byBtnAceitarCookies;
        private By byBtnCriarConta;
        private By byNome;
        private By byEmail;
        private By bySenha;
        private By byAceitarTermos;
        private By byBtnIncrever;
        private By byBtnLikedin;
        private By byEmailLinkedin;
        private By bySenhaLinkedin;
        private By byLogarLinkedin;



        public CriarContaPage(IWebDriver driver)
        {
            this.driver = driver;
            byBtnAceitarCookies = By.Id("onetrust-accept-btn-handler");
            byBtnCriarConta = By.XPath("/html/body/div[1]/header/div/div/nav/div[2]/ul/li[5]/a/button");
            byNome = By.Id("displayName");
            byEmail = By.Id("email");
            bySenha = By.Id("password");
            byAceitarTermos = By.XPath("//*[@id='content']/div/div/div/div[2]/form/div[4]/div/label/span");
            byBtnIncrever = By.XPath("//*[@id='content']/div/div/div/div[2]/form/div[5]/div/button");
            byBtnLikedin = By.XPath("/html/body/div[1]/main/div/div/div/div[2]/div/div[1]/div[2]/button[3]");
            byEmailLinkedin = By.Id("username");
            bySenhaLinkedin = By.Id("password");
            byLogarLinkedin = By.XPath("//button[@type='submit']");
        }

        public void AcessarPagina()
        {
            driver.Navigate().GoToUrl("https://beta.coodesh.com");
            Thread.Sleep(0500);
            driver.FindElement(byBtnAceitarCookies).Click();
        }

        public void CriarConta(string nome, string email, string senha)
        {
            driver.FindElement(byBtnCriarConta).Click();
            Thread.Sleep(1000);
            driver.FindElement(byNome).SendKeys(nome);
            driver.FindElement(byEmail).SendKeys(email);
            driver.FindElement(bySenha).SendKeys(senha);
            driver.FindElement(byAceitarTermos).Click();
            Thread.Sleep(300);
            driver.FindElement(byBtnIncrever).Click();
            Thread.Sleep(5000);
        }

        public void CriarContaComLinkedin(string email, string senha)
        {
            driver.FindElement(byBtnLikedin).Click();
            Thread.Sleep(1000);
            driver.FindElement(byEmailLinkedin).SendKeys(email);
            driver.FindElement(bySenhaLinkedin).SendKeys(senha);
            driver.FindElement(byLogarLinkedin).Click();

        }
        
    }
}
