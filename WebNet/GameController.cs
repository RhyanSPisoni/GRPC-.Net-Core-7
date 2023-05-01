//using Grpc.Net.Client;
//using Microsoft.AspNetCore.Mvc;
//using GameServer;
//using Grpc.Net.Client;
//using GameServer.Protos;

namespace WebNet.Controller
{
    // [ApiController]
    // [Route("Game")]
    // public class GameController : ControllerBase
    // {
    //     // [HttpGet]
    //     // [Route("Get")]
    //     // public async Task<GameResponse> GetGame(GetGameRequest req)
    //     // {
    //     //     var channel = GrpcChannel.ForAddress("https://localhost:7123");
    //     //     var client = new GameService.GameServiceClient(channel);
    //     //     var res = await client.GetGameAsync(req);

    //     //     return (new GameResponse
    //     //     {
    //     //         Id = req.Id,
    //     //         Nome = res.Nome,
    //     //         valor = res.Valor
    //     //     });
    // }

    // [HttpGet]
    // [Route("Post")]
    // public async Task<GameResponse> PostGame(GetGameRequest req)
    // {
    //     Console.WriteLine("DSADSADSA");

    // var channel = GrpcChannel.ForAddress("https://localhost:7123");
    // var client = new GameService.GameServiceClient(channel);
    // var res = await client.GetGameAsync(req);

    // return (new GameResponse
    // {
    //     Id = req.Id,
    //     Nome = res.Nome,
    //     valor = res.Valor
    // });
    // }

    // [HttpPost]
    // public string Teste(GetGameRequest req)
    // {
    //     return req.Id.ToString();
    // }

    // [HttpPost]
    // [Route("Put")]
    // public async Task<GameResponse> PutGame(GetGameRequest req)
    // {
    //     var channel = GrpcChannel.ForAddress("https://localhost:7123");
    //     var client = new GameService.GameServiceClient(channel);
    //     var res = await client.GetGameAsync(req);

    //     return (new GameResponse
    //     {
    //         Id = req.Id,
    //         Nome = res.Nome,
    //         valor = res.Valor
    //     });
    // }

    // [HttpPost]
    // [Route("Delete")]
    // public async Task<GameResponse> DeleteGame(GetGameRequest req)
    // {
    //     var channel = GrpcChannel.ForAddress("https://localhost:7123");
    //     var client = new GameService.GameServiceClient(channel);
    //     var res = await client.GetGameAsync(req);

    //     return (new GameResponse
    //     {
    //         Id = req.Id,
    //         Nome = res.Nome,
    //         valor = res.Valor
    //     });
    // }
    // }
}