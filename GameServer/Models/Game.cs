﻿using System.ComponentModel.DataAnnotations;

namespace GameServer.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int valor { get; set; }
    }
}
