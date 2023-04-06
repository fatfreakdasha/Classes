using Classes;
Students[] students = new Students[5];
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("введите имя студента:");
    string name = Console.ReadLine();
    Console.WriteLine("введите фамилию студента:");
    string surname = Console.ReadLine();
    Console.WriteLine("введите базу классов студента:");
    int baseclasses = Convert.ToInt32(Console.ReadLine());
    students[i] = new Students(name, surname, baseclasses);
    Console.WriteLine("\n");
}
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}
