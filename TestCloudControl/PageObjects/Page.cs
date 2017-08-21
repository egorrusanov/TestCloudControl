﻿using OpenQA.Selenium.Support.PageObjects;

namespace TestCloudControl.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static MainPage Main
        {
            get { return GetPage<MainPage>(); }
        }
    }
}
