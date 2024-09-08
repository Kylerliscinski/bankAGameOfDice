namespace bankAGameOfDice.Services;

public class PlayersService
{
  private readonly PlayersRepository _repo;

  public PlayersService(PlayersRepository repo)
  {
    _repo = repo;
  }
}