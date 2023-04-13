using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class StepDefinitions
    {
        [Binding, Scope(Feature = "Steps")]
        public class Steps
        {
            static IWebDriver webDriver = new ChromeDriver();

            Methods methods = new Methods(webDriver);

            [StepDefinition(@"""([^""]*)"" sitesine giriş yapılır\.")]
            public void GivenSitesineGirisYapılır_(string url)
            {
                methods.LaunchWebsite(url);
            }
            [StepDefinition(@"“Bireysel” tabına tıklanır")]
            public void ClickIndividualTab()
            {
                methods.ClickIndividualTab();
            }
            [StepDefinition(@"Açılan menüden “Bireysel Krediler” sekmesine tıklanır\.")]
            public void ClickIndividualCredits()
            {
                methods.ClickIndividualCredits();
            }
            [StepDefinition(@"“Hesaplama Araçları” linkinin var olduğu kontrol edilir\.")]
            public void IsCalculationLinkExists()
            {
                Assert.IsFalse(methods.IsCalculationLinkExists());
            }
            [StepDefinition(@"“Hesaplama Araçları” linkine tıklanır\.")]
            public void ClickCalculationTools()
            {
                methods.ClickCalculationTools();
            }

            [StepDefinition(@"""([^""]*)"" alanıın ekranda yer aldığı kontrol edilir\.")]
            public void IsCreditCalculationToolExists(string name)
            {
                Assert.IsTrue(methods.IsCreditCalculationToolExists(name));
            }

            [StepDefinition(@"Kredi Hesaplama Aracı alanındaki “Hesapla Butonuna” tıklanır")]
            public void ClickCalculateBtn()
            {
                methods.ClickCalculateBtn();
            }
            [StepDefinition(@"Kredi drop box ından “TAKSİTLİ EK HESAP” seçeneği seçilir")]
            public void SelectCreditOption()
            {
                methods.SelectCreditOption();
            }
            [StepDefinition(@"Tutar alanı ""([^""]*)"" olarak setli olmalıdır\.")]
            public void SetAmount(string amount)
            {
                Assert.IsTrue(methods.SetAmount(amount));
            }
            [StepDefinition(@"Aynı ekrandaki Hesapla butonuna tıklanır\.")]
            public void ClickBtnCalculate()
            {
                methods.ClickBtnCalculate();
            }
            [StepDefinition(@"Toplam Ödenecek tutar alanında ""([^""]*)"" olduğu kontrol edilir")]
            public void CheckCalculationAmount(string exxpectedResult)
            {
                Assert.IsTrue(methods.CheckCalculationAmount(exxpectedResult));
            }
            [StepDefinition(@"Vade alanına ""([^""]*)"" yazılır")]
            public void SetMaturityMonth(string month)
            {
                methods.SetMaturityMonth(month);
            }
        }
    }
}
