namespace GalinaNay.Data
{
	using Microsoft.Extensions.Configuration;

	public class Configuration
    {
	    private static readonly IConfigurationRoot ConfigurationRoot;

	    static Configuration()
	    {
			var builder = new ConfigurationBuilder()
				 .AddJsonFile("appsettings.json");
			ConfigurationRoot = builder.Build();
		}

	    public static string GetConfigValue(string configKey)
	    {
		    return ConfigurationRoot[configKey];
	    }
    }
}
