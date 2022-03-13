using FSH.WebApi.Application.FunCenter.Players;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class PlayersController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Players)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<PlayerDto>> SearchAsync(SearchPlayersRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [MustHavePermission(FSHAction.View, FSHResource.Players)]
    [OpenApiOperation("Get Player details.", "")]
    public Task<PlayerDto> GetAsync(Guid id)
    {
        return Mediator.Send(new GetPlayerRequest(id));
    }
}