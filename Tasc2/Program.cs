var Rentangle1=new Rentangle();
Console.Write("width = ");
Rentangle1.Width=Convert.ToDouble(Console.ReadLine());
Console.Write("height = ");
Rentangle1.Height=Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Area = "+Rentangle1.GetArea());





class Rentangle
{
    public double Width;
    public double Height;
    public double GetArea()
    {
        return Width*Height;
    }


}