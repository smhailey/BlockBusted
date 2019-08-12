namespace blockbuster.Models
{
  //NOTE Abstract enforces that a class cannot be instantiated
  abstract class Movie
  {
    public string Title { get; private set; }
    public string Rating { get; set; }
    public int Runtime { get; set; }

    public virtual void PlayMovie()
    {
      System.Console.WriteLine("Play movie in 240");
    }

    public override string ToString()
    {
      return $"{Title} - {Rating} : {Runtime}";
    }

    public Movie(string title, string rating, int runtime)
    {
      Title = title;
      Rating = rating;
      Runtime = runtime;
    }
  }
}