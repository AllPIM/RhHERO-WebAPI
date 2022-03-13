namespace FSH.WebApi.Application.FunCenter.Players;

public class GetPlayerRequest : IRequest<PlayerDto>
{
    public Guid Id { get; set; }

    public GetPlayerRequest(Guid id) => Id = id;
}

public class PlayerByIdSpec : Specification<Player, PlayerDto>, ISingleResultSpecification
{
    public PlayerByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetPlayerRequestHandler : IRequestHandler<GetPlayerRequest, PlayerDto>
{
    private readonly IRepository<Player> _repository;
    private readonly IStringLocalizer _t;

    public GetPlayerRequestHandler(IRepository<Player> repository, IStringLocalizer<GetPlayerRequestHandler> localizer) => (_repository, _t) = (repository, localizer);

    public async Task<PlayerDto> Handle(GetPlayerRequest request, CancellationToken cancellationToken) =>
        await _repository.GetBySpecAsync(
            (ISpecification<Player, PlayerDto>)new PlayerByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["Player {0} Not Found.", request.Id]);
}