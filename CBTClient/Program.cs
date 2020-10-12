using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CBTClient.MessageHandlers;
using CBTClient.Services;

namespace CBTClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

      

            builder.Services.AddTransient<CBTApiAuthorizationMessageHandler>();


            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("OidcConfiguration", options.ProviderOptions);
            });

            
            builder.Services.AddHttpClient<IAssessmentService, AssessmentService>(
              client => client.BaseAddress = new Uri(builder.Configuration.GetSection("CBTAPI").Value))
              .AddHttpMessageHandler<CBTApiAuthorizationMessageHandler>();

            builder.Services.AddHttpClient<IQuestionService, QuestionService>(
            client => client.BaseAddress = new Uri(builder.Configuration.GetSection("CBTAPI").Value))
            .AddHttpMessageHandler<CBTApiAuthorizationMessageHandler>();


            builder.Services.AddHttpClient<IDataService, DataService>(
            client => client.BaseAddress = new Uri(builder.Configuration.GetSection("CBTAPI").Value))
            .AddHttpMessageHandler<CBTApiAuthorizationMessageHandler>();



            await builder.Build().RunAsync();

        }
    }
}
