string numberAsString;
string age;

System.Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

System.Console.WriteLine("What is your last name: " );
string lastName = Console.ReadLine();

System.Console.WriteLine("How old are you: ");
numberAsString = Console.ReadLine();
age = Convert.ToInt32(numberAsString);

char firstInitial = firstName[0];
char lastInitial = firstName[firstName.Length - 1];

System.Console.WriteLine($"Hello, {name}! Your initials are {firstInitial}.{lastInitial}., and you are {age} years old.");

