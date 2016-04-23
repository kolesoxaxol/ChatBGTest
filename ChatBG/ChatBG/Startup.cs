using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatBG.Startup))]
namespace ChatBG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
              ConfigureAuth(app); 
        }
    }
}
