//Assignment - 1
//In this challenge, we will write a program to accept the following details:
//Month
//Year
//Day of week for the first date of the month(For E.g. 1st Aug 2020 was a Saturday)
//It should print the monthly calendar on the basis of this information.
//Please consider the leap years while formulating the solution.
//Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......):
//8
//Enter Year:
//2020
//Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......):
//6
//case 1
// Calendar     
//S M Tu  W  Th  F   S
//                   1 
// 2  3  4  5  6  7  8 
//9 10 11 12 13 14 15 
//16 17 18 19 20 21 22 
//23 24 25 26 27 28 29 
//30 31 

Console.Write("Enter the Month (Press 1 for Jan, 2 for Feb, 12 for Dec......): ");
int mon = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter the Year: ");
int yr = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter day of the week for First date(Press 1 for Mon, 2 for Tue, 7 for Sun......): ");
int firstday = Convert.ToInt16(Console.ReadLine());
int TotalDays = DateTime.DaysInMonth(yr, mon);
Console.WriteLine("\tCalendar");
Console.WriteLine(" S  M Tu W  Th  F  S");
for (int i = 1; i <= firstday; i++)
{
    Console.Write("   ");
}
for (int Days = 1; Days <= TotalDays; Days++)
{
    Console.Write($"{Days,2} ");
    if ((Days + firstday) % 7 == 0 || Days == TotalDays)
    {
        Console.WriteLine();
    }
}