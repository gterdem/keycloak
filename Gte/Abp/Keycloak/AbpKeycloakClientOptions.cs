using System;

namespace Gte.Abp.Keycloak;

public class AbpKeycloakClientOptions
{
    /// <summary>
    /// The URL of the keycloak server. The default is "http://localhost:8080/"
    /// </summary>
    public Uri Url { get; set; }
    
    /// <summary>
    /// The name of the realm that the keycloak client connects to. The default is "master".
    /// </summary>
    public string? RealmName { get; set; }
    
    /// <summary>
    /// The admin user name to login to the keycloak server.
    /// </summary>
    public string? AdminUserName { get; set; }
    
    /// <summary>
    /// The admin password to login to the keycloak server.
    /// </summary>
    public string? AdminUserPassword { get; set; }

    public AbpKeycloakClientOptions()
    {
        Url = new Uri("http://localhost:8080");
        RealmName = "master";
    }
}