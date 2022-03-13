using FSH.WebApi.Application.FunCenter.FingerGuessings;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class FingerGuessingsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.FingerGuessings)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<FingerGuessingDto>> SearchAsync(SearchFingerGuessingsRequest request)
    {
        return Mediator.Send(request);
    }
}