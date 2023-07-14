using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Gte.Abp.Keycloak;

public class AbpKeycloakModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<AbpKeycloakClientOptions>(options =>
            {
                options.Url = new Uri(configuration["Keycloak:url"]!);
                options.RealmName = configuration["Keycloak:realmName"];
                options.AdminUserName = configuration["Keycloak:adminUsername"];
                options.AdminUserPassword = configuration["Keycloak:adminPassword"];
            }
        );
    }
}