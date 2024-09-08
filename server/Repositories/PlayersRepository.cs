namespace bankAGameOfDice.Repositories;

public class PlayersRepository
{
  private readonly IDbConnection _db;

  public PlayersRepository(IDbConnection db)
  {
    _db = db;
  }
}