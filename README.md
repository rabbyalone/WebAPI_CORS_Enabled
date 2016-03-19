# WebAPI_CORS_Enabled
Configuring CORS for all Browser support: 


###Install this package
> Install-Package Thinktecture.IdentityModel

###Create this class in Global.asax page
```C#
   public class CorsConfig
    {
        public static void RegisterCors(HttpConfiguration httpConfig)
        {
            WebApiCorsConfiguration corsConfig = new WebApiCorsConfiguration();
            corsConfig.RegisterGlobal(httpConfig);
            corsConfig.ForAllResources().AllowAllOriginsAllMethodsAndAllRequestHeaders();
        }
    }
```
### Now register that class to Application Start Method
> CorsConfig.RegisterCors(GlobalConfiguration.Configuration);

###Add dependency for thinktecture
> Install-Package Elmah.MVC

>You’re done ! Now Your post/put/delete request for any browsers are ready to roar 

