namespace CodingTracker;

public class Configuration
{
    public string GetConfigurationItemByKey(string key)
    {
        return System.Configuration.ConfigurationManager.AppSettings.Get(key) ?? throw new KeyNotFoundException();
    }
}