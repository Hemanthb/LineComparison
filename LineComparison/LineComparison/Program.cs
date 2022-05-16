// See https://aka.ms/new-console-template for more information
LineComparison.Line linecomparison = new LineComparison.Line();
double length1 = linecomparison.getLength(3, 3, 2, 8);
double length2 = linecomparison.getLength(4, 3, 4, 8);
//Console.WriteLine("length of the given line is"+length);
if(linecomparison.CheckLengthEquality(length1, length2))
{
    Console.WriteLine("Length1- {0} and Length2 - {1} are equal",length1,length2);
}
else
{
    Console.WriteLine("Length1- {0} and Length2 - {1} are not equal", length1, length2);
}
linecomparison.CompareLength(length1, length2);
