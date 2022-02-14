string numberAsString;
int maleCats;
int femaleCats;
int femaleCatPercentage;
int maleCatPercentage;
int totalCats;

System.Console.WriteLine("How many male cats are in the shelter?");
numberAsString = Console.ReadLine();
System.Console.WriteLine("How many female cats are in the shelter?");
numberAsString = Console.ReadLine();

maleCats = Convert.ToInt32(numberAsString);
femaleCats = Convert.ToInt32(numberAsString);
femaleCatPercentage = Convert.ToInt32(numberAsString);
maleCatPercentage = Convert.ToInt32(numberAsString);
totalCats = Convert.ToInt32(numberAsString);

double totalCats = (maleCats + femaleCats);
double maleCatPercentage = (maleCats / totalCats) * 100;
double femaleCatPercentage = (femaleCats / totalCats) * 100;

System.Console.WriteLine("Total cats: " + totalCats);
System.Console.WriteLine("Male cat percentage: " + maleCatPercentage + "%");
System.Console.WriteLine("Female cat percentage " + femaleCatPercentage + "%");




