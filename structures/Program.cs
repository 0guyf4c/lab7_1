//Person tom = new Person();
//tom.name = "vasya";
//tom.age = 18;
//Console.WriteLine(tom.name);
//Console.WriteLine(tom.age);
//struct Person
//{
//    public string name;
//    public int age;
//}

//Базовый
//Comp[] comps = new Comp[1];
//for (int i = 0; i < comps.Length; i++)
//{
//    Console.Write("Введите название компьютера:");
//    comps[i].name = Console.ReadLine()!;
//    Console.Write("Введите частоту:");
//    comps[i].frequency = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите память:");
//    comps[i].memory = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите наличие DVD: Да/Нет?");
//    string dvd = Console.ReadLine()!;
//    if (dvd == "Да") comps[i].DVD = true;
//    else comps[i].DVD = false;
//    Console.Write("Введите цену:");
//    comps[i].price = decimal.Parse(Console.ReadLine()!);
//    Console.WriteLine();
//}
//for (int i = 0; i < comps.Length; i++)
//{
//    if (comps[i].DVD) comps[i].Print();
//}
//struct Comp
//{
//    public string name;
//    public int frequency;
//    public int memory;
//    public bool DVD;
//    public decimal price;
//    public void Print()
//    {
//        Console.WriteLine($"Название:{name}, частота:{frequency}, память {memory}, {((DVD) ? "DVD" : "")}, цена:{price}");
//    }

//}