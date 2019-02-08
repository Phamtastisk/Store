using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
   
    class Store
    {


        int maxGames = 4;

        List<Game> showcase = new List<Game>();

        public Store()
        {
            showcase.Add(new Game("Daddy simulator", 15f, "How to dad", "Real life"));
            showcase.Add(new Game("Counter-strike Global Offensive", 20f, "Best shooting game never", "Cool stuff"));
            showcase.Add(new Game("Fortnite", 15f, "How to be meet them girls", "Not Bad"));
        }

        public void AddGame(Game game)
        {
            if (showcase.Count < maxGames)
                showcase.Add(game);

        }

        public void removeGame(Game game)
        {
            if (showcase.Contains(game))
            showcase.Remove(game);
        }

        public void sellGame(Game game, User user)
        {
            if (user.wallet >= game.price)
            {
                user.wallet = user.wallet - game.price;
                user.library.Add(game);
                removeGame(game);
            }
            else
            {
                Console.WriteLine("You poor Motherfucker!");
            }   
        }
    }

    class User
    {
        public float wallet;
        public List<Game> library = new List<Game>();

        public User(float wallatFunds)
        {
            wallet = wallatFunds;
        }
    }

    class Game
    {
        public string genre;
        public string name;
        public float price;
        public string description;

        public Game(string name,float price, string genre,  string description)
        {
            this.genre = genre;
            this.name = name;
            this.price = price;
            this.description = description;
        }
        
    }

    class DLC
    {

    }
}
