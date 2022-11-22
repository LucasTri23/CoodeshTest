using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace CoodeshTest.PageObjects
{
    public class OnboradingPage
    {
        private IWebDriver driver;
        private By byQATestes;
        private By byProductManager;
        private By byDataScientist;
        private By byBackEnd;
        private By byFrontEnd; //escolher habilidades no metodo habilidades (MAX. 3)
        private By byFullStack;
        private By byMobile;
        private By byDevOps;
        private By byDBA;
        private By byCTO;
        private By byProductOwner;
        private By byUXUI;
        private By byHabilidades;
        private By byUmAno;
        private By byMomento;
        private By byNumero;
        private By byCidade;
        private By byRemoto;
        private By byPresencial; //escolher no metodo FinalizarOnborading qual modelo 
        private By byHibrido;
        private By byBtnProximo;


        public OnboradingPage(IWebDriver driver)
        {
            this.driver = driver;
            byQATestes = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[7]/div");
            byProductManager = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[11]/div");
            byDataScientist = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[6]/div");
            byHabilidades = By.Id("react-select-4-input");
            byBackEnd = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[1]/div");
            byFrontEnd = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[2]/div");
            byFullStack = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[3]/div");
            byMobile = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[4]/div");
            byDevOps = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[5]/div");
            byDBA = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[8]/div");
            byCTO = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[9]/div");
            byProductOwner = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[10]/div");
            byUXUI = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[3]/div[12]/div");
            byUmAno = By.XPath("/html/body/div[1]/div[3]/div/div/div/div/div[1]/form/div[4]/div[2]/div/div[5]/span[2]");
            byMomento = By.Id("preferences.job_search");
            byNumero = By.XPath("//input[@value='+55']");
            byCidade = By.Id("address.city");
            byPresencial = By.Id("home-office-none");
            byHibrido = By.Id("home-office-partial");
            byRemoto = By.Id("home-office-integral");
            byBtnProximo = By.XPath("/html/body/div[1]/div[4]/div/div/div/div/button");
        }

        public void Carreiras()
        {
            Thread.Sleep(3000);
            driver.FindElement(byQATestes).Click();
            driver.FindElement(byProductManager).Click();
            driver.FindElement(byDataScientist).Click();
        }

        public void Habilidades(string competencias)
        {
            driver.FindElement(byHabilidades).Click();
            Thread.Sleep(3000);
            driver.FindElement(byHabilidades).SendKeys(competencias);
        }

        public void FinalizarOnborading(double numero, string cidade)
        {
            driver.FindElement(byUmAno).Click();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0, 950)");
            Thread.Sleep(2000);

            driver.FindElement(byMomento).Click();
            new SelectElement(driver.FindElement(byMomento)).SelectByText("Busco oportunidades para iniciar o trabalho imediatamente"); //escolher momento
            driver.FindElement(byNumero).SendKeys(numero.ToString());
            driver.FindElement(byCidade).SendKeys(cidade);
            driver.FindElement(byHibrido).Click();
        }

        public void Proximo()
        {
            Thread.Sleep(1000);
            driver.FindElement(byBtnProximo).Click();
        }

    }
}
