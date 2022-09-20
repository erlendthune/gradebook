using System.Collections.Generic;
using GradeBook;

var book = new Book("Erlend");

string? line;
do
{
    Console.WriteLine("Please enter grade:");
    line = Console.ReadLine();

    if(line is null) {
        continue;
    }
    if (line == "q") {
        break;
    }

    Double grade = Double.Parse(line);
    book.AddGrade(grade);
    Console.WriteLine($"Added the grade {grade}");
} while(true);


book.ShowStatistics();


// See https://aka.ms/new-console-template for more information
