using System;
using System.Collections;

MathAssignment ma = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
Console.WriteLine(ma.GetSummary());
Console.WriteLine(ma.GetHomeworkList());

WritingAssignment wa = new("Mary Waters", "European History", "The Causes of World War II");
Console.WriteLine(wa.GetSummary());
Console.WriteLine(wa.GetWritingInformation());
