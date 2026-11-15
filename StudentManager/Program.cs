
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
        case 1: Console.WriteLine($"You picked: {pickedNumber}.Add student"); break;
        case 2: Console.WriteLine($"You picked: {pickedNumber}.Show all students"); break;
        case 3: Console.WriteLine($"You picked: {pickedNumber}.Search student"); break;
        case 4: Console.WriteLine($"You picked: {pickedNumber}.Edit student"); break;
        case 5: Console.WriteLine($"You picked: {pickedNumber}.Remove student"); break;
        case 6: Console.WriteLine($"You picked: {pickedNumber}.Show best student"); break;
        case 7: Console.WriteLine($"You picked: {pickedNumber}.Show average grade"); break;
        case 8: Console.WriteLine($"You picked: {pickedNumber}.Exit"); return;
            default: Console.WriteLine("Invalid option!"); break;
    }
}