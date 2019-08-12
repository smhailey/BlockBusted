namespace blockbuster.Models
{
  class DVD : Movie
  {
    public bool MultiDisc { get; set; }

    public override void PlayMovie()
    {
      System.Console.WriteLine("Play at 720p");
    }


    public DVD(string title, string rating, int runtime, bool multidisc) : base(title, rating, runtime)
    {
      MultiDisc = multidisc;
    }
  }
}