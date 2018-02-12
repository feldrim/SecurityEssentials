﻿#region Designer generated code

using TechTalk.SpecFlow;

#pragma warning disable
namespace SecurityEssentials.Acceptance.Tests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User")]
    [NUnit.Framework.CategoryAttribute("CheckForErrors")]
    public partial class UserFeature
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
                new System.Globalization.CultureInfo("en-US"), "User",
                "\tIn order to users can effectively access the system\r\n\tAs a user, or admin\r\n\tI wa" +
                "nt to manage user permissions and data", ProgrammingLanguage.CSharp, new string[]
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
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[]
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
                "SkypeName"
            });
            table1.AddRow(new string[]
            {
                "user1@test.net",
                "Mr",
                "User",
                "One",
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
                "skype"
            });
            table1.AddRow(new string[]
            {
                "user2@test.net",
                "Mrs",
                "User",
                "Two",
                "hdfhjreyYURTR123",
                "What is the name of your first pet?",
                "Pettles",
                "false",
                "true",
                "true",
                "",
                "",
                "",
                "",
                "",
                ""
            });
            table1.AddRow(new string[]
            {
                "admin@test.net",
                "Mr",
                "Admin",
                "User",
                "654dfhjeritjJDFK",
                "What is the name of your first pet?",
                "Beatrix",
                "true",
                "true",
                "true",
                "",
                "",
                "",
                "",
                "",
                ""
            });
#line 11
            testRunner.And("the following users are setup in the database:", ((string) (null)), table1, "And ");
#line hidden
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As an admin I can delete a user")]
        public virtual void AsAnAdminICanDeleteAUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("As an admin I can delete a user", ((string[]) (null)));
#line 190
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 191
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 192
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 193
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table23.AddRow(new string[]
            {
                "UserName",
                "admin@test.net"
            });
            table23.AddRow(new string[]
            {
                "Password",
                "654dfhjeritjJDFK"
            });
#line 194
            testRunner.And("I enter the following login data:", ((string) (null)), table23, "And ");
#line 198
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 199
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 200
            testRunner.And("I select Admin -> Manage Users from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 201
            testRunner.And("I am navigated to the \'Manage Users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FullName",
                "TelNoMobile",
                "Enabled",
                "Approved"
            });
            table24.AddRow(new string[]
            {
                "admin@test.net",
                "Admin User",
                "",
                "True",
                "True"
            });
            table24.AddRow(new string[]
            {
                "user2@test.net",
                "User Two",
                "",
                "True",
                "True"
            });
            table24.AddRow(new string[]
            {
                "user1@test.net",
                "User One",
                "0789",
                "True",
                "True"
            });
#line 202
            testRunner.And("I am shown the following users:", ((string) (null)), table24, "And ");
#line 207
            testRunner.And("I click edit on the user with name \'user1@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 208
            testRunner.And("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 209
            testRunner.And("I click Delete User", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 210
            testRunner.And("I am navigated to the \'Delete User\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table25.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
#line 211
            testRunner.And("I am shown the following delete user details:", ((string) (null)), table25, "And ");
#line 214
            testRunner.When("I click confirm delete user", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 215
            testRunner.Then("I am navigated to the \'manage users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FullName",
                "TelNoMobile",
                "Enabled",
                "Approved"
            });
            table26.AddRow(new string[]
            {
                "admin@test.net",
                "Admin User",
                "",
                "True",
                "True"
            });
            table26.AddRow(new string[]
            {
                "user2@test.net",
                "User Two",
                "",
                "True",
                "True"
            });
#line 216
            testRunner.And("I am shown the following users:", ((string) (null)), table26, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As an admin I can manage my users")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        public virtual void AsAnAdminICanManageMyUsers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "As an admin I can manage my users", new string[]
                {
                    "PAT"
                });
#line 18
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 19
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 20
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 21
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
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
                "admin@test.net"
            });
            table2.AddRow(new string[]
            {
                "Password",
                "654dfhjeritjJDFK"
            });
#line 22
            testRunner.And("I enter the following login data:", ((string) (null)), table2, "And ");
#line 26
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 27
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 28
            testRunner.And("I select Admin -> Manage Users from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 29
            testRunner.And("I am navigated to the \'Manage Users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 30
            testRunner.When("I click edit on the user with name \'user1@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "When ");
#line 31
            testRunner.Then("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 32
            testRunner.And("I can edit the username", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table3.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
            table3.AddRow(new string[]
            {
                "Title",
                "Mr"
            });
            table3.AddRow(new string[]
            {
                "FirstName",
                "User"
            });
            table3.AddRow(new string[]
            {
                "LastName",
                "One"
            });
            table3.AddRow(new string[]
            {
                "HomeTelephoneNumber",
                "0456"
            });
            table3.AddRow(new string[]
            {
                "WorkTelephoneNumber",
                "0123"
            });
            table3.AddRow(new string[]
            {
                "MobileTelephoneNumber",
                "0789"
            });
            table3.AddRow(new string[]
            {
                "SkypeName",
                "skype"
            });
            table3.AddRow(new string[]
            {
                "Town",
                "town"
            });
            table3.AddRow(new string[]
            {
                "Postcode",
                "postcode"
            });
            table3.AddRow(new string[]
            {
                "Approved",
                "true"
            });
            table3.AddRow(new string[]
            {
                "EmailVerified",
                "true"
            });
            table3.AddRow(new string[]
            {
                "Enabled",
                "true"
            });
#line 33
            testRunner.And("The following user edit information is displayed:", ((string) (null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("As an admin I can reset a user\'s password")]
        public virtual void AsAnAdminICanResetAUsersPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("As an admin I can reset a user\'s password", ((string[]) (null)));
#line 157
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 158
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 159
            testRunner.And("I have 0 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 160
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 161
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
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
                "admin@test.net"
            });
            table19.AddRow(new string[]
            {
                "Password",
                "654dfhjeritjJDFK"
            });
#line 162
            testRunner.And("I enter the following login data:", ((string) (null)), table19, "And ");
#line 166
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 167
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 168
            testRunner.And("I select Admin -> Manage Users from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 169
            testRunner.And("I am navigated to the \'Manage Users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 170
            testRunner.And("I click edit on the user with name \'user1@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 171
            testRunner.And("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 172
            testRunner.And("I click Reset Password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 173
            testRunner.And("I am navigated to the \'Reset Password\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table20.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
#line 174
            testRunner.And("I am shown the following reset password details:", ((string) (null)), table20, "And ");
#line 177
            testRunner.When("I click confirm reset password", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 178
            testRunner.Then("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table21.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
#line 179
            testRunner.And("The following user edit information is displayed:", ((string) (null)), table21, "And ");
#line 182
            testRunner.And("I have 1 entry(ies) in the password history table", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 183
            testRunner.And("the user \'user1@test.net\' has the password expiry date set", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table22.AddRow(new string[]
            {
                "User Logged On"
            });
            table22.AddRow(new string[]
            {
                "User had password reset sent out via email by admin@test.net"
            });
#line 184
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table22, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can add the administrator privilege")]
        public virtual void ICanAddTheAdministratorPrivilege()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("I can add the administrator privilege", ((string[]) (null)));
#line 91
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line 92
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 93
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 94
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
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
                "admin@test.net"
            });
            table10.AddRow(new string[]
            {
                "Password",
                "654dfhjeritjJDFK"
            });
#line 95
            testRunner.And("I enter the following login data:", ((string) (null)), table10, "And ");
#line 99
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 100
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 101
            testRunner.And("I select Admin -> Manage Users from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 102
            testRunner.And("I am navigated to the \'Manage Users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 103
            testRunner.And("I click edit on the user with name \'user1@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 104
            testRunner.And("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 105
            testRunner.And("The text indicating the user is a system administrator is not displayed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 106
            testRunner.And("I click Make Administrator Privilege", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 107
            testRunner.And("I am navigated to the \'Make Admin\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table11.AddRow(new string[]
            {
                "UserName",
                "user1@test.net"
            });
#line 108
            testRunner.And("I am shown the following make admin details:", ((string) (null)), table11, "And ");
#line 111
            testRunner.When("I click confirm make admin", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 112
            testRunner.Then("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
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
#line 113
            testRunner.And("The following user edit information is displayed:", ((string) (null)), table12, "And ");
#line 116
            testRunner.And("The text indicating the user is a system administrator is displayed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table13.AddRow(new string[]
            {
                "User Logged On"
            });
            table13.AddRow(new string[]
            {
                "User was made a system admin by admin@test.net"
            });
#line 117
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table13, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change my account information")]
        [NUnit.Framework.CategoryAttribute("PAT")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void ICanChangeMyAccountInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo(
                "I can change my account information", new string[]
                {
                    "PAT",
                    "Smoke"
                });
#line 50
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
                "IsAdmin"
            });
            table4.AddRow(new string[]
            {
                "user3@test.net",
                "Patient",
                "User",
                "zasXX8576jFj123",
                "What is the name of your first pet?",
                "Beatrix",
                "false"
            });
#line 51
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
#line 54
            testRunner.And("the following user roles are setup in the system for user \'user3@test.net\'",
                ((string) (null)), table5, "And ");
#line 56
            testRunner.Given("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "Given ");
#line 57
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 58
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table6.AddRow(new string[]
            {
                "UserName",
                "user3@test.net"
            });
            table6.AddRow(new string[]
            {
                "Password",
                "zasXX8576jFj123"
            });
#line 59
            testRunner.And("I enter the following login data:", ((string) (null)), table6, "And ");
#line 63
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 64
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 65
            testRunner.And("I select Admin -> Manage Account from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 66
            testRunner.And("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table7.AddRow(new string[]
            {
                "Title",
                "Mrs"
            });
            table7.AddRow(new string[]
            {
                "FirstName",
                "Sarah"
            });
            table7.AddRow(new string[]
            {
                "LastName",
                "Page"
            });
            table7.AddRow(new string[]
            {
                "WorkTelephoneNumber",
                "0123456789"
            });
            table7.AddRow(new string[]
            {
                "HomeTelephoneNumber",
                "0987654321"
            });
            table7.AddRow(new string[]
            {
                "MobileTelephoneNumber",
                "0778412457"
            });
            table7.AddRow(new string[]
            {
                "Town",
                "Leeds"
            });
            table7.AddRow(new string[]
            {
                "PostCode",
                "LS10 1EF"
            });
            table7.AddRow(new string[]
            {
                "SkypeName",
                "SarahPage"
            });
#line 67
            testRunner.And("I enter the following change account information data:", ((string) (null)), table7, "And ");
#line 78
            testRunner.When("I submit the manage account form", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 79
            testRunner.Then("A confirmation message \'Your account information has been saved\' is shown",
                ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 80
            testRunner.And("I cannot edit the username", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table8.AddRow(new string[]
            {
                "User Logged On"
            });
#line 81
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "HashStrategy",
                "Enabled",
                "Approved",
                "EmailVerified",
                "FirstName",
                "LastName",
                "TelNoWork",
                "TelNoHome",
                "TelNoMobile",
                "Town",
                "PostCode",
                "SkypeName"
            });
            table9.AddRow(new string[]
            {
                "admin@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Admin",
                "User",
                "",
                "",
                "",
                "",
                "",
                ""
            });
            table9.AddRow(new string[]
            {
                "user1@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "User",
                "One",
                "0123",
                "0456",
                "0789",
                "town",
                "postcode",
                "skype"
            });
            table9.AddRow(new string[]
            {
                "user2@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "User",
                "Two",
                "",
                "",
                "",
                "",
                "",
                ""
            });
            table9.AddRow(new string[]
            {
                "user3@test.net",
                "Pbkdf28000Iterations",
                "True",
                "True",
                "True",
                "Sarah",
                "Page",
                "0123456789",
                "0987654321",
                "0778412457",
                "Leeds",
                "LS10 1EF",
                "SarahPage"
            });
#line 84
            testRunner.And("I have the following users in the system:", ((string) (null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can remove the administrator privilege")]
        public virtual void ICanRemoveTheAdministratorPrivilege()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo =
                new TechTalk.SpecFlow.ScenarioInfo("I can remove the administrator privilege", ((string[]) (null)));
#line 122
            this.ScenarioSetup(scenarioInfo);
#line 7
            this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[]
            {
                "UserName",
                "FirstName",
                "LastName",
                "Password",
                "SecurityQuestion",
                "SecurityAnswer",
                "IsAdmin",
                "Approved",
                "Enabled"
            });
            table14.AddRow(new string[]
            {
                "user3@test.net",
                "User",
                "Three",
                "zasXX8576jFj123",
                "What is the name of your first pet?",
                "Beatrix",
                "true",
                "true",
                "true"
            });
#line 123
            testRunner.Given("the following users are setup in the database:", ((string) (null)), table14, "Given ");
#line 126
            testRunner.And("I navigate to the website", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 127
            testRunner.And("I click the login link in the navigation bar", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 128
            testRunner.And("I am navigated to the \'Login\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table15.AddRow(new string[]
            {
                "UserName",
                "admin@test.net"
            });
            table15.AddRow(new string[]
            {
                "Password",
                "654dfhjeritjJDFK"
            });
#line 129
            testRunner.And("I enter the following login data:", ((string) (null)), table15, "And ");
#line 133
            testRunner.And("I click the login button", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 134
            testRunner.And("I am navigated to the \'Landing\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 135
            testRunner.And("I select Admin -> Manage Users from the menu", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 136
            testRunner.And("I am navigated to the \'Manage Users\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 137
            testRunner.And("I click edit on the user with name \'user3@test.net\'", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 138
            testRunner.And("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 139
            testRunner.And("The text indicating the user is a system administrator is displayed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 140
            testRunner.And("I click Remove Administrator Privilege", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line 141
            testRunner.And("I am navigated to the \'Remove Admin\' page", ((string) (null)),
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
                "user3@test.net"
            });
#line 142
            testRunner.And("I am shown the following remove admin details:", ((string) (null)), table16, "And ");
#line 145
            testRunner.When("I click confirm remove admin", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)),
                "When ");
#line 146
            testRunner.Then("I am navigated to the \'User Edit\' page", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "Then ");
#line 147
            testRunner.And("I can edit the username", ((string) (null)), ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Field",
                "Value"
            });
            table17.AddRow(new string[]
            {
                "UserName",
                "user3@test.net"
            });
#line 148
            testRunner.And("The following user edit information is displayed:", ((string) (null)), table17, "And ");
#line 151
            testRunner.And("The text indicating the user is a system administrator is not displayed", ((string) (null)),
                ((TechTalk.SpecFlow.Table) (null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[]
            {
                "Description"
            });
            table18.AddRow(new string[]
            {
                "User Logged On"
            });
            table18.AddRow(new string[]
            {
                "User had administrator privileges removed by admin@test.net"
            });
#line 152
            testRunner.And("I have the following user logs in the system:", ((string) (null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore

#endregion