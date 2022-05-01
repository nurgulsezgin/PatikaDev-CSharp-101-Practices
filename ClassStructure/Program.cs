Rectangle rectangle=new Rectangle();
rectangle.LongEdge=4;
rectangle.ShortEdge=3;

Console.WriteLine("Alan: {0}",rectangle.calculateField());

Rectangle_Struct rectangle_Struct;
rectangle_Struct.LongEdge=4;
rectangle_Struct.ShortEdge=3;

Console.WriteLine("Alan: {0}",rectangle_Struct.calculateField());

class Rectangle
{
    public int ShortEdge;
    public int LongEdge;
    public long calculateField()
    {
        return this.ShortEdge*this.LongEdge;
    }
}
struct Rectangle_Struct
{
    public int ShortEdge;
    public int LongEdge;
    public long calculateField()
    {
        return this.ShortEdge*this.LongEdge;
    }
}