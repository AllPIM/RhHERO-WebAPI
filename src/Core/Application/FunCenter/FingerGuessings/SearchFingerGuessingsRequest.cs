namespace FSH.WebApi.Application.FunCenter.FingerGuessings;

public class SearchFingerGuessingsRequest : PaginationFilter, IRequest<PaginationResponse<FingerGuessingDto>>
{
}

public class FingerGuessingsBySearchRequestSpec : EntitiesByPaginationFilterSpec<FingerGuessing, FingerGuessingDto>
{
    public FingerGuessingsBySearchRequestSpec(SearchFingerGuessingsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Name, !request.HasOrderBy());
}

public class SearchFingerGuessingsRequestHandler : IRequestHandler<SearchFingerGuessingsRequest, PaginationResponse<FingerGuessingDto>>
{
    private readonly IReadRepository<FingerGuessing> _repository;

    public SearchFingerGuessingsRequestHandler(IReadRepository<FingerGuessing> repository) => _repository = repository;

    public async Task<PaginationResponse<FingerGuessingDto>> Handle(SearchFingerGuessingsRequest request, CancellationToken cancellationToken)
    {
        var spec = new FingerGuessingsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}