using Microsoft.AspNet.Identity.EntityFramework;
using OAuthAspNetWebApiRest.Domain.Models;

namespace OAuthAspNetWebApiRest.Data
{
    public class AppUserStore: UserStore<User>
    {
        public AppUserStore(AppDbContext context):base(context)
        {

        }
    }
}
