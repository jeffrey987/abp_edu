using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ABC.TeachOnline.Pages
{
    public class Index_Tests : TeachOnlineWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
