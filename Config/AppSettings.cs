using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonMessageApp.Config
{
    // Accesses settings from the appsettings.json file...
    // ...via objects that are injected into classes (UserController DI = IOptions<AppSettings> appSettings)
    public class AppSettings
    {
        // This values should be changed for each app to generate JWTs, use https://www.guidegenerator.com/
        public string Secret { get; set; }

        // Refresh token lifespan, inactive tokens are automatically deleted from the database
        public int RefreshTokenTTL { get; set; }

        // 
        public bool MirrorOnPost { get; set; }
    }
}
