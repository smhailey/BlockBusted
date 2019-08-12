namespace blockbuster.Models
{
  class Bluray : DVD
  {
    public override void PlayMovie()
    {
      System.Console.WriteLine("Play movie at 4k");
    }

    public Bluray(string title, string rating, int runtime, bool multidisc) : base(title, rating, runtime, multidisc)
    {
    }
  }
}