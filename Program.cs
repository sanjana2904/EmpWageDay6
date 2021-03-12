using System;

namespace EmpWageDay6
{
    class Program
    {
        EmpWageBuilderObject dMart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
        EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 10, 4, 20);
        dMart.computeEmpWage();
        Console.WriteLine(dMart.toString());
        reliance.computeEmpWage();
        Console.WriteLine(reliance.toString());
			}

		}
    

