
using System;
using System.Collections.Generic;
using System.Text;

namespace IntergenicResearchLibraryy
{

    public class Library : IDefaulterList
    {
        public Book Bookdetails { get; set; }

        public Student StudentDetails { get; set; }

        public string Issueddate { get; set; }

        public string ReturnDate { get; set; }

       
       






        //===============================================Constructor startshere=====================================================
        public Library(Student studentdetails, Book book, string issueddate, string returndate)
        {
            Bookdetails = book;
            StudentDetails = studentdetails;
            Issueddate = issueddate;
            ReturnDate = returndate;
            
        }

        
        //===============================================constructor ends here=====================================================



        //===============================================GetDefaulter method starts here =====================================================

        public  string GetDefaulter( ) 
        {

            try
            {
                System.DateTime dtissueDate = Convert.ToDateTime(Issueddate);
                System.DateTime dtreturnDate = Convert.ToDateTime(ReturnDate);

                System.DateTime dtTempDate = dtissueDate.AddDays(+14);

                TimeSpan DateDifferent = dtreturnDate - dtTempDate;

                double Days = DateDifferent.TotalDays;
                double DefaultDays = Days - 14;
                
                if( Days > 1)
                     
                {
                
                    return $"{StudentDetails.StudentName}  is a defaulter, he held\n the Book {Bookdetails.BookName} wich has  ID  {Bookdetails.BookID}";
                }
                return $"{StudentDetails.StudentName} returned the book on on {ReturnDate}";

          

            }
            catch (FormatException)
            {
                return $"Unable to parse the specified date";


            }

        }



        //===============================================GetDefaulter method ends here =====================================================


        //===============================================GetName Method starts here=====================================================

        public string GetName()
        {
            return $"Student Name: {StudentDetails.StudentName}";
        }
        //===============================================GetName Method starts here=====================================================




        //===============================================GetBook method startshere=====================================================
        public string GetBook()
        {

            return $"Book Name: {Bookdetails.BookName} \nBook ID: {Bookdetails.BookID}";

        }

        //===============================================GetBook method startshere=====================================================



             //===============================================GetYear method startshere=====================================================


        public string GetYear()
        {
            return $"Year of study: {StudentDetails.YearOfStudy} ";
        }

        //===============================================GetYear method ends here=====================================================


        

        //===============================================GetDateIssue method starts here=====================================================
        public string GetDateIssue()
        {
            System.DateTime dtissueDate = Convert.ToDateTime(Issueddate);
            return $"Date issued: {dtissueDate}";

        }
 //===============================================GetDateIssue method ends here=====================================================
        public string GetDateReturn()
        {
            try
            {





                System.DateTime dtissueDate = Convert.ToDateTime(Issueddate);

                

                System.DateTime dtreturnDate = dtissueDate.AddDays(+14);

                TimeSpan DateDifferent = dtreturnDate - dtissueDate;
                double Days = DateDifferent.TotalDays;

                
                return $"Supposed Return Date{dtreturnDate} \nActual Returned Date :{ReturnDate} ";

               

            }
            catch (FormatException)
            {
                return $"Unable to parse the specified date";


            }

        }

        public string Returndate()
        {

            try
            {





                System.DateTime dtiDate = Convert.ToDateTime(Issueddate);

                //DateTime rDate = Convert.ToDateTime (ReturnDate);

                // Console.WriteLine(Issueddate);

                System.DateTime dtrDate = dtiDate.AddDays(+14);

                TimeSpan DateDifferent = dtrDate - dtiDate;
                double Days = DateDifferent.TotalDays;

                // Console.WriteLine($"returndate is {rDate}");
                //Console.WriteLine(Days);
                return $"Book issued date: {dtiDate} \nDate of to return Book:{dtrDate}";
                //Console.WriteLine(DateDifferent);

            }
            catch (FormatException)
            {
                return $"Unable to parse the specified date";


            }
        }

        public override string ToString()
        {
            return $"===============Student Details=====================\n{GetName()} \n{GetYear()} \n==============Book Details======================== :\n{GetBook()} \n{GetDateIssue()}  \n{GetDateReturn()}\n =========Default Status============\n{GetDefaulter()}";
        }
    }
}
