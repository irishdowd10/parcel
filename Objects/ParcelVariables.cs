namespace parcel.Objects
{
  public class ParcelVariables
  {
    private int _weight;
    private int _width;
    private int _height;
    private int _length;
    // private int _volume;

    public int GetWeight()
    {
      return _weight;
    }
    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetHeight()
    {
      return _height;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    // public int Volume()
    // {
    //   return legnth * width * height;
    // }
    //
  }
}
