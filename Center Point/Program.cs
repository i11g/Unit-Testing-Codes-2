﻿static string GetClosest(double x1, double y1, double x2, double y2)
{
    double pointOne = Math.Abs(x1) + Math.Abs(y1);
    double pointTwo = Math.Abs(x2) + Math.Abs(y2);

    string firstPointReport = $"({string.Join(", ", x1, y1)})";
    string secondPointReport = $"({string.Join(", ", x2, y2)})";

    if (pointOne > pointTwo)
    {
        return secondPointReport;
    }
    else if (pointOne < pointTwo)
    {
        return firstPointReport;
    }
    else
    {
        if (x2 < 0 || y2 < 0)
        {
            return secondPointReport;
        }

        return firstPointReport;
    }
}

double x1=double.Parse(Console.ReadLine()); 
double y1=double.Parse(Console.ReadLine()); 
double x2=double.Parse(Console.ReadLine()); 
double y2=double.Parse(Console.ReadLine());


string result = GetClosest(x1, y1, x2, y2);

Console.WriteLine(result);