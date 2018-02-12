﻿#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable
namespace SecurityEssentials.Acceptance.Tests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Account")]
    [NUnit.Framework.CategoryAttribute("CheckForErrors")]
    public partial class AccountFeature
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
                new System.Globalization.CultureInfo("en-US"), "Account",
                "\tIn order to securely access the application\r\n\tAs a user\r\n\tI want to be manage my" +
                " account", ProgrammingLanguage.CSharp, new string[]
                {
                    "CheckForErrors"
                });
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
#line 7
#line 8
            testRunner.Given("I delete all cookies from the cache", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Given ");
#line 9
            testRunner.And("I clear down the database", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 10
            testRunner.And("I have the standard set of lookups", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line hidden
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change my email address")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void ICanChangeMyEmailAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "I can change my email address", new string[]
                {
                    "PAT"
                });
#line 203
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table29.AddRow(new string[]
            {
                "user5@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 204
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table29, "Given ");
#line 207
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 208
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 209
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table30.AddRow(new string[]
            {
                "UserName",
                "user5@test.net"
            });
            table30.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
#line 210
            testRunner.And("I enter the following login data:", ((string) (null)), table30, "And ");
#line 214
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 215
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 216
            testRunner.And("I select Admin -> Change Email Address from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 217
            testRunner.And("I am navigated to the \'Change email address\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table31.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
            table31.AddRow(new string[]
            {
                "NewEmailAddress",
                "joe@test.net"
            });
#line 218
            testRunner.And("I enter the following change email address data:", ((string) (null)), table31, "And ");
#line 222
            testRunner.When("I submit the change email address form", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 223
            testRunner.Then("I am navigated to the \'Change Email Address Pending\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table32.AddRow(new string[]
            {
                "user5@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User"
            });
#line 224
            testRunner.And("I have the following users in the system:", ((string) (null)), table32, "And ");
#line 227
            testRunner.And("the user \'user5@test.net\' has the new email address token set and new email addre" +
                           "ss expiry is at least 14 minutes from now", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table33.AddRow(new string[]
            {
                "User Logged On"
            });
            table33.AddRow(new string[]
            {
                "Change email address request started to change from user5@test.net to joe@test.ne" +
                "t"
            });
#line 228
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table33, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change my password")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void ICanChangeMyPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change my password",
                new string[]
                {
                    "PAT"
                });
#line 168
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table25.AddRow(new string[]
            {
                "user3@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 169
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table25, "Given ");
#line 172
            testRunner.And("I have 0 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 173
            testRunner.And("I make a note of the password and salt for \'user3@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 174
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 175
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 176
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table26.AddRow(new string[]
            {
                "UserName",
                "user3@test.net"
            });
            table26.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
#line 177
            testRunner.And("I enter the following login data:", ((string) (null)), table26, "And ");
#line 181
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 182
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 183
            testRunner.And("I select Admin -> Change Password from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 184
            testRunner.And("I am navigated to the \'Change Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table27.AddRow(new string[]
            {
                "CurrentPassword",
                "x12a;pP02icdjshER"
            });
            table27.AddRow(new string[]
            {
                "NewPassword",
                "NewPassword45678"
            });
            table27.AddRow(new string[]
            {
                "ConfirmNewPassword",
                "NewPassword45678"
            });
#line 185
            testRunner.And("I enter the following change password data:", ((string) (null)), table27, "And ");
#line 190
            testRunner.When("I submit the change password form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 191
            testRunner.Then("I am navigated to the \'Change Password Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 192
            testRunner.And("The password for \'user3@test.net\' has changed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table28.AddRow(new string[]
            {
                "User Logged On"
            });
            table28.AddRow(new string[]
            {
                "Password changed"
            });
            table28.AddRow(new string[]
            {
                "User Logged Off"
            });
#line 193
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table28, "And ");
#line 198
            testRunner.And("I have 1 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change my security information")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void ICanChangeMySecurityInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "I can change my security information", new string[]
                {
                    "PAT"
                });
#line 252
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table37.AddRow(new string[]
            {
                "user3@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 253
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table37, "Given ");
#line 256
            testRunner.And("I make a note of the security information and salt for user \'user3@test.net\'",
                ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 257
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 258
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 259
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table38.AddRow(new string[]
            {
                "UserName",
                "user3@test.net"
            });
            table38.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
#line 260
            testRunner.And("I enter the following login data:", ((string) (null)), table38, "And ");
#line 264
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 265
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 266
            testRunner.And("I select Admin -> Change Security Information from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 267
            testRunner.And("I am navigated to the \'Change security Information\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table39.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
            table39.AddRow(new string[]
            {
                "SecurityQuestion",
                "What was your childhood nickname?"
            });
            table39.AddRow(new string[]
            {
                "SecurityAnswer",
                "Adelweiss"
            });
            table39.AddRow(new string[]
            {
                "SecurityAnswerConfirm",
                "Adelweiss"
            });
#line 268
            testRunner.And("I enter the following change security information data:", ((string) (null)), table39,
                "And ");
#line 274
            testRunner.When("I submit the change security information form", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 275
            testRunner.Then("I am navigated to the \'Change Security Information Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName",
                "SecurityQuestionLookupItemId"
            });
            table40.AddRow(new string[]
            {
                "user3@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User",
                "What was your childhood nickname?"
            });
#line 276
            testRunner.And("I have the following users in the system:", ((string) (null)), table40, "And ");
#line 279
            testRunner.And("The security information for \'user3@test.net\' has changed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table41.AddRow(new string[]
            {
                "User Logged On"
            });
            table41.AddRow(new string[]
            {
                "User Changed Security Information"
            });
#line 280
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table41, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can view my user activity log information")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void ICanViewMyUserActivityLogInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "I can view my user activity log information", new string[]
                {
                    "PAT"
                });
#line 287
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table42.AddRow(new string[]
            {
                "user3@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 288
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table42, "Given ");
#line 291
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 292
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 293
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table43.AddRow(new string[]
            {
                "UserName",
                "user3@test.net"
            });
            table43.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
#line 294
            testRunner.And("I enter the following login data:", ((string) (null)), table43, "And ");
#line 298
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 299
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 300
            testRunner.When("I select Admin -> Account Log from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 301
            testRunner.Then("I am navigated to the \'Account Log\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table44.AddRow(new string[]
            {
                "User Logged On"
            });
#line 302
            testRunner.And("I am shown the following user logs:", ((string) (null)), table44, "And ");
#line hidden
            TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table45.AddRow(new string[]
            {
                "User Logged On"
            });
#line 305
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table45, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "When I attempt password recovery using an invalid account I am notified of succes" +
            "s")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void WhenIAttemptPasswordRecoveryUsingAnInvalidAccountIAmNotifiedOfSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I attempt password recovery using an invalid account I am notified of succes" +
                "s", new string[]
                {
                    "PAT"
                });
#line 127
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 128
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 129
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 130
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 131
            testRunner.And("I click recover password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 132
            testRunner.And("I am navigated to the \'Recover\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table19.AddRow(new string[]
            {
                "UserName",
                "Bogus@bogus.com"
            });
#line 133
            testRunner.And("I enter the following recover data:", ((string) (null)), table19, "And ");
#line 136
            testRunner.When("I submit the recover form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 137
            testRunner.Then("I am navigated to the \'Recover Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
#line 138
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "When I attempt password recovery using a valid account I am notified of success")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void WhenIAttemptPasswordRecoveryUsingAValidAccountIAmNotifiedOfSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I attempt password recovery using a valid account I am notified of success", new string[]
                {
                    "PAT",
                    "Smoke"
                });
#line 103
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table15.AddRow(new string[]
            {
                "user@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 104
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table15, "Given ");
#line 107
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 108
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 109
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 110
            testRunner.And("I click recover password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 111
            testRunner.And("I am navigated to the \'Recover\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table16.AddRow(new string[]
            {
                "UserName",
                "user@test.net"
            });
#line 112
            testRunner.And("I enter the following recover data:", ((string) (null)), table16, "And ");
#line 115
            testRunner.When("I submit the recover form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 116
            testRunner.Then("I am navigated to the \'Recover Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table17.AddRow(new string[]
            {
                "user@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User"
            });
#line 117
            testRunner.And("I have the following users in the system:", ((string) (null)), table17, "And ");
#line 120
            testRunner.And("the user \'user@test.net\' has the password reset token set and password reset expi" +
                           "ry is at least 14 minutes from now", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table18.AddRow(new string[]
            {
                "Password reset link generated and sent"
            });
#line 121
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "When I click on a valid change email address link, I change my email address to a" +
            " new one")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void WhenIClickOnAValidChangeEmailAddressLinkIChangeMyEmailAddressToANewOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I click on a valid change email address link, I change my email address to a" +
                " new one", new string[]
                {
                    "PAT"
                });
#line 235
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table34.AddRow(new string[]
            {
                "user4@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "samuel@test.net",
                "B386B07A-FF0C-4B2B-9DAD-7D32CFD5A92F",
                "[One day from now]"
            });
#line 236
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table34, "Given ");
#line 239
            testRunner.When("I navigate to the change email address link with token \'B386B07A-FF0C-4B2B-9DAD-7" +
                            "D32CFD5A92F\'", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 240
            testRunner.Then("I am navigated to the \'Change Email Address Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table35.AddRow(new string[]
            {
                "samuel@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User"
            });
#line 241
            testRunner.And("I have the following users in the system:", ((string) (null)), table35, "And ");
#line 244
            testRunner.And("the user \'samuel@test.net\' has the new email address token and expiry cleared",
                ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table36.AddRow(new string[]
            {
                "Change email address request confirmed to change from user4@test.net to samuel@te" +
                "st.net"
            });
#line 245
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table36, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "When I click on a valid password reset link, I can enter my security information " +
            "and change my password")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void WhenIClickOnAValidPasswordResetLinkICanEnterMySecurityInformationAndChangeMyPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I click on a valid password reset link, I can enter my security information " +
                "and change my password", new string[]
                {
                    "PAT"
                });
#line 142
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table21.AddRow(new string[]
            {
                "user2@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "83ababb4-a0c1-4f2c-8593-32dd40b920d2",
                "[One day from now]",
                "",
                "",
                ""
            });
#line 143
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table21, "Given ");
#line 146
            testRunner.And("I have 0 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 147
            testRunner.And("I navigate to the password reset link with token \'83ababb4-a0c1-4f2c-8593-32dd40b" +
                           "920d2\'", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 148
            testRunner.And("I am navigated to the \'Recover Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table22.AddRow(new string[]
            {
                "SecurityAnswer",
                "Mr Miggins"
            });
            table22.AddRow(new string[]
            {
                "Password",
                "NewPassword45678"
            });
            table22.AddRow(new string[]
            {
                "Confirm Password",
                "NewPassword45678"
            });
#line 149
            testRunner.And("I enter the following recover password data:", ((string) (null)), table22, "And ");
#line 154
            testRunner.When("I submit the recover passord form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 155
            testRunner.Then("I am navigated to the \'Recover Password Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table23.AddRow(new string[]
            {
                "user2@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User"
            });
#line 156
            testRunner.And("I have the following users in the system:", ((string) (null)), table23, "And ");
#line 159
            testRunner.And("the password reset token and expiry for user \'user2@test.net\' are not set",
                ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table24.AddRow(new string[]
            {
                "User Logged On"
            });
            table24.AddRow(new string[]
            {
                "Password changed using token"
            });
#line 160
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table24, "And ");
#line 164
            testRunner.And("I have 1 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I enter correct login details I am taken to the landing page")]
        public virtual void WhenIEnterCorrectLoginDetailsIAmTakenToTheLandingPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("When I enter correct login details I am taken to the landing page",
                    ((string[]) (null)));
#line 12
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table1.AddRow(new string[]
            {
                "user@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 13
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table1, "Given ");
#line 16
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 17
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 18
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 19
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table2.AddRow(new string[]
            {
                "UserName",
                "user@test.net"
            });
            table2.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
#line 20
            testRunner.And("I enter the following login data:", ((string) (null)), table2, "And ");
#line 24
            testRunner.When("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 25
            testRunner.Then("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 26
            testRunner.And("the following last activity message is shown: \'the last activity logged against y" +
                           "our account was\'", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table3.AddRow(new string[]
            {
                "User Logged On"
            });
#line 27
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I enter incorrect login details then a warning is displayed")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void WhenIEnterIncorrectLoginDetailsThenAWarningIsDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I enter incorrect login details then a warning is displayed", new string[]
                {
                    "PAT"
                });
#line 32
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table4.AddRow(new string[]
            {
                "user@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 33
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table4, "Given ");
#line 36
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 37
            testRunner.And("I am taken to the homepage", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 38
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 39
            testRunner.And("I am navigated to the \'login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table5.AddRow(new string[]
            {
                "UserName",
                "user@test.net"
            });
            table5.AddRow(new string[]
            {
                "Password",
                "y12a;pP02icdjshET"
            });
#line 40
            testRunner.And("I enter the following login data:", ((string) (null)), table5, "And ");
#line 44
            testRunner.When("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field"
            });
            table6.AddRow(new string[]
            {
                "Invalid credentials or the account is locked"
            });
#line 45
            testRunner.Then("The following errors are displayed:", ((string) (null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table7.AddRow(new string[]
            {
                "Failed Logon attempt"
            });
#line 48
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute(
            "When I enter registration details which are currently being used I am advised of " +
            "registration success")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void WhenIEnterRegistrationDetailsWhichAreCurrentlyBeingUsedIAmAdvisedOfRegistrationSuccess()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I enter registration details which are currently being used I am advised of " +
                "registration success", new string[]
                {
                    "PAT"
                });
#line 77
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "PasswordResetToken",
                "PasswordResetExpiry",
                "NewEmailAddress",
                "NewEmailAddressToken",
                "NewEmailAddressRequestExpiryDate"
            });
            table11.AddRow(new string[]
            {
                "user@test.net",
                "Standard",
                "User",
                "x12a;pP02icdjshER",
                "What is the name of your first pet?",
                "Mr Miggins",
                "",
                "",
                "",
                "",
                ""
            });
#line 78
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table11, "Given ");
#line 81
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 82
            testRunner.And("I click register in the title bar", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line 83
            testRunner.And("I am navigated to the \'Register\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table12.AddRow(new string[]
            {
                "Username",
                "user@test.net"
            });
            table12.AddRow(new string[]
            {
                "FirstName",
                "Standard2"
            });
            table12.AddRow(new string[]
            {
                "LastName",
                "User2"
            });
            table12.AddRow(new string[]
            {
                "SecurityQuestion",
                "What is the name of your first pet?"
            });
            table12.AddRow(new string[]
            {
                "SecurityAnswer",
                "Mr Miggins"
            });
            table12.AddRow(new string[]
            {
                "Password",
                "x12a;pP02icdjshER"
            });
            table12.AddRow(new string[]
            {
                "ConfirmPassword",
                "x12a;pP02icdjshER"
            });
#line 84
            testRunner.And("I enter the following registration details:", ((string) (null)), table12, "And ");
#line 93
            testRunner.When("I submit my registration details", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 94
            testRunner.Then("I am navigated to the \'Register Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table13.AddRow(new string[]
            {
                "user@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Standard",
                "User"
            });
#line 95
            testRunner.And("I have the following users in the system:", ((string) (null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
#line 98
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table14, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I enter valid registration details I can register a new user")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void WhenIEnterValidRegistrationDetailsICanRegisterANewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "When I enter valid registration details I can register a new user", new string[]
                {
                    "PAT",
                    "Smoke"
                });
#line 53
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 54
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 55
            testRunner.And("I click register in the title bar", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "And ");
#line 56
            testRunner.And("I am navigated to the \'Register\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table8.AddRow(new string[]
            {
                "Username",
                "test@test.net"
            });
            table8.AddRow(new string[]
            {
                "FirstName",
                "Tester1"
            });
            table8.AddRow(new string[]
            {
                "LastName",
                "Tester2"
            });
            table8.AddRow(new string[]
            {
                "SecurityQuestion",
                "What is your mother\'s maiden name?"
            });
            table8.AddRow(new string[]
            {
                "SecurityAnswer",
                "Bloggs"
            });
            table8.AddRow(new string[]
            {
                "Password",
                "Test456789"
            });
            table8.AddRow(new string[]
            {
                "ConfirmPassword",
                "Test456789"
            });
#line 57
            testRunner.And("I enter the following registration details:", ((string) (null)), table8, "And ");
#line 66
            testRunner.When("I submit my registration details", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 67
            testRunner.Then("I am navigated to the \'Register Success\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table9.AddRow(new string[]
            {
                "Account Created"
            });
#line 68
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName"
            });
            table10.AddRow(new string[]
            {
                "test@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "False",
                "Tester1",
                "Tester2"
            });
#line 71
            testRunner.And("I have the following users in the system:", ((string) (null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore

#endregion