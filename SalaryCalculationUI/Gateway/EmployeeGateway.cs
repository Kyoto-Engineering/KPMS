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
    public class EmployeeGateway:ConnectionGateway
    {
        //public int SaveEmployee(Employee aEmployee)
        //{
        //    connection.Open();
        //   // string insertEQuery = "insert into Employee Values('" + aEmployee.EmployeeName + "','" + aEmployee.EmployeeImage + "','" + aEmployee.NickName + "','" + aEmployee.Email + "','" + aEmployee.DateOfBirth + "','" + aEmployee.NationalIdNumber + "','" + aEmployee.NamtionalIdImage + "','" + aEmployee.ContactNumber + "','" + aEmployee.Designation + "','" + aEmployee.AccountNo + "','" + aEmployee.Grade + "','" + aEmployee.EducationHistry + "','" + aEmployee.JobLocation + "','" + aEmployee.PresentAddress + "','" + aEmployee.PresentDistrict + "','" + aEmployee.PermanantAddress + "','" + aEmployee.PermanantDistrict + "','" + aEmployee.LocalGardianName + "','" + aEmployee.ReferenceDetail + "','" + aEmployee.WorkHistry + "','" + aEmployee.JoiningDate + "','" + aEmployee.ConformationDate + "','" + aEmployee.DehiriningDate + "','" + aEmployee.LastApprisaldate + "','" + aEmployee.LastApprisalRating + "','" + aEmployee.FatherName + "','" + aEmployee.MotherName + "','" + aEmployee.EndOfTraineePeriod + "','" + aEmployee.EndOfProbationPeriod + "','" + aEmployee.Department + "','" + aEmployee.PassportNo + "')";
        //  // string insertEQuery = "insert into Employee Values('"+aEmployee.EmployeeName+"','"+aEmployee.NickName+"','"+aEmployee.Email+"','"+aEmployee.DateOfBirth+"','"+aEmployee.NationalIdNumber+"','"+aEmployee.ContactNumber+"','"+aEmployee.Designation+"','"+aEmployee.AccountNo+"','"+aEmployee.Grade+"','"+aEmployee.EducationHistry+"','"+aEmployee.JobLocation+"','"+aEmployee.PresentAddress+"','"+aEmployee.PresentDistrict+"','"+aEmployee.PermanantAddress+"','"+aEmployee.PermanantDistrict+"','"+aEmployee.LocalGardianName+"','"+aEmployee.ReferenceDetail+"','"+aEmployee.WorkHistry+"','"+aEmployee.JoiningDate+"','"+aEmployee.ConformationDate+"','"+aEmployee.DehiriningDate+"','"+aEmployee.LastApprisaldate+"','"+aEmployee.FatherName+"','"+aEmployee.MotherName+"','"+aEmployee.EndOfTraineePeriod+"','"+aEmployee.EndOfProbationPeriod+"','"+aEmployee.Department+"','"+aEmployee.PassportNo+"')";
        //    string insertEQuery = "insert into Employee Values('"+aEmployee.EmployeeName+"','"+aEmployee.EmployeeImage+"','"+aEmployee.NickName+"','"+aEmployee.Email+"','"+aEmployee.DateOfBirth+"','"+aEmployee.NationalIdNumber+"','"+aEmployee.NamtionalIdImage+"','"+aEmployee.ContactNumber+"','"+aEmployee.Designation+"','"+aEmployee.AccountNo+"','"+aEmployee.Grade+"','"+aEmployee.EducationHistry+"','"+aEmployee.JobLocation+"','"+aEmployee.PresentAddress+"','"+aEmployee.PresentDistrict+"','"+aEmployee.PermanantAddress+"','"+aEmployee.PermanantDistrict+"','"+aEmployee.LocalGardianName+"','"+aEmployee.ReferenceDetail+"','"+aEmployee.WorkHistry+"','"+aEmployee.JoiningDate+"','"+aEmployee.ConformationDate+"','"+aEmployee.DehiriningDate+"','"+aEmployee.LastApprisaldate+"','"+aEmployee.LastApprisalRating+"','"+aEmployee.FatherName+"','"+aEmployee.MotherName+"','"+aEmployee.EndOfTraineePeriod+"','"+aEmployee.EndOfProbationPeriod+"','"+aEmployee.Department+"','"+aEmployee.PassportNo+"')";
        //    SqlCommand comnd=new SqlCommand(insertEQuery,connection);
        //    int affectedRows = comnd.ExecuteNonQuery();
        //    connection.Close();
        //    return affectedRows;
        //}





        public Employee EditEmployeeByEmployeeId(decimal employeeId)
        {
            connection.Open();
            string select = string.Format("select * from Employee where EmployeeId='{0}'", employeeId);
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Employee aEmployee = new Employee();
            while (dataReader.Read())
            {
                aEmployee.EmployeeId = Convert.ToInt64(dataReader[0].ToString());
                aEmployee.EmployeeName = dataReader[1].ToString();
                //aEmployee.EmployeeImage = dataReader[2].ToString();
                aEmployee.NickName = dataReader[3].ToString();
                aEmployee.Gender = dataReader[4].ToString();
                aEmployee.CorporateMail = dataReader[5].ToString();
                aEmployee.Email = dataReader[6].ToString();
                
                aEmployee.DateOfBirth = Convert.ToDateTime(dataReader[7].ToString());
                aEmployee.NationalIdNumber = dataReader[8].ToString();
                aEmployee.AreaCode1 = dataReader[10].ToString();
                aEmployee.Contact1 = dataReader[11].ToString();
                aEmployee.AreaCode2 = dataReader[12].ToString();
                aEmployee.Contact2 = dataReader[13].ToString();

                aEmployee.Designation = dataReader[14].ToString();
                aEmployee.AccountNo = dataReader[15].ToString();
                aEmployee.GradeId = dataReader[16].ToString();
               
                aEmployee.EducationH1 = dataReader[18].ToString();
                aEmployee.EducationH2 = dataReader[19].ToString();
                aEmployee.EducationH3 = dataReader[20].ToString();
                aEmployee.EducationH4 = dataReader[21].ToString();

                aEmployee.JobLocation = dataReader[22].ToString();
                aEmployee.PresentAddress = dataReader[23].ToString();
                aEmployee.PresentDistrict = dataReader[24].ToString();
                aEmployee.PermanantAddress = dataReader[25].ToString();
                aEmployee.PermanantDistrict = dataReader[26].ToString();

                aEmployee.LocalGardianName = dataReader[27].ToString();
                aEmployee.Reference1 = dataReader[28].ToString();
                aEmployee.Reference2 = dataReader[29].ToString();

                aEmployee.WorkHistry = dataReader[30].ToString();
                aEmployee.WorkHistry2 = dataReader[31].ToString();
                aEmployee.WorkHistry3 = dataReader[32].ToString();
                aEmployee.WorkHistry4 = dataReader[33].ToString();

                aEmployee.JoiningDate = dataReader[34].ToString();
                aEmployee.ConformationDate = dataReader[35].ToString();
                aEmployee.DehiriningDate = dataReader[36].ToString();

                aEmployee.LastApprisaldate = dataReader[38].ToString();
                aEmployee.LastApprisalRating = dataReader[40].ToString();

                aEmployee.FatherName = dataReader[41].ToString();
                aEmployee.MotherName = dataReader[42].ToString();
                aEmployee.MaritalStatus = dataReader[43].ToString();
                aEmployee.SpouseName = dataReader[44].ToString();
                aEmployee.EndOfTraineePeriod = dataReader[45].ToString();
                aEmployee.EndOfProbationPeriod = dataReader[47].ToString();
                aEmployee.Department = dataReader[48].ToString();
                aEmployee.PassportNo = dataReader[49].ToString();
                aEmployee.Status = dataReader[50].ToString();
                aEmployee.EmploymentStage = dataReader[51].ToString();


            }
            dataReader.Close();
            connection.Close();
            return aEmployee;
        }


        public Employee SearchEmployee(decimal employeeId)
        {
           connection.Open();
           string select = string.Format("select * from Employee where EmployeeId='{0}'", employeeId);
            SqlCommand command=new SqlCommand(select,connection);
            SqlDataReader dataReader = command.ExecuteReader();
            Employee aEmployee=new Employee();
            while (dataReader.Read())
            {
                aEmployee.EmployeeId = Convert.ToInt64(dataReader[0].ToString());
                aEmployee.EmployeeName = dataReader[1].ToString();
                aEmployee.Designation = dataReader[14].ToString();
                aEmployee.GradeId = dataReader[16].ToString();
                aEmployee.AccountNo = dataReader[15].ToString();
            }
            dataReader.Close();
            connection.Close();
            return aEmployee;
        }



        //public int UpdateEmployee(Employee aEmployee)
        //{
        //    connection.Open();
        //    string UpdateQuery = "Update Employee Set EmployeeName='" + aEmployee.EmployeeName+ "',NickName='" + aEmployee.NickName + "',Gender='" + aEmployee.Gender + "',CorporateMail='" + aEmployee.CorporateMail + "',EmailId='" + aEmployee.Email + "',DateOfBirth='" + aEmployee.DateOfBirth + "',NationalId='" + aEmployee.NationalIdNumber + "',AreaOrCountryCode1='" + aEmployee.AreaCode1 + "',Contact1='" + aEmployee.Contact1+ "',AreaOrCountryCode2='" + aEmployee.AreaCode2+ "',Contact2='" + aEmployee.Contact2 + "',Designation='" + aEmployee.Designation + "',AccountNumber='" + aEmployee.AccountNo + "',GradeId='" + aEmployee.GradeId + "',EducationL1='" +aEmployee.EducationH1+ "',EducationL2='" + aEmployee.EducationH2+ "',EducationL3='" + educationHistory3TextBox.Text + "',EducationL4='" + educationHistory4TextBox.Text + "',JobLocation='" + cmbJobLocation.Text + "',PresentAddress='" + presentAddressTextBox.Text + "',PresentDistrict='" + presentDistrictComboBox.Text + "',PermanantAddress='" + permanantAddressTextBox.Text + "',PermanantDistrict='" + permanantDistrictComboBox.Text + "',LocalGardianName='" + localGardianNameTextBox.Text + "',ReferenceDetail='" + reference1TextBox.Text + "',ReferenceD2='" + reference2TextBox.Text + "',WorkHistry='" + workHistory1TextBox.Text + "',WorkHistry2='" + workHistory2TextBox.Text + "',WorkHistry3='" + workHistory3TextBox.Text + "',WorkHistry4='" + workHistory4TextBox.Text + "',JoiningDate='" + joinDate + "',ConformationDate='" + ConformDate + "',DehiringDates='" + dehireDate + "',LastAppraisalDates='" + lastAppDate + "',LastApprisalRating='" + lastAppraisalRatingTextBox.Text + "',FatherName='" + fatherNameTextBox.Text + "',MotherName='" + motherNameTextBox.Text + "',MaritalStatus='" + cmbMaritalStatus.Text + "',SpouseName='" + spouseNameTextBox.Text + "',EndofTraineePeriods='" + trainydate + "',EndOfProbationPeriodDate='" + probationdate + "',Department='" + departmentTextBox.Text + "',PassportNo='" + passportNOTextBox.Text + "' Where EmployeeId='" + cmbEmployeeId.Text + "' ";
        //   // string UpdateQuery = "Update Employee set EmployeeName='" + aEmployee.EmployeeName + "',EmployeeImage='" + aEmployee.EmployeeImage + "',NickName='" + aEmployee.NickName + "',EmailId='" + aEmployee.Email + "',DateOfBirth='" + aEmployee.DateOfBirth + "',NationalId='" + aEmployee.NationalIdNumber + "',NationalIdImage='" + aEmployee.NamtionalIdImage + "',Contact='" + aEmployee.ContactNumber + "',Designation='" + aEmployee.Designation + "',AccountNumber='" + aEmployee.AccountNo + "',Grade='" + aEmployee.Grade + "',EducationHistry='" + aEmployee.EducationHistry + "',JobLocation='" + aEmployee.JobLocation + "',PresentAddress='" + aEmployee.PresentAddress + "',PresentDistrict='" + aEmployee.PresentDistrict + "',PermanantAddress='" + aEmployee.PermanantAddress + "',PermanantDistrict='" + aEmployee.PermanantDistrict + "',LocalGardianName='" + aEmployee.LocalGardianName + "',ReferenceDetail='" + aEmployee.ReferenceDetail + "',WorkHistry='" + aEmployee.WorkHistry + "',JoiningDate='" + aEmployee.JoiningDate + "',ConformationDate='" + aEmployee.ConformationDate + "',DehiringDate='" + aEmployee.DehiriningDate + "',LastAppraisalDate='" + aEmployee.LastApprisaldate + "',FatherName='" + aEmployee.FatherName + "',MotherName='" + aEmployee.MotherName + "',EndofTraineePeriod='" + aEmployee.EndOfTraineePeriod + "',EndOfProbationPeriodDate='" + aEmployee.EndOfProbationPeriod + "',Department='" + aEmployee.Department + "' Where EmployeeId='" + aEmployee.EmployeeId + "'";
        //    SqlCommand cmd = new SqlCommand(UpdateQuery, connection);
        //    int reader = cmd.ExecuteNonQuery();
        //    connection.Close();
        //    return reader;

        //}
    }
}
