using System;

namespace taskclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daxil edilecek kitablarin sayi  :");
            int size = Convert.ToInt32(Console.ReadLine());
            Library books = new Library();
            books.Books = new Book[size];

            for (int i = 0; i < size; i++)
            {
                string name = "";
                string genre = "";
                int count = 0;
                int no = 0;
                double price = 0;
                bool h = true;
                while (h)
                {
                    h = false;
                    Console.WriteLine("Kitabin nomresi : ");
                    no = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (books.Books[j].No == no)
                        {
                            Console.WriteLine("Bu nomre  daxil edilib!!!   Xais olunur ferqli nomre daxil et !!!");
                            h = true;
                        }
                        else
                        {

                            break;
                        }
                    }
                }

                while (name.Length < 1 || name.Length > 50)
                {

                    Console.WriteLine("Kitabin adini yazin :   (simvol sayi  1-den 50-ye kimi ola biler )");
                    name = Console.ReadLine();
                    if (name.Length >= 1 && name.Length < 50)
                    {
                        break;
                    }
                    Console.WriteLine("ADI DUZGUN DAXIL EDIN !!! ");

                }
                while (genre.Length < 3 || genre.Length > 20)
                {
                    Console.WriteLine("Kitabin janri :   (simvo sayi 3-den 20-e kimi ola biler )");
                    genre = Console.ReadLine();
                    if (genre.Length >= 3 && genre.Length < 20)
                    {
                        break;
                    }
                    Console.WriteLine(" ZEHMET OLMASA JANIRI DUZGUN DAXIL EDIN !!!");
                }
                while (price <= 0)
                {
                    Console.WriteLine("Kitabin qiymeti : ");
                    price = Convert.ToDouble(Console.ReadLine());
                }
                while (count <= 0)
                {
                    Console.WriteLine("Kitabin sayi : ");
                    count = Convert.ToInt32(Console.ReadLine());
                }

                Book book = new Book(genre, no, price, name, count);
                books.AddBook(book);
            }
            bool y = true;
            while (y)
            {
                Console.WriteLine("Filter Olunsun ? :  y / n ");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'y')
                {
                    while (true)
                    {
                        Console.WriteLine(" 1- Janra gore , 2- Qiymet intervalina gore   1 / 2 ");
                        answer = Convert.ToChar(Console.ReadLine());
                        if (answer == '1')
                        {
                            Console.WriteLine("Axtarilacaq janiri daxil edin .");
                            string genre = Console.ReadLine();
                            books.getInfo(books.GetFilteredBooksGenre(genre));
                            y = false;
                            break;
                        }
                        else if (answer == '2')
                        {
                            Console.WriteLine("Hansi qiymet intervalinda axtarilirsa , hemin qiymtleri daxil edin . ");
                            double minprice = Convert.ToDouble(Console.ReadLine());
                            double maxprice = Convert.ToDouble(Console.ReadLine());
                            books.getInfo(books.GelFilteredBooksPrice(minprice, maxprice));
                            y = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Duzgun deyer daxil edin !!!");
                        }

                    }
                }
                else if (answer == 'n')
                {
                    books.getInfo(books.Books);
                    y = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin !!!");
                }
            }


        }

    }
                    }
}
