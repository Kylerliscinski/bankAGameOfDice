namespace bankAGameOfDice.Controllers;

[ApiController]
[Route("api[controller]")]
public class PlayersController : ControllerBase
{
  private readonly PlayersService _playersService;
  private readonly Auth0Provider _auth0;

  public PlayersController(PlayersService playersService, Auth0Provider auth0)
  {
    _playersService = playersService;
    _auth0 = auth0;
  }
}