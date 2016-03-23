using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PNFenwick_PetStore.Startup))]
namespace PNFenwick_PetStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
