namespace FSH.WebApi.Application.FunCenter.LuckyBags;

public class SearchLuckyBagsRequest : PaginationFilter, IRequest<PaginationResponse<LuckyBagDto>>
{
}

public class LuckyBagsBySearchRequestSpec : EntitiesByPaginationFilterSpec<LuckyBag, LuckyBagDto>
{
    public LuckyBagsBySearchRequestSpec(SearchLuckyBagsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Name, !request.HasOrderBy());
}

public class SearchLuckyBagsRequestHandler : IRequestHandler<SearchLuckyBagsRequest, PaginationResponse<LuckyBagDto>>
{
    private readonly IReadRepository<LuckyBag> _repository;

    public SearchLuckyBagsRequestHandler(IReadRepository<LuckyBag> repository) => _repository = repository;

    public async Task<PaginationResponse<LuckyBagDto>> Handle(SearchLuckyBagsRequest request, CancellationToken cancellationToken)
    {
        var spec = new LuckyBagsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}