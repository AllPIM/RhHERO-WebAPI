using FSH.WebApi.Application.FunCenter.Bots;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class BotsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.Bots)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<BotDto>> SearchAsync(SearchBotsRequest request)
    {
        return Mediator.Send(request);
    }
}