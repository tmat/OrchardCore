using System.Threading.Tasks;

namespace OrchardCore.Settings;

public static class SiteServiceExtensions
{
    /// <summary>
    /// Gets an instance of the specified settings if it exists.
    /// </summary>
    /// <typeparam name="T">The type of the settings to attempt to get.</typeparam>
    /// <param name="siteService">The site service.</param>
    /// <returns>An instance of the given type if one exists.</returns>
    public static async Task<T> GetSettingsAsync<T>(this ISiteService siteService) where T : new()
        => (await siteService.GetSiteSettingsAsync()).As<T>();
}
