namespace FSH.WebApi.Application.FunCenter.Bots;

public class SearchBotsRequest : PaginationFilter, IRequest<PaginationResponse<BotDto>>
{
}

public class BotsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Bot, BotDto>
{
    public BotsBySearchRequestSpec(SearchBotsRequest request)
        : base(request) =>
        Query.OrderBy(c => c.PlayerId, !request.HasOrderBy());
}

public class SearchBotsRequestHandler : IRequestHandler<SearchBotsRequest, PaginationResponse<BotDto>>
{
    private readonly IReadRepository<Bot> _repository;

    public SearchBotsRequestHandler(IReadRepository<Bot> repository) => _repository = repository;

    public async Task<PaginationResponse<BotDto>> Handle(SearchBotsRequest request, CancellationToken cancellationToken)
    {
        var spec = new BotsBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}