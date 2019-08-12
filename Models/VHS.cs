namespace blockbuster.Models
{
  //NOTE Derived classes can Inherit from a base class by using the ':'
  class VHS : Movie
  {
    public bool isRewound { get; private set; }

    public override void PlayMovie()
    {
      base.PlayMovie();
      isRewound = false;
    }

    public void Rewind()
    {
      isRewound = true;
    }

    public VHS(string title, string rating, int runtime) : base(title, rating, runtime)
    {
      isRewound = true;
    }
  }
}