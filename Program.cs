using System;
using blockbuster.Models;

namespace blockbuster
{
  class Program
  {
    static void Main(string[] args)
    {
      Store bb = new Store("Overland Location");

      VHS topGun = new VHS("Top Gun", "PG", 110);
      DVD fernGulley = new DVD("Fern Gulley", "G", 76, false);
      Bluray titanic = new Bluray("Titanic", "PG-13", 194, true);



      //NOTE VHS's are implicitly casted to Movie
      bb.AddMovie(topGun);
      bb.AddMovie(fernGulley);
      bb.AddMovie(titanic);

      Console.Clear();
      Console.WriteLine(@"
______ _            _    _               _            
| ___ \ |          | |  | |             | |           
| |_/ / | ___   ___| | _| |__  _   _ ___| |_ ___ _ __ 
| ___ \ |/ _ \ / __| |/ / '_ \| | | / __| __/ _ \ '__|
| |_/ / | (_) | (__|   <| |_) | |_| \__ \ ||  __/ |   
\____/|_|\___/ \___|_|\_\_.__/ \__,_|___/\__\___|_|
Available Movies: 
            ");
      bb.PrintMovies();

      System.Console.WriteLine(fernGulley);

    }
  }
}