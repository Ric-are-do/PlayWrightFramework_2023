
using System.Diagnostics;



namespace PlaywrightFrameworkTest
{
    public class FirstPlaywrightScript : Automation.Common.Automation
    {

        [Test]
        public async Task CreateTestName()
        {
            try
            {
                // Your script starts here 
                await Page.GotoAsync("https://playwright.dev/dotnet");
            }
            catch (Exception message)
            {
                Debug.WriteLine(message);
                throw;
            }
        }
    }
}

