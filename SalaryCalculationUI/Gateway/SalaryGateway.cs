using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCalculationUI.DAO;
using SalaryCalculationUI.DBGateway;

namespace SalaryCalculationUI.Gateway
{
   public  class SalaryGateway:ConnectionGateway
    {

       public int SaveSalary(Salary aSalary)
       {
           connection.Open();
           String insertQury = "insert into Salary values('"+aSalary.EmployeeId+"','"+aSalary.EmployeeName+"','"+aSalary.Designation+"','"+aSalary.AccountNo+"','"+aSalary.Month+"','"+aSalary.Year+"','"+aSalary.ReferenceNo+"','"+aSalary.GradeId+"','"+aSalary.Basic+"','"+aSalary.TransportAllowance+"','"+aSalary.MedicalAllowance+"','"+aSalary.HouseRent+"','"+aSalary.OtherAllowance+"','"+aSalary.InterimAllowance+"','"+aSalary.GrossSalary+"','"+aSalary.Tax+"','"+aSalary.NetGrossSalaryAfterTax+"','"+aSalary.TotalWorkingDay+"','"+aSalary.PerdaySalary+"','"+aSalary.DayPayable+"','"+aSalary.UnpaidLeave+"','"+aSalary.GivenAnnualLeave+"','"+aSalary.PHAttendence+"','"+aSalary.LeaveWithPay+"','"+aSalary.Fine+"','"+aSalary.DeductionFromAnnualLeave+"','"+aSalary.AdvancePaid+"','"+aSalary.DeductionForLeave+"','"+aSalary.Adjustment+"','"+aSalary.TotalDeduction+"','"+aSalary.Bonus+"','"+aSalary.PreviousDues+"','"+aSalary.TotalAddition+"','"+aSalary.NetPayable+"')";
           //String insertQury = "insert into Salary(EmployeeId,EmployeeName,Designation,AccountNo,Months,GradeId,Basic,TransportAllowance,MedicalAllowance,HouseRent,OtherAllowance,GrossSalary,Tax,NetGrossSalaryAfterTax,TotalWorkingDay,PerdaySalary,DayPayable,UnpaidLeave,GivenAnnualLeave,PHAttendence,LeaveWithPay,Fine,DeductionFromAnnualLeave,AdvancePaid,DeductionForLeave,Adjustment,TotalDeduction,PreviousDues,TotalAddition,NetPayable)values('" + aSalary.EmployeeId + "','" + aSalary.EmployeeName + "','" + aSalary.Designation + "','" + aSalary.AccountNo + "','" + aSalary.Month + "','" + aSalary.GradeId + "','" + aSalary.Basic + "','" + aSalary.TransportAllowance + "','" + aSalary.MedicalAllowance + "','" + aSalary.HouseRent + "','" + aSalary.OtherAllowance + "''" + aSalary.GrossSalary + "','" + aSalary.Tax + "','"+aSalary.NetGrossSalaryAfterTax+"','"+aSalary.TotalWorkingDay+"','"+aSalary.PerdaySalary+"','"+aSalary.DayPayable+"','"+aSalary.UnpaidLeave+"','"+aSalary.GivenAnnualLeave+"','"+aSalary.PHAttendence+"','"+aSalary.LeaveWithPay+"','"+aSalary.Fine+"','"+aSalary.DeductionFromAnnualLeave+"','"+aSalary.AdvancePaid+"','"+aSalary.DeductionForLeave+"','"+aSalary.Adjustment+"','"+aSalary.TotalDeduction+"','"+aSalary.PreviousDues+"','"+aSalary.TotalAddition+"','"+aSalary.NetPayable+"')";
          // String insertQury = "insert into Salary(EmployeeId,EmployeeName,Designation,AccountNo,Months,GradeId,Basic,TransportAllowance,MedicalAllowance,HouseRent,OtherAllowance,GrossSalary,Tax,NetGrossSalaryAfterTax,TotalWorkingDay,PerdaySalary,DayPayable,UnpaidLeave,GivenAnnualLeave,PHAttendence,LeaveWithPay,Fine,DeductionFromAnnualLeave,AdvancePaid,DeductionForLeave,Adjustment,TotalDeduction,PreviousDues,TotalAddition,NetPayable)values('" + aSalary.EmployeeId + "','" + aSalary.EmployeeName + "','" + aSalary.Designation + "','" + aSalary.AccountNo + "','" + aSalary.Month + "','" + aSalary.GradeId + "'," + "'" + aSalary.Basic + "','" + aSalary.TransportAllowance + "','" + aSalary.MedicalAllowance + "','" + aSalary.HouseRent + "','" + aSalary.OtherAllowance + "''" + aSalary.GrossSalary + "','" + aSalary.Tax + "','" + aSalary.NetGrossSalaryAfterTax + "','" + aSalary.TotalWorkingDay + "','" + aSalary.PerdaySalary + "'," + "'" + aSalary.DayPayable + "','" + aSalary.UnpaidLeave + "','" + aSalary.GivenAnnualLeave + "','" + aSalary.PHAttendence + "','" + aSalary.LeaveWithPay + "','" + aSalary.Fine + "','" + aSalary.DeductionFromAnnualLeave + "','" + aSalary.AdvancePaid + "','" + aSalary.DeductionForLeave + "','" + aSalary.Adjustment + "','" + aSalary.TotalDeduction + "','" + aSalary.PreviousDues + "','" + aSalary.TotalAddition + "','" + aSalary.NetPayable + "')";
           SqlCommand command = new SqlCommand(insertQury, connection);
           int effectedRors = command.ExecuteNonQuery();
           connection.Close();
           return effectedRors;


       }


       
    }
}
