using CollaborativeTextEditor.Serializer;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeTextEditor
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new FilteredCamelCasePropertyNamesContractResolver
                {
                    // 1) Register all types in specified assemblies: 
                    AssembliesToInclude =  
                                { 
                                    typeof(Startup).Assembly 
                                },

                    // 2) Register individual types: 
                    //TypesToInclude = 
                    //                { 
                    //                    typeof(Hubs.Message), 
                    //                } 
                }
            };
            var serializer = JsonSerializer.Create(serializerSettings);
            GlobalHost.DependencyResolver.Register(typeof(JsonSerializer), () => serializer);

            app.MapSignalR();
        }
    }
}
