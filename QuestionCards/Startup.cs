using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuestionCards.Startup))]
namespace QuestionCards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
