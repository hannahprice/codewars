class Block
{
    private int _width;

    private int _length;

    private int _height;

    public Block(int[] measurements)
    {
        _width = measurements[0];
        _length = measurements[1];
        _height = measurements[2];
    }

    public int GetWidth() => _width;

    public int GetLength() => _length;

    public int GetHeight() => _height;

    public int GetVolume() => _width * _height * _length;

    public int GetSurfaceArea()
    {
        var frontFaceArea = _width * _height;
        var sideFaceArea = _length * _height;
        var topFaceArea = _width * _length;

        var frontAndBack = frontFaceArea * 2;
        var sides = sideFaceArea * 2;
        var topAndBottom = topFaceArea * 2;

        return frontAndBack + sides + topAndBottom;
    }
}
