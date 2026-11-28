//class Rect
//{
//    private double width;
//    public double Weight
//    {
//        private get
//        {
//            return width;
//        }
//        set
//        {
//            if(value <= 0) Console.WriteLine("Ошибка!");
//            else width=value;
//            width = value;
//        }
//    }
//    private double height;
//    public double Height
//    {
//        private get
//        {
//            return height;
//        }
//        set
//        {
//            if (value <= 0) Console.WriteLine("Ошибка!");
//            else height = value;
//            height = value;
//        }
//    }
//    public Rect(double _width, double _height)
//    {

//    }
//}

//Базовый

//Console.WriteLine("Введите массу:");
//double m=double.Parse(Console.ReadLine()!);
//Console.WriteLine("Введите скорость:");
//double s = double.Parse(Console.ReadLine()!);
//Body body = new Body(m, s);
//body.Print();
//class Body
//{
//    private double weight;
//    public double Weight
//    {
//        private get { return weight; }
//        set { if (value>0) weight = value; }
//    }
//    private double speed;
//    public double Speed
//    {
//        private get { return speed; }
//        set { speed = value; }
//    }
//    public Body(double _w, double _s)
//    {
//        Weight = _w;
//        Speed = _s;
//    }
//    private double Energy()
//    {
//        return weight * speed*speed/2;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Тело массой {weight}, двигающий со скоростью {speed} имеет кинетическую энергию {Energy()} Дж");
//    }
//}

Console.WriteLine("Введите стоимость:");
double p = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество:");
double k = double.Parse(Console.ReadLine()!);
Cost cost = new Cost(p, k);
cost.Print();
class Cost
{
    private double price;
    public double Price
    {
        private get { return price; }
        set { if (value > 0) price = value; }
    }
    private double kolichestvo;
    public double Kolichestvo
    {
        private get { return kolichestvo; }
        set { if (value > 0) kolichestvo = value; }
    }
    public Cost(double _p, double _k)
    {
        Price = _p;
        Kolichestvo = _k;
    }
    private double ObCost()
    {
        return price * kolichestvo;
    }
    public void Print()
    {
        Console.WriteLine($"Цена товара {price} руб , количество {kolichestvo}, общая стоимость {ObCost()} руб");
    }
}