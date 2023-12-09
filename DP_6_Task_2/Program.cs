
public class Image
{

    public string Name { get; set; }
    public int ColorCount  { get; set; }
    public double Price { get; set; }

    public ImageMemento SaveImage()
    {
        return new ImageMemento(Name, ColorCount, Price);
    }

    public void ShowImage()
    {
        Console.WriteLine($"Name {Name}");
        Console.WriteLine($"ColorCount {ColorCount}");
        Console.WriteLine($"Price {Price}\n");
    }

}


public class ImageMemento
{
    public ImageMemento(string name, int colorCount, double price)
    {
        Name = name;
        ColorCount = colorCount;
        Price = price;
    }


    public Image Ctrl_Z()
    {

        return new Image() { Name = Name, ColorCount = ColorCount, Price=Price };

    }

    private string Name { get; set; }
    private int ColorCount { get; set; }
    private double Price { get; set; }


}





public class Program
{

    static void Main(string[] args)
    {

        Image image = new Image() { Name= "Image 1", Price = 12.2, ColorCount=3 };

        image.ShowImage();

       
        ImageMemento imageMemento = image.SaveImage();

        image.Price = 20;
        image.ColorCount = 5;
        image.ShowImage();

        image = imageMemento.Ctrl_Z();
        image.ShowImage();

    }


}













