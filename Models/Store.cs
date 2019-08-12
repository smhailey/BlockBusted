using System;
using System.Collections.Generic;

namespace blockbuster.Models
{
  class Store
  {
    public string Location { get; private set; }
    private List<Movie> AvailableMovies { get; set; }
    private List<Movie> RentedMovies { get; set; }

    public void PrintMovies()
    {
      for (int i = 0; i < AvailableMovies.Count; i++)
      {
        Movie m = AvailableMovies[i];
        System.Console.WriteLine($"{i + 1}. {m}");
        m.PlayMovie();
      }
    }

    public void AddMovie(Movie m)
    {
      AvailableMovies.Add(m);
    }


    public void Exchange(string choice)
    {
      Movie selected = ValidateChoice(choice, AvailableMovies);
      if (selected == null)
      {
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      AvailableMovies.Remove(selected);
      RentedMovies.Add(selected);

    }

    //NOTE METHOD OVERLOADING
    public void Exchange(string choice, bool credit)
    {
      Movie selected = ValidateChoice(choice, RentedMovies);
      if (selected == null)
      {
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      //NOTE TYPE CHECKING
      if (selected is VHS)
      {
        //NOTE Explicit Casting to another class
        VHS selectedVHS = (VHS)selected;
        if (!selectedVHS.isRewound)
        {
          System.Console.WriteLine("CHARGE THIS MAN ALL THE FINES!!!");
          selectedVHS.Rewind();
        }
      }
      AvailableMovies.Add(selected);
      RentedMovies.Remove(selected);

    }

    private Movie ValidateChoice(string choice, List<Movie> movies)
    {
      if (Int32.TryParse(choice, out int index))
      {
        index--;
        if (index > -1 && index < movies.Count)
        {
          return movies[index];
        }
      }
      return null;
    }

    public Store(string location)
    {
      Location = location;
      AvailableMovies = new List<Movie>();
      RentedMovies = new List<Movie>();
    }



    //NOTE Method Overloading
    public int add(int a, int b)
    {
      return a + b;
    }

    public float add(float a, float b)
    {
      return a + b;
    }

    public string add(string a, string b)
    {
      return a + ' ' + b;
    }







  }
}