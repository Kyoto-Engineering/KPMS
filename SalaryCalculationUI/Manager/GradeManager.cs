using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCalculationUI.Gateway;

namespace SalaryCalculationUI.Manager
{
   public  class GradeManager
   {
       private GradeGateway gradeGateway;
    public  int SaveGrade(DAO.Grade aGrade)
        {
        if (aGrade.GradeId == 0)
        {
            throw  new Exception("Please Select Correct Grade");
        }
            gradeGateway=new GradeGateway();
            return gradeGateway.SaveGrade(aGrade);
        }
    }
}
