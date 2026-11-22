using System;

namespace C__Assignment
{
    
    
        public class Book

        {
            public string Title;
        public int Pages;

    static void Main(string[] args)
    {
            #region book object
            object myBook = new Book { Title = "Game of thrones", Pages = 447 };
            Console.WriteLine(myBook);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.GetHashCode);
            Console.WriteLine(myBook.Equals(myBook));
            Console.WriteLine(myBook.GetType);

            #endregion
            #region code error
            /*int pages = "464" => compile error, 
                 * cant convert string to an int, 464 is treated as string because of "", use parse or remove "" */

            int pages = 464;

            #endregion


            #region divide by zero
            int x = 10;
            int y = 0;
            try
            {
                int division = x / y;
                Console.WriteLine($"result is {division}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("done");
            }


            #endregion



            #region convert without cast

            int pages2 = 300;

            double dblPages= pages2;

            #endregion

            #region convert with cast

            double price = 49.99;
            int intPrice = (int)price;
            Console.WriteLine(price);
            Console.WriteLine(intPrice);

            #endregion


            #region convert with "Convert"

            string pagesText = "464";
            int pages3= Convert.ToInt32(pagesText);
            Console.WriteLine(pages3);

            #endregion



            #region try convert intparse

            string yearText = "2023";

            int yearNum = int.Parse(yearText);

            string badText = "abc";
            if (int.TryParse(badText, out int result))
            {

                Console.WriteLine(result);

            }
            else {
                Console.WriteLine("Invalid number");
                    
                    
                    
                    };
            #endregion


            #region convert and get type

            int pages4 = 464;

            string pagesText2 = pages4.ToString();
            Console.WriteLine(pagesText2.GetType());



            #endregion



            #region boxing and unboxing

            int copies = 100;
            object box = copies;
            int unbox = (int)box;

            Console.WriteLine(box);
            Console.WriteLine(unbox);








            #endregion








        }

}


        
    }

