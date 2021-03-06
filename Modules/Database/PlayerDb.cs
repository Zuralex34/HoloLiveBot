﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoloLiveBot.Modules.Database
{
    public class Player
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Server Server { get; set; }
        public ulong PlayerId { get; set; }
        public string PlayerName { get; set; }
        public Character Character { get; set; }
    }
}
