using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DAO
{
   public  class Grade
   {
        private decimal gradeId;
        private decimal basic;
        private decimal transportAllowance;
        private decimal medicalAllowance;
        private decimal houserent;
        private decimal otherAllowance;
        private decimal grossGSalary;
       

       public decimal GradeId
       {
           get { return gradeId; }
           set { gradeId = value; }
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

        public decimal GrossGSalary
        {
            set { grossGSalary = value; }
            get { return grossGSalary; }
        }
    }
}
