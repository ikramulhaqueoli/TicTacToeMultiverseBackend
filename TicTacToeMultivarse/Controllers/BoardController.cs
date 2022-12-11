using Microsoft.AspNetCore.Mvc;
using Common.Models;
using DataAccess;
using System.Net;

namespace TicTacToeMultivarse.Controllers;

[ApiController]
[Route("api/board")]
public class BoardController : ControllerBase
{
    private readonly IBoardRepository _boardRepository;

    public BoardController(IBoardRepository boardRepository)
    {
        _boardRepository = boardRepository;
    }

    [HttpPost("turn")]
    public HttpStatusCode Turn([FromBody] TurnDtoModel model)
    {
        _boardRepository.SetMove(model.BoardId, model);

        return HttpStatusCode.Created;
    }

    [HttpGet("state/{boardId}")]
    public ActionResult<StateModel> State([FromRoute] string boardId)
    {
        var state = _boardRepository.GetState(boardId);

        return Ok(state);
    }

    [HttpDelete("reset/{boardId}")]
    public HttpStatusCode Reset([FromRoute] string boardId)
    {
        return _boardRepository.Reset(boardId)
            ? HttpStatusCode.Accepted
            : HttpStatusCode.BadRequest;
    }
}

