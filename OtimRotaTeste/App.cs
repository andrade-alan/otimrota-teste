using OtimRotaTeste.PageObjects;
using OtimRotaTeste.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OtimRotaTeste
{
    [TestClass]
    public class App
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private static readonly string _otimrotaAppId = @"C:\Users\aandrade\Documents\OtimArranjo\OtimrotaArranjo\bin\Debug\OtimRota.exe";
        private InputLanguageHelper _iHelper;
        private const int en_us = 1033;
        private const int pt_br = 1046;

        public static WindowsDriver<WindowsElement> Session { get; private set; }

        public void Run()
        {
            _iHelper = new InputLanguageHelper();

            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", _otimrotaAppId);



            Session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(Session);
            Assert.IsNotNull(Session.SessionId);
            Assert.AreEqual("OtimRota  v. 1.3.1.6  (Novo Projeto)", Session.Title);

            _iHelper.LoadBrazilianKeyboardLayout();
            Thread.Sleep(TimeSpan.FromSeconds(1.5));
            //Session.Manage().Timeouts().ImplicitWait.Seconds(1.5);
        }

        public void Quit()
        {

            App.Session.FindElementByName(OtimRotaMainControls.OtimRotaMainGUIButtonClose).Click();
            try
            {
                App.Session.FindElementByName("");
                App.Session.FindElementByAccessibilityId(OtimRotaMainControls.OtimRotaMainGUIButtonNoSave);
            }
            catch (Exception e)
            {
                Console.Write("No Screnn Found. Closing App. Error message: " + e.Message);
            }

            _iHelper.LoadBrazilianKeyboardLayout();
        }

        public void ClicarBotaoPocosReservatorios()
        {
            App.Session.FindElementByName(OtimRotaMainControls.OtimRotaItemPocRes).Click();
            //App.Session.FindElementByName(OtimRotaMainControls.OtimRotaItemPocos);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            App.Session.FindElementByName(OtimRotaMainControls.OtimRotaMainGUIButtonNovo).Click();
            var dropDown = App.Session.FindElementByName("DropDown");
            var produtor = dropDown.FindElementByName("Produtor");
            Actions action = new Actions(App.Session);
            action.Click(produtor).Perform();
            App.Session.FindElementByName(OtimRotaMainControls.OtimRotaMainGUIButtonOk).Click();
        } 

    }
}