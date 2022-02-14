string numberAsString;
int charge; 
int number;

Console.Write("How much was your meal? $");
numberAsString = Console.ReadLine();
charge = Convert.ToInt32(numberAsString);

const double TAX_RATE = 0.0675;

double tip = charge * 0.2;
double postTipAmount = tip + charge;
double tax = (TAX_RATE * postTipAmount);
double total = tip + charge + tax;

System.Console.WriteLine("Charge: $" + charge);
System.Console.WriteLine("Tip: $" + tip);
System.Console.WriteLine("Tax: $" + tax);
System.Console.WriteLine("Total: $" + total);