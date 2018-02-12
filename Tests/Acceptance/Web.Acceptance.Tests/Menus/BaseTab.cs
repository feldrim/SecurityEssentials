﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SecurityEssentials.Acceptance.Tests.Web.Menus
{
    public abstract class BaseTab
    {
        private readonly string _dropdowndId;
        private readonly string _menuId;
        private readonly WebDriverWait _wait;
        protected readonly Uri BaseUri;
        protected readonly IWebDriver Driver;

        protected BaseTab(IWebDriver driver, Uri baseUri, string title, string menuId, string dropdownId = null)
        {
            Driver = driver;
            _menuId = menuId;
            _dropdowndId = dropdownId;
            BaseUri = baseUri;
            Title = title;
            _wait = new WebDriverWait(driver,
                new TimeSpan(0, 0, Convert.ToInt32(ConfigurationManager.AppSettings["WaitIntervalSeconds"])));
        }

        public string Title { get; }

        protected void Click(string id)
        {
            var element = GetVisibleWebElement(By.Id(id));
            element.Click();
        }

        public void ClickMenu()
        {
            Click(_dropdowndId);
        }

        protected IWebElement GetVisibleWebElement(By by)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public bool IsEnabled()
        {
            var elements = Driver.FindElements(By.Id(_menuId));
            if (!elements.Any()) throw new InvalidOperationException("Element with menuId " + _menuId + " not found");

            var element = elements.Single();
            var classValue = element.GetAttribute("class");
            return !classValue.Contains("greyed-out");
        }

        public IList<string> GetEnabledSubMenuOptions()
        {
            Click(_dropdowndId);
            var menuElement = Driver.FindElement(By.Id(_menuId));
            var options = menuElement.FindElements(By.CssSelector("ul > li > a"));
            var subMenuOptions = options.Where(o => o.Text != Title).Select(o => o.Text).ToList();
            Click(_dropdowndId);
            return subMenuOptions;
        }

        public IList<string> GetGreyedOutSubMenuOptions()
        {
            Click(_dropdowndId);
            var menuElement = Driver.FindElement(By.Id(_menuId));
            var options = menuElement.FindElements(By.CssSelector("ul > li.greyed-out"));
            var subMenuOptions = options.Where(o => o.Text != Title).Select(o => o.Text).ToList();
            Click(_dropdowndId);
            return subMenuOptions;
        }
    }
}