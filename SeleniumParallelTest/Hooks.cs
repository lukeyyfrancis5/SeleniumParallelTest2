using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    class Hooks : Base
    { 
        public Hooks()
        {
            Driver = new FirefoxDriver();
        }
    }
}
