using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationUI.DAO
{
   public  class Employee
   {
       private decimal employeeId;
       private string employeeName;
       private string designation;
       private string gradeId;
       private string accountNo;
       private string month;

       private string employeeImage;
       private string nickName;
       private string gender;
       private string corporateMail;
       private string email;
       private string areaCode1;
       private string contact1;
       private string areaCode2;
       private string contact2;



       private DateTime dateOfBirth;
       private string nationalIdNumber;
       private string nationalIdImage;



       private string  fatherName;
       private string motherName;
       private string maritalStatus;
       private string spouseName;
       private string educationH1;
       private string educationH2;
       private string educationH3;
       private string educationH4;

       private string department;
       private string workhistory;
       private string workhistory2;
       private string workhistory3;
       private string workhistory4;
       private string jobLocation;

       private string presentAddress;
       private string presntDistrict;
       private string permanantAddress;
       private string permanantDistrict;
       private string localGardianName;
       private string ref1;
       private string ref2;

       private string endOfTraineePeriod;
       private string endOfProbationPeriod;
       private string  joiningDate;
       private string conformationDate;
       private string dehiringDate;
       private string lastApprisalDate;
       private string passportNo;
       private string status;
       private string lastApprisalRating;
       private string employmentStage;






       public decimal EmployeeId
       {
           set { employeeId = value; }
           get { return employeeId; }
       }

       public string EmployeeName
       {
           get { return employeeName; }
           set { employeeName = value; }
       }

       public string Designation
       {
           get { return designation; }
           set { designation = value; }
       }
       public string GradeId
       {
           set { gradeId = value; }
           get { return gradeId; }
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

       public string EmployeeImage
       {
           get { return employeeImage; }
           set { employeeImage = value; }
       }

       public string NickName
       {
           get { return nickName; }
           set { nickName = value; }
       }

       public string Gender
       {
           set { gender = value; }
           get { return gender; }
       }

       public string CorporateMail
       {
           set { corporateMail = value; }
           get { return corporateMail; }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }

       public string AreaCode1
       {
           set { areaCode1 = value; }
           get { return areaCode1; }
       }
       public string Contact1
       {
           get { return contact1; }
           set { contact1 = value; }
       }

       public string AreaCode2
       {
           set { areaCode2 = value; }
           get { return areaCode2; }
       }

       public string Contact2
       {
           set { contact2 = value; }
           get { return contact2; }
       }
       public DateTime DateOfBirth
       {
           get { return dateOfBirth; }
           set { dateOfBirth = value; }
       }

       public string NationalIdNumber
       {
           get { return nationalIdNumber; }
           set { nationalIdNumber = value; }
       }

       public string NamtionalIdImage
       {
           get { return nationalIdImage; }
           set { nationalIdImage = value; }
       }

       public string FatherName
       {
           get { return fatherName; }
           set { fatherName = value; }
       }

       public string MotherName
       {
           get { return motherName; }
           set { motherName = value; }
       }

       public string SpouseName
       {
           set { spouseName = value; }
           get { return spouseName; }
       }

       public string MaritalStatus
       {
           set { maritalStatus = value; }
           get { return maritalStatus; }
       }

       public string EducationH1
       {
           set { educationH1 = value; }
           get { return educationH1; }
       }
       public string EducationH2
       {
           set { educationH2 = value; }
           get { return educationH2; }
       }
       public string EducationH3
       {
           set { educationH3 = value; }
           get { return educationH3; }
       }
       public string EducationH4
       {
           set { educationH4 = value; }
           get { return educationH4; }
       }
       public string Department
       {
           set { department = value; }
           get { return department; }
       }

       public string WorkHistry
       {
           get { return workhistory; }
           set { workhistory = value; }
       }
       public string WorkHistry2
       {
           get { return workhistory2; }
           set { workhistory2 = value; }
       }
       public string WorkHistry3
       {
           get { return workhistory3; }
           set { workhistory3 = value; }
       }
       public string WorkHistry4
       {
           get { return workhistory4; }
           set { workhistory4 = value; }
       }
       public string JobLocation
       {
           set { jobLocation = value; }
           get { return jobLocation; }
       }

       public string PresentAddress
       {
           get { return presentAddress; }
           set { presentAddress = value; }
       }

       public string PresentDistrict
       {
           get { return presntDistrict; }
           set { presntDistrict = value; }

       }

       public string PermanantAddress
       {
           set { permanantAddress = value; }
           get { return permanantAddress; }
       }

       public string PermanantDistrict
       {
           get { return permanantDistrict; }
           set { permanantDistrict = value; }
       }

       public string LocalGardianName
       {
           get { return localGardianName; }
           set { localGardianName = value; }
       }

       public string Reference1
       {
           get { return ref1; }
           set { ref1 = value; }
       }
       public string Reference2
       {
           get { return ref2; }
           set { ref2 = value; }
       }
       public string EndOfTraineePeriod
       {
           get { return endOfTraineePeriod; }
           set { endOfTraineePeriod = value; }
       }

       public string EndOfProbationPeriod
       {
           get { return endOfProbationPeriod; }
           set { endOfProbationPeriod = value; }
       }

       public string JoiningDate
       {
           get { return joiningDate; }
           set { joiningDate = value; }
       }

       public string ConformationDate
       {
           get { return conformationDate; }
           set { conformationDate = value; }
       }

       public string DehiriningDate
       {
           get { return dehiringDate; }
           set { dehiringDate = value; }
       }

       public string LastApprisaldate
       {
           get { return lastApprisalDate; }
           set { lastApprisalDate = value; }
       }

       public string LastApprisalRating
       {
           get { return lastApprisalRating; }
           set { lastApprisalRating = value; }
       }

       public string PassportNo
       {
           get { return passportNo; }
           set { passportNo = value; }
       }

       public string Status
       {
           get { return status; }
           set { status = value; }
       }

       public string EmploymentStage
       {
           set { employmentStage = value; }
           get { return employmentStage; }
       }




      
   }
}
