using System;

namespace EmpWageDay6
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);

        public void computeEmpWage();
        public int getTotalWage(string company);

    }
}