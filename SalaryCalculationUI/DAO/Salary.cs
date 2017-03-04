using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DAO
{
  public  class Salary
  {
      private int id;
      private decimal employeeId;
      private string employeeName;
      private string designation;
      private string accountNo;
      private string month;
      private string year;
      private string referenceNo;

      //private decimal grade;
      private decimal gradeId;
      private decimal basic;
      private decimal transportAllowance;
      private decimal medicalAllowance;
      private decimal houserent;
      private decimal otherAllowance;
      private decimal interimAllowance;
      private decimal grossSalary;
      private decimal tax;
      private decimal netGrossSalaryAfterTax;

      private decimal totalWorkingDay;
      private decimal perDaySalary;
      private decimal pHAttendence;
      private decimal leaveWithPay;
      private decimal dayPayable;
      private decimal unpaidLeave;
      private decimal givenAnnualLeave;

      private decimal fine;
      private decimal deductionFromAnnualLeave;
      private decimal advancedPaid;
      private decimal deductionForLeave;
      private decimal adjustments;
      private decimal totalDeduction;
      private decimal bonus;
      private decimal previousDues;
      private decimal totalAddition;
      private decimal netPayable;

      public int Id
      {
          get { return id; }
          set { id = value; }

      }

      public decimal EmployeeId
      {
          set { employeeId = value; }
          get { return employeeId; }
      }
      

      public string EmployeeName
      {
          set { employeeName = value; }
          get { return employeeName; }
      }

      public string Designation
      {
          set { designation = value; }
          get { return designation; }
      }

     
      public string AccountNo
      {
          set { accountNo = value; }
          get { return accountNo; }
      }

      public string Month
      {
          set { month = value; }
          get { return month; }
      }

      public string Year
      {
          set { year = value; }
          get { return year; }
      }

      public string ReferenceNo
      {
          set { referenceNo = value; }
          get { return referenceNo; }
      }

      public decimal GradeId
      {
          set { gradeId = value; }
          get { return gradeId; }
      }
      public decimal Basic
      {
          set { basic = value; }
          get { return basic; }
      }

      public decimal TransportAllowance
      {
          set { transportAllowance = value; }
          get { return transportAllowance; }
      }

      public decimal MedicalAllowance
      {
          set { medicalAllowance = value; }
          get { return medicalAllowance; }
      }

      public decimal HouseRent
      {
          set { houserent = value; }
          get { return houserent; }
      }

      public decimal OtherAllowance
      {
          get { return otherAllowance; }
          set { otherAllowance = value; }
      }

      public decimal InterimAllowance
      {
          get { return interimAllowance; }
          set { interimAllowance = value; }
      }
      public decimal GrossSalary
      {
          set { grossSalary = value; }
          get { return grossSalary; }
      }
      public decimal Tax
      {
          set { tax = value; }
          get { return tax; }
      }

      public decimal NetGrossSalaryAfterTax
      {
          get { return netGrossSalaryAfterTax; }
          set { netGrossSalaryAfterTax = value; }
      }
      public decimal TotalWorkingDay
      {
          set { totalWorkingDay = value; }
          get { return totalWorkingDay; }
      }

      public decimal PerdaySalary
      {
          set { perDaySalary = value; }
          get { return perDaySalary; }
      }

      
      public decimal DayPayable
      {
          set { dayPayable = value; }
          get { return dayPayable; }
      }

      public decimal PHAttendence
      {
          set { pHAttendence = value; }
          get { return pHAttendence; }
      }

      public decimal LeaveWithPay
      {
          set { leaveWithPay = value; }
          get { return leaveWithPay; }
      }
      public decimal UnpaidLeave
      {
          set { unpaidLeave = value; }
          get { return unpaidLeave; }
      }

      public decimal GivenAnnualLeave
      {
          set { givenAnnualLeave = value; }
          get { return givenAnnualLeave; }
      }

     

      public decimal Fine
      {
          get { return fine; }
          set { fine = value; }
      }

      public decimal DeductionFromAnnualLeave
      {
          get { return deductionFromAnnualLeave; }
          set { deductionFromAnnualLeave = value; }
      }

      public decimal AdvancePaid
      {
          get { return advancedPaid; }
          set { advancedPaid = value; }
      }

      public decimal DeductionForLeave
      {
          get { return deductionForLeave; }
          set { deductionForLeave = value; }
      }

      public decimal TotalDeduction
      {
          get { return totalDeduction; }
          set { totalDeduction = value; }
      }

      

      public decimal Adjustment
      {
          get { return adjustments; }
          set { adjustments = value; }
      }

      public decimal Bonus
      {
          get { return bonus; }
          set { bonus = value; }
      }

      public decimal PreviousDues
      {
          get { return previousDues; }
          set { previousDues = value; }
      }

      public decimal TotalAddition
      {
          get { return totalAddition; }
          set { totalAddition = value; }
      }

      public decimal NetPayable
      {
          get { return netPayable; }
          set { netPayable = value; }
      }
  }
}
