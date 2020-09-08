using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerCenter3
{
    public class Config
    {

        public static IEnumerable<ApiResource> GetApiResources() => new List<ApiResource>() { new ApiResource("api","myapi") };


        public static IEnumerable<Client> GetClients()
        {

            return new List<Client>()
            {
                new Client()
                {
                    ClientId ="client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    //认证的密钥 通过加密
                    ClientSecrets =
                    {
                        new Secret("api".Sha256())
                    },
                    AllowedScopes = { "api"}
                }

            };
        }

    }
}
