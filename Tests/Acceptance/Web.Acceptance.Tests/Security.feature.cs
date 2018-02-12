﻿#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable
namespace SecurityEssentials.Acceptance.Tests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Security")]
    public partial class SecurityFeature
    {
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        private TechTalk.SpecFlow.ITestRunner testRunner;

        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(
                new System.Globalization.CultureInfo("en-US"), "Security",
                "\tIn order to avoid information disclosure\r\n\tAs a pen tester\r\n\tI want to be sure t" +
                "he application has the correct security settings and behaviour", ProgrammingLanguage.CSharp,
                ((string[]) (null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        public virtual void FeatureBackground()
        {
#line 6
#line 7
            testRunner.Given("I delete all cookies from the cache", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 8
            testRunner.And("I clear down the database", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 9
            testRunner.And("I have the standard set of lookups", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line hidden
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "A user with an expired password is redirected to the change password page until t" +
            "hey change the password")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        public virtual void AUserWithAnExpiredPasswordIsRedirectedToTheChangePasswordPageUntilTheyChangeThePassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "A user with an expired password is redirected to the change password page until t" +
                "hey change the password", new string[]
                {
                    "CheckForErrors"
                });
#line 107
            this.ScenarioSetup(scenarioInfo);
#line 6
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "Title",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "IsAdmin",
                "Approved",
                "Enabled",
                "WorkTelephoneNumber",
                "HomeTelephoneNumber",
                "MobileTelephoneNumber",
                "Town",
                "Postcode",
                "SkypeName",
                "PasswordExpiryDate"
            });
            table11.AddRow(new string[]
            {
                "user1@test.net",
                "Mr",
                "Needs",
                "Approval",
                "zasXX8576jFj123",
                "What is the name of your first pet?",
                "Beatrix",
                "false",
                "true",
                "true",
                "0123",
                "0456",
                "0789",
                "town",
                "postcode",
                "skype",
                "[Expired]"
            });
#line 108
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table11, "Given ");
#line 111
            testRunner.And("the user \'user1@test.net\' has the password expiry date set", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 112
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 113
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 114
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table12.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
            table12.AddRow(new string[]
            {
                "Password",
                "zasXX8576jFj123"
            });
#line 115
            testRunner.And("I enter the following login data:", ((string) (null)), table12, "And ");
#line 119
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 120
            testRunner.And("I am navigated to the \'Change Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 121
            testRunner.And("I select Admin -> Change Security Information from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 122
            testRunner.And("I am navigated to the \'Change Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 123
            testRunner.And("I select Admin -> Manage Account from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 124
            testRunner.And("I am navigated to the \'Change Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table13.AddRow(new string[]
            {
                "CurrentPassword",
                "zasXX8576jFj123"
            });
            table13.AddRow(new string[]
            {
                "NewPassword",
                "NewPassword45678"
            });
            table13.AddRow(new string[]
            {
                "ConfirmNewPassword",
                "NewPassword45678"
            });
#line 125
            testRunner.And("I enter the following change password data:", ((string) (null)), table13, "And ");
#line 130
            testRunner.When("I submit the change password form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 131
            testRunner.Then("I am navigated to the \'Change Password Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 132
            testRunner.And("the user \'user1@test.net\' does not have the password expiry date set", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 133
            testRunner.And("I select Admin -> Change Security Information from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 134
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table14.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
            table14.AddRow(new string[]
            {
                "Password",
                "NewPassword45678"
            });
#line 135
            testRunner.And("I enter the following login data:", ((string) (null)), table14, "And ");
#line 139
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 140
            testRunner.And("I am navigated to the \'Change Security Information\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The application will prevent a brute force login attempt")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        public virtual void TheApplicationWillPreventABruteForceLoginAttempt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "The application will prevent a brute force login attempt", new string[]
                {
                    "CheckForErrors"
                });
#line 66
            this.ScenarioSetup(scenarioInfo);
#line 6
            this.FeatureBackground();
#line 67
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 68
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 69
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 70
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table7.AddRow(new string[]
            {
                "UserName",
                "attempt1@test.net"
            });
            table7.AddRow(new string[]
            {
                "Password",
                "rhubarb22"
            });
#line 71
            testRunner.And("I enter the following login data:", ((string) (null)), table7, "And ");
#line 75
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 76
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 77
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 78
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 79
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table8.AddRow(new string[]
            {
                "UserName",
                "attempt2@test.net"
            });
            table8.AddRow(new string[]
            {
                "Password",
                "rhubarb22"
            });
#line 80
            testRunner.And("I enter the following login data:", ((string) (null)), table8, "And ");
#line 84
            testRunner.And("I click the login button as quickly as possible", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 85
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 86
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 87
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 88
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table9.AddRow(new string[]
            {
                "UserName",
                "attempt3@test.net"
            });
            table9.AddRow(new string[]
            {
                "Password",
                "rhubarb22"
            });
#line 89
            testRunner.And("I enter the following login data:", ((string) (null)), table9, "And ");
#line 93
            testRunner.And("I click the login button as quickly as possible", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 94
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 95
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 96
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 97
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table10.AddRow(new string[]
            {
                "UserName",
                "attempt4@test.net"
            });
            table10.AddRow(new string[]
            {
                "Password",
                "rhubarb22"
            });
#line 98
            testRunner.And("I enter the following login data:", ((string) (null)), table10, "And ");
#line 102
            testRunner.When("I click the login button as quickly as possible", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 103
            testRunner.And("I wait 2 seconds", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 104
            testRunner.Then("an error message is shown \'You have requested this resource too many times in the" +
                            " last 60 seconds.\'", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will log a content security policy violation")]
        public virtual void TheWebApplicationWillLogAContentSecurityPolicyViolation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("The web application will log a content security policy violation",
                    ((string[]) (null)));
#line 11
            this.ScenarioSetup(scenarioInfo);
#line 6
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table1.AddRow(new string[]
            {
                "BlockedUri",
                "http://myevilsite.com/stealdetails/capture/"
            });
            table1.AddRow(new string[]
            {
                "DocumentUri",
                "http://mysite.com/innocentpage/"
            });
            table1.AddRow(new string[]
            {
                "LineNumber",
                "1"
            });
            table1.AddRow(new string[]
            {
                "Referrer",
                ""
            });
            table1.AddRow(new string[]
            {
                "OriginalPolicy",
                "default-src http://localhost:4845"
            });
            table1.AddRow(new string[]
            {
                "ScriptSample",
                "#modernizr{font:0/0 a}#modernizr:after{c..."
            });
            table1.AddRow(new string[]
            {
                "SourceFile",
                "http://mysite.com/innocentpage/"
            });
            table1.AddRow(new string[]
            {
                "ViolatedDirective",
                "default-src http://mysite.com"
            });
#line 12
            testRunner.Given("I have a content security policy violation with details:", ((string) (null)), table1,
                "Given ");
#line 22
            testRunner.When("I post the content security policy violation to the website", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 23
            testRunner.And("I wait 2 seconds", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 24
            testRunner.Then("I have 1 content security policy violation in the system", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table2.AddRow(new string[]
            {
                "Level",
                "Warning"
            });
            table2.AddRow(new string[]
            {
                "Message",
                "BlockedUri: \"http://myevilsite.com/stealdetails/capture/\""
            });
#line 25
            testRunner.And("I have a log in the system matching the following:", ((string) (null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will log a http public key pinning violation")]
        public virtual void TheWebApplicationWillLogAHttpPublicKeyPinningViolation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("The web application will log a http public key pinning violation",
                    ((string[]) (null)));
#line 30
            this.ScenarioSetup(scenarioInfo);
#line 6
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table3.AddRow(new string[]
            {
                "DateTime",
                "2017-12-07"
            });
            table3.AddRow(new string[]
            {
                "HostName",
                "http://mysite.com/"
            });
            table3.AddRow(new string[]
            {
                "Port",
                "8080"
            });
            table3.AddRow(new string[]
            {
                "ExpirationDate",
                "2018-12-01"
            });
            table3.AddRow(new string[]
            {
                "IncludeSubDomains",
                "True"
            });
            table3.AddRow(new string[]
            {
                "NotedHostName",
                ""
            });
            table3.AddRow(new string[]
            {
                "ServedCertificateChainDelimited",
                "pem1,pem2,pem3"
            });
            table3.AddRow(new string[]
            {
                "ValidatedCertificateChainDelimited",
                "pem1,pem2,pem4"
            });
            table3.AddRow(new string[]
            {
                "KnownPinsDelimited",
                "known-pin1,known-pin2,known-pin3"
            });
#line 31
            testRunner.Given("I have a http public key pinning violation with details:", ((string) (null)), table3,
                "Given ");
#line 42
            testRunner.When("I post the http public key pinning violation to the website", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 43
            testRunner.And("I wait 2 seconds", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 44
            testRunner.Then("I have 1 http public key pinning violation in the system", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table4.AddRow(new string[]
            {
                "Level",
                "Warning"
            });
            table4.AddRow(new string[]
            {
                "Message",
                "HostName: \"http://mysite.com/\""
            });
#line 45
            testRunner.And("I have a log in the system matching the following:", ((string) (null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will return the correct security headers")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        public virtual void TheWebApplicationWillReturnTheCorrectSecurityHeaders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "The web application will return the correct security headers", new string[]
                {
                    "CheckForErrors"
                });
#line 51
            this.ScenarioSetup(scenarioInfo);
#line 6
            this.FeatureBackground();
#line 52
            testRunner.When("I call http get on the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Key",
                "Value"
            });
            table5.AddRow(new string[]
            {
                "X-Frame-Options",
                "Deny"
            });
            table5.AddRow(new string[]
            {
                "X-Content-Type-Options",
                "nosniff"
            });
            table5.AddRow(new string[]
            {
                "X-XSS-Protection",
                "1; mode=block"
            });
            table5.AddRow(new string[]
            {
                "Referrer-Policy",
                "origin"
            });
#line 53
            testRunner.Then("the response headers will contain:", ((string) (null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Key"
            });
            table6.AddRow(new string[]
            {
                "X-AspNet-Version"
            });
            table6.AddRow(new string[]
            {
                "X-AspNetMvc-Version"
            });
            table6.AddRow(new string[]
            {
                "Server"
            });
#line 59
            testRunner.And("the response headers will not contain:", ((string) (null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore

#endregion