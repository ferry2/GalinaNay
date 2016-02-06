namespace GalinaNay.Web
{
	using Microsoft.AspNet.Builder;
	using Microsoft.AspNet.CookiePolicy;
	using Microsoft.AspNet.Hosting;

	public partial class Startup
    {
        /// <summary>
        /// Configure default cookie settings for the application which are more secure by default.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <param name="environment">The environment the application is running under. This can be Development, 
        /// Staging or Production by default.</param>
        private static void ConfigureCookies(
            IApplicationBuilder application,
            IHostingEnvironment environment)
        {
	        // In the Development environment, different ports are being used for HTTP and HTTPS. The 
            // RequireHttpsAttribute expects to use the default ports 80 for HTTP and port 443 for HTTPS and simply
            // adds an 's' onto 'http'. Therefore, we don't require secure cookies in the development environment.
	        var securePolicy = environment.IsDevelopment() ? SecurePolicy.SameAsRequest : SecurePolicy.Always;

	        application.UseCookiePolicy(
                new CookiePolicyOptions()
                {
                    // Ensure that external script cannot access the cookie.
                    HttpOnly = HttpOnlyPolicy.Always,
                    Secure = securePolicy
                });
        }
    }
}
