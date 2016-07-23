using System;
using System.Web.Http;

namespace WebApiMultiTenancy.UseCase1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(ApiConfiguration.ConfigureApi);
        }
    }
}