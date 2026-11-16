using StudentManager;

static void ShowMenu()
{
    Console.WriteLine("======== STUDENT MANAGER ========");
    Console.WriteLine("1.Add student");
    Console.WriteLine("2.Show all students");
    Console.WriteLine("3.Search student");
    Console.WriteLine("4.Edit student");
    Console.WriteLine("5.Remove student");
    Console.WriteLine("6.Show best student");
    Console.WriteLine("7.Show average grade");
    Console.WriteLine("8.Exit");
    Console.WriteLine();
}

List<Student> students = new List<Student>();
int nextId = 1;

void AddStudents(List<Student> students)
{
    Console.Write("Enter student name: ");
    string? name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Invalid name!");
        return;
    }


    Console.Write("Enter student age: ");
    int age;
    bool type = int.TryParse(Console.ReadLine(), out age);
    if (!type)
    {
        Console.WriteLine("Invalid input!");
        return;
    }

    Console.Write("Enter student grade: ");
    double grade;
    bool checktype = double.TryParse(Console.ReadLine(), out grade);
    if (!checktype)
    {
        Console.WriteLine("Invalid input!");
        return;
    }

    Student student = new Student(nextId, name, age, grade);

    students.Add(student);
    nextId ++;

    Console.WriteLine("Student added successfully!");
    Console.WriteLine($"ID:{student.Id} | Name:{student.Name} | Age:{student.Age} | Grade:{student.Grade}");
    Console.WriteLine();
}

static void ShowAllStudents(List<Student> students)
{
    if(students.Count == 0)
    {
        Console.WriteLine("No students found!");
        return ;
    }
    foreach (Student student in students)
    {
        Console.WriteLine($"ID:{student.Id} | Name:{student.Name} | Age:{student.Age} | Grade:{student.Grade}");
    }
    Console.WriteLine();
}

static void SearchStudent(List<Student> students)
{
    if(students.Count == 0)
    {
        Console.WriteLine("No students found!");
        return;
    }

    Console.Write("Enter student ID: ");
    int idOfStudent;
    bool typeOfInput = int.TryParse(Console.ReadLine(), out idOfStudent);
    if (!typeOfInput)
    {
        Console.WriteLine("Invalid input");
        return;
    }

    var foundStudent = students.FirstOrDefault(student => student.Id == idOfStudent);
    if (foundStudent == null)
    {
        Console.WriteLine("Student not fund!");
        return;
    }
    Console.WriteLine("Student found!");
    Console.WriteLine($"ID:{foundStudent.Id} | Name:{foundStudent.Name}| Age:{foundStudent.Age} | Grade:{foundStudent.Grade}");
    Console.WriteLine();
}

while (true)
{
    ShowMenu();

    Console.Write("Choose an option: ");
    int pickedNumber;
    bool type = int.TryParse(Console.ReadLine(), out pickedNumber);
    if (!type)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    switch (pickedNumber)
    {
        case 1: 
            Console.WriteLine($"You picked: {pickedNumber}.Add student");
            AddStudents(students);
            break;
        case 2: 
            Console.WriteLine($"You picked: {pickedNumber}.Show all students");
            ShowAllStudents(students);
            break;
        case 3: 
            Console.WriteLine($"You picked: {pickedNumber}.Search student"); 
            SearchStudent(students);
            break;
        case 4: Console.WriteLine($"You picked: {pickedNumber}.Edit student"); break;
        case 5: Console.WriteLine($"You picked: {pickedNumber}.Remove student"); break;
        case 6: Console.WriteLine($"You picked: {pickedNumber}.Show best student"); break;
        case 7: Console.WriteLine($"You picked: {pickedNumber}.Show average grade"); break;
        case 8: Console.WriteLine($"You picked: {pickedNumber}.Exit"); return;
            default: Console.WriteLine("Invalid option!"); break;
    }
}