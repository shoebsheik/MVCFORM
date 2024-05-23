using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFORM.Sql_Query
{
    public class SQ
    {
//        CREATE DATABASE EmployeeDB

//    CREATE TABLE Employee_Id(
//    Emp_Id INT NOT NULL PRIMARY KEY,
//    Sr_no INT IDENTITY(1,1),
//    Name NVARCHAR(50),
//    Age INT,
//    Email NVARCHAR(250),
//    Gender CHAR(2),
//    Mobile NVARCHAR(15),
//    Password NVARCHAR(50),
//    Reg_Date DATETIME,
//    Up_Date DATETIME
//);

//CREATE TABLE Employee_Details(Sr_no INT IDENTITY(1,1), Emp_Id INT FOREIGN KEY REFERENCES Employee_Id(Emp_Id),Position NVARCHAR(50),
//    Salary DECIMAL(18,2),
//    DOB DATE )


//   ALTER PROCEDURE EMPLOYEEDATILS(
//     @MODE NVARCHAR(50),
//    @Name NVARCHAR(50),
//    @Emp_Id NVARCHAR(50),
//    @Age INT = 0,
//    @Gender NVARCHAR(50),
//	@Email NVARCHAR(50),
//    @Mobile NVARCHAR(50),
//    @Password NVARCHAR(50),
//	@Position NVARCHAR(50),
//	@Salary NVARCHAR(50),
//	@DOB DATE

//	)

//    AS
//    BEGIN

//     DECLARE @Reg_Date DATE = CAST(GETDATE() AS DATE)
//    DECLARE @Up_Date DATE = (select dbo.NOW_DATETIME(getdate()))

//    IF(@MODE = 'INSERT')
//    BEGIN
//        INSERT INTO Employee_Id(Emp_Id, Name, Age, Email, Gender, Mobile, Password, Reg_Date, Up_Date)
//        VALUES(@Emp_Id, @Name, @Age, @Email, @Gender, @Mobile, @Password, @Reg_Date, @Up_Date)
//    END
//    IF(@MODE = 'UPDATE')
//    BEGIN

//        UPDATE  Employee_Id set Email=@Email , Up_Date =@Up_Date

//    END

//    IF(@MODE = 'LOGIN')
//    BEGIN


//        SELECT* FROM Employee_Id WHERE Mobile = @Mobile AND Password =@Password

//   END

//    IF(@MODE = 'DELETE')
//    BEGIN

//        DELETE from Employee_Id WHERE Mobile = @Mobile


//    END
//    END



//    SELECT* FROM Employee_Id
    }
}