﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1AddMultipleEmployee_PayRoll_ultitrading
{
    class EmployeePayRollUsingThread
    {

        public List<EmployeeDetails> employeeDetailsList = new List<EmployeeDetails>();
        public void addEmployeeToPayroll(List<EmployeeDetails> employeeDetailsList)
        {
            employeeDetailsList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeeDetailsList.ToString());
        }

        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetailsList.Add(emp);
        }
    }
}
