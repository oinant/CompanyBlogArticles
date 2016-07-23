using System.Web.Http;

namespace WebApiMultiTenancy.UseCase1
{
    public static class ApiConfiguration
    {
        public static void ConfigureApi(HttpConfiguration configuration)
        {
            configuration.MapHttpAttributeRoutes();
        }
    }
}