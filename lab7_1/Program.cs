workers[] worker = new workers[3];
for (int i = 0; i < worker.Length; i++)
{
    Console.Write("Введите фамилию: ");
    worker[i].surname = Console.ReadLine()!;
    Console.Write("Введите имя: ");
    worker[i].name = Console.ReadLine()!;
    Console.Write("Введите отчество: ");
    worker[i].secondname = Console.ReadLine()!;
    Console.Write("Введите должность: ");
    worker[i].position = Console.ReadLine()!;
    Console.WriteLine("Введите зарплату: ");
    worker[i].paycheck = int.Parse(Console.ReadLine())!;
    Console.WriteLine("Введите дату рождения(гггг.мм.дд): ");
    worker[i].db = DateTime.Parse(Console.ReadLine())!;
}
double avgSalary = 0;
for (int i = 0; i < worker.Length; i++)
{
    avgSalary += worker[i].paycheck;
}
avgSalary /= worker.Length;

Console.WriteLine($"\nСредняя зарплата: {avgSalary:F2}");
Console.WriteLine("\nСотрудники с зарплатой выше средней и возрастом менее 30 лет:\n");

bool found = false;
for (int i = 0;i < worker.Length; i++)
{
    int age = DateTime.Now.Year - worker[i].db.Year;
    if (DateTime.Now.DayOfYear < worker[i].db.DayOfYear)
        age--;
    if (worker[i].paycheck > avgSalary && age < 30)
    {
        found = true;
        Console.WriteLine($"Фамилия: {worker[i].surname}");
        Console.WriteLine($"Имя: {worker[i].name}");
        Console.WriteLine($"Отчество: {worker[i].secondname}");
        Console.WriteLine($"Должность: {worker[i].position}");
        Console.WriteLine($"Зарплата: {worker[i].paycheck}");
        Console.WriteLine($"Дата рождения: {worker[i].db:dd.mm.yyyy}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine(new string('-', 40));
    }
}
if (!found)
{
    Console.WriteLine("Таких сотрудников нет.");
}
struct workers
{
    public string surname;
    public string name;
    public string secondname;
    public string position;
    public int paycheck;
    public DateTime db;
}
