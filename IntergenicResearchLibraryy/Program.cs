using System;
using System.Collections.Concurrent;


namespace IntergenicResearchLibraryy
{
    class Program
    {
        static void Main(string[] args)
        {


            try 
            {


                Student student = new Student("Chibuike", "Second Year");
                Student student1 = new Student("Ifeanyi", "Second Year");
                Student student2 = new Student("Banky", "first Year");
                Student student3 = new Student("Tolu", "Third year");
                Student student4 = new Student("Grace", "Final");
                Book book = new Book("Things Fall apart", "456XR");
                Book book1 = new Book("The gods are wise", "564TC");
                Book book2 = new Book("Think Big", "456");
                Book book3 = new Book("With a Golden Spon", "756Xv");
                Book book4 = new Book(" Favours Emblem", "765TC");

                Library library = new Library(student, book, "2/25/2017", "3/1/2017");
                Library library1 = new Library(student1, book1, "12/25/2017", "3/1/2018");
                Library library2 = new Library(student2, book2, "8/2/2017", "8/20/2017");
                Library library3 = new Library(student3, book3, "11/5/2017", "11/15/2017");
                Library library4 = new Library(student4, book4, "2/7/2017", "11/7/2017");



                GenericDefaulterList<IDefaulterList> myList = new GenericDefaulterList<IDefaulterList>();


                myList.Add(library);
                myList.Add(library1);
                myList.Add(library2);
                myList.Add(library3);
                myList.Add(library4);


                foreach (var defaulters in myList.GetAllDefaulters())
                {
                    Console.WriteLine(defaulters);
                }

            }

            catch (FormatException)
            {
                return $"Error detected";


            }






        }
    }
}
