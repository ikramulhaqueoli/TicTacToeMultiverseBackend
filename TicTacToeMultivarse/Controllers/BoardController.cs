using Microsoft.AspNetCore.Mvc;
using Common.Models;
using DataAccess;

namespace TicTacToeMultivarse.Controllers;

[ApiController]
[Route("[controller]")]
public class BoardController : ControllerBase
{
    private readonly IBoardRepository _boardRepository;

    public BoardController(IBoardRepository boardRepository)
    {
        _boardRepository = boardRepository;
    }

    [HttpPost]
    public ActionResult Turn([FromBody] TurnDtoModel model)
    {
        _boardRepository.SetMove(model.BoardId, model);

        return Ok(200);
    }

    [HttpGet]
    public ActionResult<StateModel> State([FromRoute] string boardId)
    {
        var state = _boardRepository.GetState(boardId);

        return Ok(state);
    }
}

