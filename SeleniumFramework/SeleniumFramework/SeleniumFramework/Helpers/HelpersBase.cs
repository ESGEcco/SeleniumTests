namespace SeleniumFramework.SeleniumFramework.Helpers
{
    public class HelpersBase
    {
        public JavascriptHelpers Javascript
        {
            get
            {
                return new JavascriptHelpers();
            }
        }

        public WaitFor WaitFor
        {
            get
            {
                return new WaitFor();
            }
        }
    }
}
