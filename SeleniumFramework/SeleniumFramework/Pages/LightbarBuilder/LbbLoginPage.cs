using OpenQA.Selenium;
using SeleniumFramework.SeleniumFramework.Controls;
using SeleniumFramework.SeleniumFramework.Helpers;
using System.Configuration;

namespace SeleniumFramework.Pages.LightbarBuilder
{
    public class LbbLoginPage
    {
        private AppSettingsReader appSettings = new AppSettingsReader();
        WaitFor waitFor = new WaitFor();
        DecryptHelper decrypt = new DecryptHelper();
        By loginLabel = By.XPath("//label[contains(text(), 'Login')]");
        By usernameLabel = By.XPath("//label[contains(text(), 'Username')]");
        By localLoginLabel = By.XPath("//label[contains(text(), 'Local Login')]");
        By usernameTextbox = By.Id("Username");          
        By passwordLabel = By.XPath("//label[contains(text(), 'Password')]");
        By passwordTextbox = By.Id("Password");
        By loginButton = By.Id("btnLogin");
        By cancelButton = By.Id("btnCancel");
        By rememberMyLoginLabel = By.XPath("//label[contains(text(), 'Remember My Login')]");
        By rememberMyLoginCheckbox = By.Id("RememberLogin");
        By forgotPasswordLink = By.LinkText("Forgot Password");
        By errorInvalidUsernameLabel = By.XPath("//li[contains(text(), 'The Username field is required.')]");

        public LabelBase LoginLabel
        {
            get
            {
                IWebElement element = waitFor.Element(loginLabel);

                return new LabelBase(element);
            }
        }

        public LabelBase UsernameLabel
        {
            get
            {
                IWebElement element = waitFor.Element(usernameLabel);

                return new LabelBase(element);
            }
        }

        public LabelBase LocalLoginLabel
        {
            get
            {
                IWebElement element = waitFor.Element(localLoginLabel);

                return new LabelBase(element);
            }
        }

        public TextboxBase UsernameTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(usernameTextbox);

                return new TextboxBase(element);
            }
        }

        public LabelBase PasswordLabel
        {
            get
            {
                IWebElement element = waitFor.Element(passwordLabel);

                return new LabelBase(element);
            }
        }

        public TextboxBase PasswordTextbox
        {
            get
            {
                IWebElement element = waitFor.Element(passwordTextbox);

                return new TextboxBase(element);
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

        public LabelBase RememberMyLoginLabel
        {
            get
            {
                IWebElement element = waitFor.Element(rememberMyLoginLabel);

                return new LabelBase(element);
            }
        }

        public CheckboxBase RememberMyLoginCheckbox
        {
            get
            {
                IWebElement element = waitFor.Element(rememberMyLoginCheckbox);

                return new CheckboxBase(element);
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

        public LabelBase ErrorInvalidUsernameLabel { 
            get
            {
                IWebElement element = waitFor.Element(errorInvalidUsernameLabel);\

                return new LabelBase(element);
            }}

        public LightbarBuilderPage CorrectLogin()
        {
            FillOutLoginForm();

            LoginButton.Click();

            return new LightbarBuilderPage();
        }

        public bool AreControlsVisible()
        {
            bool controlsVisble = LoginLabel.Visible && UsernameLabel.Visible && LocalLoginLabel.Visible && UsernameTextbox.Visible
                && PasswordLabel.Visible && PasswordTextbox.Visible && LoginLabel.Visible && CancelButton.Visible;

            return controlsVisble;
        }

        public bool IsUsernameMissing()
        {
            return ErrorInvalidUsernameLabel.Visible;
        }

        private void FillOutUserName()
        {
            string userName = (string)appSettings.GetValue("LbbUsername", typeof(string));

            UsernameTextbox.Text = decrypt.Decrypt(userName);
        }

        private void FillOutPassword()
        {
            string password = (string)appSettings.GetValue("LbbPassword", typeof(string));

            PasswordTextbox.Text = decrypt.Decrypt(password);
        }

        private void FillOutLoginForm()
        {
            string username = (string)appSettings.GetValue("LbbUsername", typeof(string));
            string password = (string)appSettings.GetValue("LbbPassword", typeof(string));

            UsernameTextbox.Text = decrypt.Decrypt(username);
            PasswordTextbox.Text = decrypt.Decrypt(password);
        }
    }
}
