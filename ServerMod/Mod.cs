using Eco.Core.Plugins.Interfaces;
using Eco.Plugins.Networking;
using Eco.Core.Serialization;
using System.IO;
using Eco.Shared.Serialization;
using Eco.Webserver.Controllers;
using Newtonsoft.Json;
using System;
using Eco.Core.Utils;
using Eco.Shared.Networking;

namespace ServerPlugin
{
    public class GetEcoServerInfo : IModKitPlugin, IServerPlugin
    {
        public string GetStatus()
        {
            var settings = new JsonSerializerSettings { CheckAdditionalContent = true, Formatting = Formatting.Indented };
            var net = NetworkManager.GetServerInfo();
            var jsonWrite = JsonConvert.SerializeObject(net,settings);
            File.WriteAllText("Mods/ServerMod/serverinfo.json", jsonWrite);
            return "GetStatus()";
        }
    }
}