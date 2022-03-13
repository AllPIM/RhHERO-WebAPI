using FSH.WebApi.Application.FunCenter.MotorRacings;

namespace FSH.WebApi.Host.Controllers.FunCenter;

public class MotorRacingsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.MotorRacings)]
    [OpenApiOperation("Search Name using available filters.", "")]
    public Task<PaginationResponse<MotorRacingDto>> SearchAsync(SearchMotorRacingsRequest request)
    {
        return Mediator.Send(request);
    }
}