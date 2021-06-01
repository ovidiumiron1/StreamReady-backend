using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc;
using StreamReady_backend.Database;
using StreamReady_backend.Models;

namespace StreamReady_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        // public List<Song> Songs = new List<Song>()
        // {
        //     new Song()
        //     {
        //         SongId = "1",
        //         SongLength = 200,
        //         Photo = "url1",
        //         Size = 100
        //     },
        //     new Song()
        //     {
        //         SongId = "2",
        //         SongLength = 20220,
        //         Photo = "url2",
        //         Size = 2200
        //     },
        //     new Song()
        //     {
        //         SongId = "3",
        //         SongLength = 2400,
        //         Photo = "url3",
        //         Size = 200
        //     }
        // };

        //this uses Dependency Injection (or Inversion of Control - IoC)
        public SongController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public List<Song> Get()
        {
            return _dbContext.Songs.ToList();
        }

        // [HttpGet("{id}")]
        // public Song Get(string id)
        // {
        //     return Songs.Find(song => song.Id == id)
        // }

        [HttpPost]
        public List<Song> AddSong(Song song)
        {
            if (song is null)
            {
                return Get();
            }

            _dbContext.Songs.Add(song);
            _dbContext.SaveChanges();
            
            return Get();
        }
    }
}