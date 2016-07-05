﻿using System;
using System.Globalization;
using SecurityEssentials.Acceptance.Tests.Web.Pages;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using SecurityEssentials.Acceptance.Tests.Utility;

namespace SecurityEssentials.Acceptance.Tests.Web.Extensions
{
	[Binding]
	public class HomePageSteps
	{
		[Given(@"I am taken to the homepage")]
		[When(@"I am taken to the homepage")]
		public void ThenIAmTakenToTheHomepage()
		{			
            var homePage = ScenarioContext.Current.GetPage<HomePage>();
			Assert.IsTrue(homePage.IsCurrentPage);
		}

        [Given(@"I click register in the title bar")]
		public void GivenIClickRegisterInTheTitleBar()
		{
			var homePage = ScenarioContext.Current.GetPage<HomePage>();
			homePage.ClickRegister();
		}

		[When(@"I click login")]
        [Given(@"I click login")]
		public void GivenIClickLogin()
		{
			var homePage = ScenarioContext.Current.GetPage<HomePage>();
			homePage.ClickLogin();

		}


	}
}