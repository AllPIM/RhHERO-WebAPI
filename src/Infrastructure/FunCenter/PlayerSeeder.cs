using System.Reflection;
using FSH.WebApi.Application.Common.Interfaces;
using FSH.WebApi.Domain.FunCenter;
using FSH.WebApi.Infrastructure.Persistence.Context;
using FSH.WebApi.Infrastructure.Persistence.Initialization;
using Microsoft.Extensions.Logging;

namespace FSH.WebApi.Infrastructure.FunCenter;

public class PlayerSeeder : ICustomSeeder
{
    private readonly ISerializerService _serializerService;
    private readonly ApplicationDbContext _db;
    private readonly ILogger<PlayerSeeder> _logger;

    public PlayerSeeder(ISerializerService serializerService, ILogger<PlayerSeeder> logger, ApplicationDbContext db)
    {
        _serializerService = serializerService;
        _logger = logger;
        _db = db;
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        string? path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        if (!_db.Games.Any())
        {
            _logger.LogInformation("Started to Seed Games.");

            string gameData = await File.ReadAllTextAsync(path + "/Catalog/games.json", cancellationToken);
            var games = _serializerService.Deserialize<List<Game>>(gameData);

            if (games != null)
            {
                foreach (var game in games)
                {
                    await _db.Games.AddAsync(game, cancellationToken);
                }
            }

            await _db.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Seeded Games.");
        }

        if (!_db.Players.Any())
        {
            _logger.LogInformation("Started to Seed Players.");

            string playerData = await File.ReadAllTextAsync(path + "/Catalog/players.json", cancellationToken);
            var players = _serializerService.Deserialize<List<Player>>(playerData);

            if (players != null)
            {
                foreach (var player in players)
                {
                    await _db.Players.AddAsync(player, cancellationToken);
                }
            }

            await _db.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Seeded Players.");
        }
    }
}