using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloodBankExam.Startup))]
namespace BloodBankExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
