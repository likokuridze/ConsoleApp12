// See https://aka.ms/new-console-template for more information



string[] students = new string[3];

for (int i = 0; i < students.Length; i++)
{
    Console.Write("Enter the name of student: ");
    students[i] = Console.ReadLine();
}


Console.WriteLine("All students:");
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}
