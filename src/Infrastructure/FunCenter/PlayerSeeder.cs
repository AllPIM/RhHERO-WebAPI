using System.Reflection;
using FSH.WebApi.Application.Common.Interfaces;
using FSH.WebApi.Domain.Common;
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
        if (!_db.Players.Any())
        {
            _logger.LogInformation("Started to Seed Players.");

            var player01 = new Player
            {
                Name = "A",
                NickName = "AA",
                Os = Domain.Common.OsType.iOS,
                Type = UserType.Normal
            };

            var player02 = new Player
            {
                Name = "B",
                NickName = "BB",
                Os = Domain.Common.OsType.iOS,
                Type = UserType.Normal
            };

            var player03 = new Player
            {
                Name = "C",
                NickName = "CC",
                Os = Domain.Common.OsType.iOS,
                Type = UserType.Normal
            };

            var player04 = new Player
            {
                Name = "D",
                NickName = "DD",
                Os = Domain.Common.OsType.iOS,
                Type = UserType.Normal
            };

            _db.Players.Add(player01);
            _db.Players.Add(player02);
            _db.Players.Add(player03);
            _db.Players.Add(player04);

            await _db.SaveChangesAsync();
            _logger.LogInformation("Seeded Players.");

            var timeline01 = new Timeline
            {
                Name = "TT 1",
                PlayerId = player01.Id,
                Type = UserType.Normal
            };

            _db.Timelines.Add(timeline01);

            await _db.SaveChangesAsync();
            _logger.LogInformation("Seeded Timeline.");
        }
    }
}