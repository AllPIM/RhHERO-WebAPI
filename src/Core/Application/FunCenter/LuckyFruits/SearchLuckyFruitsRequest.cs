namespace FSH.WebApi.Application.FunCenter.LuckyFruits;

public class SearchLuckyFruitsRequest : PaginationFilter, IRequest<PaginationResponse<LuckyFruitDto>>
{
}

public class LuckyFruitsBySearchRequestSpec : EntitiesByPaginationFilterSpec<LuckyFruit, LuckyFruitDto>
{
    public LuckyFruitsBySearchRequestSpec(SearchLuckyFruitsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Round, !request.HasOrderBy());
}

public class SearchLuckyFruitsRequestHandler : IRequestHandler<SearchLuckyFruitsRequest, PaginationResponse<LuckyFruitDto>>
{
    private readonly IReadRepository<LuckyFruit> _repository;

    public SearchLuckyFruitsRequestHandler(IReadRepository<LuckyFruit> repository) => _repository = repository;

    public async Task<PaginationResponse<LuckyFruitDto>> Handle(SearchLuckyFruitsRequest request, CancellationToken cancellationToken)
    {
        var spec = new LuckyFruitsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}