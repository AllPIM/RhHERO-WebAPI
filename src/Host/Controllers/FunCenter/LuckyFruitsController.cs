using FSH.WebApi.Application.FunCenter.LuckyFruits;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class LuckyFruitsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.LuckyFruits)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<LuckyFruitDto>> SearchAsync(SearchLuckyFruitsRequest request)
    {
        return Mediator.Send(request);
    }
}