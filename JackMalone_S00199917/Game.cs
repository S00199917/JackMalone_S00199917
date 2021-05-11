using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackMalone_S00199917
{
    public class Game
    {
        //Properties
        [Key]
        public string Name { get; set; }
        public string Platform { get; set; }
        public int CriticScore { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }
        public string Description { get; set; }

        //Constructor
        public Game()
        {

        }

        public Game(string name, int criticScore, decimal price, string gameImage, string description)
        {
            Name = name;
            CriticScore = criticScore;
            Price = price;
            GameImage = gameImage;
            Description = description;
        }

        //Decrease price method
        public void DecreasePrice(decimal decrease)
        {
            Price -= decrease;
        }
    }

    public class GameData : DbContext
    {
        public GameData() : base("TheGameData") { }

        public DbSet<Game> Games { get; set; }
    }
}
