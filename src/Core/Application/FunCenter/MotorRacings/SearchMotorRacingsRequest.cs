namespace FSH.WebApi.Application.FunCenter.MotorRacings;

public class SearchMotorRacingsRequest : PaginationFilter, IRequest<PaginationResponse<MotorRacingDto>>
{
}

public class MotorRacingsBySearchRequestSpec : EntitiesByPaginationFilterSpec<MotorRacing, MotorRacingDto>
{
    public MotorRacingsBySearchRequestSpec(SearchMotorRacingsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Round, !request.HasOrderBy());
}

public class SearchMotorRacingsRequestHandler : IRequestHandler<SearchMotorRacingsRequest, PaginationResponse<MotorRacingDto>>
{
    private readonly IReadRepository<MotorRacing> _repository;

    public SearchMotorRacingsRequestHandler(IReadRepository<MotorRacing> repository) => _repository = repository;

    public async Task<PaginationResponse<MotorRacingDto>> Handle(SearchMotorRacingsRequest request, CancellationToken cancellationToken)
    {
        var spec = new MotorRacingsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}