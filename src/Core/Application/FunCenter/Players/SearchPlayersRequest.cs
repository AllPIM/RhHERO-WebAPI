namespace FSH.WebApi.Application.FunCenter.Players;

public class SearchPlayersRequest : PaginationFilter, IRequest<PaginationResponse<PlayerDto>>
{
}

public class PlayersBySearchRequestSpec : EntitiesByPaginationFilterSpec<Player, PlayerDto>
{
    public PlayersBySearchRequestSpec(SearchPlayersRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Name, !request.HasOrderBy());
}

public class SearchPlayersRequestHandler : IRequestHandler<SearchPlayersRequest, PaginationResponse<PlayerDto>>
{
    private readonly IReadRepository<Player> _repository;

    public SearchPlayersRequestHandler(IReadRepository<Player> repository) => _repository = repository;

    public async Task<PaginationResponse<PlayerDto>> Handle(SearchPlayersRequest request, CancellationToken cancellationToken)
    {
        var spec = new PlayersBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}