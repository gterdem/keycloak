using System;

namespace Gte.Abp.Keycloak;

public class AbpKeycloakClientOptions
{
    /// <summary>
    /// The URL of the keycloak server. The default is "http://localhost:8080/"
    /// </summary>
    public Uri Url { get; set; }
    /// <summary>
    /// The name of the realm that the keycloak client connects to.
    /// </summary>
    public string? RealmName { get; set; }

    public AbpKeycloakClientOptions()
    {
        Url = new Uri("http://localhost:8080");
        RealmName = "master";
    }
}