using FSH.WebApi.Application.FunCenter.LuckyBags;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class LuckyBagsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.LuckyBags)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<LuckyBagDto>> SearchAsync(SearchLuckyBagsRequest request)
    {
        return Mediator.Send(request);
    }
}