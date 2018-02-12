using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SecurityEssentials.Acceptance.Tests.Menus;
using SecurityEssentials.Acceptance.Tests.Model;

namespace SecurityEssentials.Acceptance.Tests.Pages
{
    public class UserIndexPage : BasePage
    {
        public UserIndexPage(IWebDriver webDriver, Uri baseUri)
            : base(webDriver, baseUri, PageTitles.USERS_INDEX)
        {
            MenuBar = new MenuBar(webDriver, baseUri);
        }

        public MenuBar MenuBar { get; }
        private IWebElement UserTable => GetVisibleWebElement(By.Id("kendoUserGrid"));

        private IWebElement EditButton(string text)
        {
            var row = UserTable.FindElement(By.XPath($"//tr[td//text()[contains(., '{text}')]]"));
            return row.FindElement(By.CssSelector("a.editUser"));
        }

        public void ClickEditUserWithName(string text)
        {
            // Click the row with the right text
            EditButton(text).Click();
        }

        public List<UserModel> GetUsersDisplayed()
        {
            var usersDisplayed = new List<UserModel>();
            var rowCollection = UserTable.FindElements(By.CssSelector("tr"));
            foreach (var dataRow in rowCollection)
            {
                var columnCollection = dataRow.FindElements(By.TagName("td"));
                if (columnCollection.Count > 0) usersDisplayed.Add(MapRow(columnCollection));
            }

            return usersDisplayed;
        }

        private UserModel MapRow(IList<IWebElement> columnCollection)
        {
            var model = new UserModel
            {
                UserName = columnCollection[2].Text.Trim(' '),
                FullName = columnCollection[0].Text.Trim(' '),
                TelNoMobile = columnCollection[3].Text.Trim(' '),
                Enabled = columnCollection[4].FindElements(By.CssSelector("input[checked='']")).Count > 0,
                Approved = columnCollection[5].FindElements(By.CssSelector("input[checked='']")).Count > 0
            };
            return model;
        }
    }
}