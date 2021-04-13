using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StreamReady_backend.Models;

namespace StreamReady_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        public List<Song> Songs = new List<Song>()
        {
            new Song()
            {
                SongId = "1",
                SongLength = 200,
                Photo = "url1",
                Size = 100
            },
            new Song()
            {
                SongId = "2",
                SongLength = 20220,
                Photo = "url2",
                Size = 2200
            },
            new Song()
            {
                SongId = "3",
                SongLength = 2400,
                Photo = "url3",
                Size = 200
            }
        };
        [HttpGet]
        public List<Song> Get()
        {
            return Songs;
        }
    }
}