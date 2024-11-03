﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tournament.Model.Entity;

namespace TournamentAPI.Controllers
{
    [Route("api/LeaderBoard")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {

        [HttpGet]
        public LeaderBoard GetLeaderBoard()
        {
            LeaderBoard board = new LeaderBoard {
                Id = 1,
                Player = "Maliha",
                Score = 1,
                Comment = "Playing"
            };

            return board;
        }



    }
}
