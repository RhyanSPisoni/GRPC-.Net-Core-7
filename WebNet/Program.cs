using GameServer.Protos;
using Grpc.Net.Client;
using NWebsec.AspNetCore.Mvc;
using NWebsec.AspNetCore.Mvc.Csp;
using Newtonsoft.Json.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowed((host) => true)
                        .AllowAnyHeader());
            });

            builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            var app = builder.Build();

            app.UseCors("CorsPolicy");
            app.MapGet("/", () => "Hello World!");

            app.MapPost("/Get", async (GetGameRequest req) =>
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7123");
                var client = new GameService.GameServiceClient(channel);
                var res = await client.GetGameAsync(new GameServer.Protos.GetGameRequest
                {
                    Id = req.Id
                });

                return new GameResponse
                {
                    Id = req.Id,
                    Nome = res.Nome,
                    valor = res.Valor
                };
            });

            app.MapPost("/New", async (GameResponse req) =>
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7123");
                var client = new GameService.GameServiceClient(channel);
                var res = await client.NewGameAsync(new NewGameRequest
                {
                    Id = req.Id,
                    Nome = req.Nome,
                    Valor = req.valor
                });

                return new GameResponse
                {
                    Id = req.Id,
                    Nome = res.Nome,
                    valor = res.Valor
                };
            });

            app.MapPost("/Delete", async (GetGameRequest req) =>
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7123");
                var client = new GameService.GameServiceClient(channel);
                var res = await client.DeleteGameAsync(new DeleteGameRequest
                {
                    Id = req.Id
                });

                return new GameResponse
                {
                    Id = req.Id,
                    Nome = res.Nome,
                    valor = res.Valor
                };
            });

            app.MapControllers();
            app.Run();
        }
    }
}