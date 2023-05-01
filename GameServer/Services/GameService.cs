using Grpc.Core;
using GameServer.Protos;
using GameServer.Data;
using Microsoft.EntityFrameworkCore;
using GameServer.Models;

namespace GameServer.Services
{
    public class GameService : Protos.GameService.GameServiceBase
    {
        private readonly DataContext _db;
        public GameService(DataContext context) => _db = context;

        public override Task<GameResponse> GetGame(GetGameRequest req, ServerCallContext context)
        {
            var res = _db.Games.Where(x => x.Id == req.Id).FirstOrDefault();

            if (res == null)
                return Task.FromResult(new GameResponse
                {
                    Nome = "",
                    Valor = 0
                });
            else if (res.nome == null)
                res.nome = "Nada";
            else if (res.valor == null)
                res.valor = 0;

            return Task.FromResult(new GameResponse
            {
                Nome = res.nome,
                Valor = res.valor
            });

        }

        public override async Task<GameResponse> NewGame(NewGameRequest req, ServerCallContext context)
        {
            await _db.Games.AddAsync(new Game
            {
                Id = req.Id,
                nome = req.Nome,
                valor = req.Valor
            });

            await _db.SaveChangesAsync();

            return await Task.FromResult(new GameResponse
            {
                Nome = req.Nome,
                Valor = req.Valor
            });
        }

        public override Task<GameResponse> DeleteGame(DeleteGameRequest req, ServerCallContext context)
        {

            var res = _db.Games.Where(x => x.Id == req.Id).FirstOrDefault();

            _db.Games.Remove(res);
            _db.SaveChangesAsync();

            return Task.FromResult(new GameResponse
            {
                Nome = res.nome,
                Valor = res.valor
            });

        }
    }
}
