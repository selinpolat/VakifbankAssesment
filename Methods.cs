using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;
using System;

namespace UnitTestProject1
{
    public class Methods
    {
        #region Elements
        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl06_ctl00_rptMenu_ctl00_hypLink\"]")]
        public IWebElement individual;

        [FindsBy(How = How.Id, Using = "ctl00_ctl06_ctl00_rptMenu_ctl03_hypLink")]
        public IWebElement individualCredit;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'shortLinks')]/a[1]")]
        public IWebElement calculationTools;

        [FindsBy(How = How.XPath, Using = "//div[@class='col-xs-12 col-sm-6']/h2")]
        public IWebElement calculationCreditTools;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Form1\"]/div[5]/div[2]/div/div/div[2]/div/div[1]/div[2]/h2")]
        public IWebElement creditCalculationTool;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"Form1\"]/div[5]/div[2]/div/div/div[2]/div/div[1]/div[3]/a")]
        public IWebElement btnCalculate;

        [FindsBy(How = How.XPath, Using = "//*[@class='select2 select2-container select2-container--bootstrap']")]
        public IWebElement creditOption;

        [FindsBy(How = How.Id, Using = "select2-ctl00_ctl10_ctl00_ddlKredi-result-fht3-0-55500523")]
        public IWebElement instSuffixAccount;

        [FindsBy(How = How.Id, Using = "txtTutarVisible")]
        public IWebElement inptAmount;

        [FindsBy(How = How.Id, Using = "ctl00_ctl10_ctl00_btnHesapla")]
        public IWebElement btnCalculateCredit;

        [FindsBy(How = How.Id, Using = "ctl00_ctl10_ctl00_txtVade")]
        public IWebElement maturity;

        [FindsBy(How = How.XPath, Using = "//*[@class='select2-search__field']")]
        public IWebElement input;        
        
        [FindsBy(How = How.XPath, Using = "//*[@class='slider tutarSlider2 ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content']")]
        public IWebElement slider;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ctl00_ctl10_ctl00_ajaxPanel\"]/div[9]/table/tbody/tr[5]/td[2]")]
        public IWebElement calculatedResult;

        #endregion
        public IWebDriver driver;
        public Methods(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void LaunchWebsite(string url)
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void ClickIndividualTab()
        {
            individual.Click();
        }
        public void ClickIndividualCredits()
        {
            individualCredit.Click();
        }
        public bool IsCalculationLinkExists()
        {
            string result = calculationTools.GetAttribute("href");
            return String.IsNullOrEmpty(result);
        }
        public void ClickCalculationTools()
        {
            calculationTools.Click();
        }
        public bool IsCreditCalculationToolExists(string name)
        {
            string text = calculationCreditTools.Text;
            return text == name;
        }
        public void ClickCalculateBtn()
        {
            btnCalculate.Click();
        }
        public void SelectCreditOption()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            creditOption.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            input.SendKeys("TAKSİTLİ EK HESAP");
            input.SendKeys(Keys.Enter);
        }
        public void SetMaturityMonth(string maturityMonth)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            try
            {
                maturity.Click();
            }
            catch (StaleElementReferenceException)
            {
                maturity.Click();
            }
            maturity.Clear();
            maturity.SendKeys(maturityMonth);
            maturity.SendKeys(Keys.Enter);
        }
        public bool SetAmount(string amount)
        {
            string result = inptAmount.GetAttribute("value");
            return result == amount;
        }
        public void ClickBtnCalculate()
        {
            btnCalculateCredit.Click();
        }
        public bool CheckCalculationAmount(string expectedResult)
        {
            string result = calculatedResult.Text;
            driver.Quit();
            return result.Contains(expectedResult);
        }
    }
}