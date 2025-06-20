using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.CertDbPages
{
    public class LoginPage
    {
        private AppSettingsReader appSettings = new AppSettingsReader();
        WaitFor waitFor = new WaitFor();
        DecryptHelper decrypt = new DecryptHelper();
        By errorUserNameLabel = By.XPath("//li[contains(text(), 'The Username')]");
        By errorPassWordLabel = By.XPath("//li[contains(text(), 'The Password')]");
        By errorInvalidUsernameOrPasswordLabel = By.XPath("//li[contains(text(), 'Invalid username')]");
        By userNameTextbox = By.Id("Username");
        By passWordTextbox = By.Id("Password");
        By rememberMyLoginCheckbox = By.Id("RememberLogin");
        By loginButton = By.Id("btnLogin");
        By cancelButton = By.Id("btnCancel");
        By forgotPasswordLink = By.LinkText("Forgot Password");

        public LabelBase ErrorUserNameLabel
        {
            get
            {
                IWebElement element = waitFor.Element(errorUserNameLabel);

                return new LabelBase(element);
            }
        }

        public LabelBase ErrorPassWordLabel
        {
            get
            {
                IWebElement element = waitFor.Element(errorPassWordLabel);

                return new LabelBase(element);
            }
        }

        public LabelBase ErrorInvalidUsernameOrPasswordLabel
        {
            get
            {
                IWebElement element = waitFor.Element(errorInvalidUsernameOrPasswordLabel);

                return new LabelBase(element);
            }
        }

        public TextboxBase UserNameTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(userNameTextbox);

                return new TextboxBase(element);
            }
        }

        public TextboxBase PasswordTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(passWordTextbox);

                return new TextboxBase(element);
            }
        }

        public CheckboxBase RemeberMyLoginCheckbox
        {
            get
            {
                IWebElement element = waitFor.Element(rememberMyLoginCheckbox);

                return new CheckboxBase(element);
            }
        }

        public ButtonBase LoginButton
        {
            get
            {
                IWebElement element = waitFor.Element(loginButton);

                return new ButtonBase(element);
            }
        }

        public ButtonBase CancelButton
        {
            get
            {
                IWebElement element = waitFor.Element(cancelButton);

                return new ButtonBase(element);
            }
        }

        public LinkBase ForgotPasswordLink
        {
            get
            {
                IWebElement element = waitFor.Element(forgotPasswordLink);

                return new LinkBase(element);
            }
        }

        public ProductPage Login()
        {
            FillOutLoginForm();

            LoginButton.Click();

            return new ProductPage();
        }

        public ProductPage RemeberMyLogin()
        {
            FillOutLoginForm();

            RemeberMyLoginCheckbox.Check();

            LoginButton.Click();

            return new ProductPage();
        }

        public LoginPage MissingPassword()
        {
            FillOutUserName();

            LoginButton.Click();

            return new LoginPage();
        }

        public LoginPage MissingUsername()
        {
            FillOutPassword();

            LoginButton.Click();

            return new LoginPage();
        }

        public LoginPage MissingUsernameAndPassword()
        {
            LoginButton.Click();

            return new LoginPage();
        }

        public LoginPage InvalidUsernameAndPassword()
        {
            UserNameTextbox.Text = "FakeUsername";
            PasswordTextbox.Text = "FakePassword";

            LoginButton.Click();

            return new LoginPage();
        }

        public LoginPage ClickCancelButton()
        {
            CancelButton.Click();

            return new LoginPage();
        }

        public ForgotPasswordPage NavigateToForgotPasswordPage()
        {
            ForgotPasswordLink.Click();

            return new ForgotPasswordPage();
        }

        public bool IsUsernameErrorLabelVisible()
        {
            return ErrorUserNameLabel.Visible;
        }

        public bool IsPasswordErrorLabelVisible()
        {
            return ErrorPassWordLabel.Visible;
        }

        public bool IsInvalidUsernameAndPasswordLabelVisible()
        {
            return ErrorInvalidUsernameOrPasswordLabel.Visible;
        }

        public bool LoginPageLoaded()
        {
            return UserNameTextbox.Visible;
        }

        public bool AreLoginPageControlsDisplayed()
        {
            if (UserNameTextbox.Visible && PasswordTextbox.Visible && RemeberMyLoginCheckbox.Visible && LoginButton.Visible && CancelButton.Visible)  
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsUsernameErrorVisible()
        {
            FillOutPassword();
        }

        private void FillOutUserName()
        {
            string userName = (string)appSettings.GetValue("Username", typeof(string));

            UserNameTextbox.Text = decrypt.Decrypt(userName);
        }

        private void FillOutPassword()
        {
            string password = (string)appSettings.GetValue("Password", typeof(string));

            PasswordTextbox.Text = decrypt.Decrypt(password);
        }

        private void FillOutLoginForm()
        {
            string userName = (string)appSettings.GetValue("Username", typeof(string));
            string password = (string)appSettings.GetValue("Password", typeof(string));

            UserNameTextbox.Text = decrypt.Decrypt(userName);
            PasswordTextbox.Text = decrypt.Decrypt(password);
        }
    }
}
