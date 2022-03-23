using System;
using System.Collections.Generic;
using System.Text;

namespace taskclass2
{
    class Library
    {
        public Book[] Books;

        int j = 0;
        public void AddBook(Book book)
        {
            Books[j++] = book;
        }
        public Book[] GetFilteredBooksGenre(string genre)
        {
            int count = 0;
            foreach (var item in Books)
            {
                if (item.genre == genre)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int h= 0;
            foreach (var item in Books)
            {
                if (item.genre == genre)
                {
                    newbooks[h++] = item;
                }
            }
            return newbooks;
        }
        public Book[] GelFilteredBooksPrice(double minprice, double maxprice)
        {
            int count = 0;
            foreach (var item in Books)
            {
                if (item.Price > minprice && item.Price < maxprice)
                {
                    count++;
                }
            }
            Book[] newbooks = new Book[count];
            int h = 0;
            foreach (var item in Books)
            {
                if (item.Price > minprice && item.Price < maxprice)
                {
                    newbooks[h++] = item;
                }
            }
            return newbooks;
        }
        public void getInfo(Book[] Books)
        {
            foreach (var item in Books)
            {
                Console.WriteLine($"Name: {item.Name}   Price: {item.Price}    Genre: {item.genre}    No: {item.No}    Count: {item.Count} ");
            }
        }
    }
}
