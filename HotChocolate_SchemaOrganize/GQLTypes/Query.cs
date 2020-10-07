using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate.Types;

namespace HotChocolate_SchemaOrganize
{
    public class Query
    {
        public PointOfSale PointOfSale => new PointOfSale();
        public BookLibrary Library => new BookLibrary();
    }

    [Display(Name="PointOfSale", Description = "Point of Sale functionality")]
    public class PointOfSale
    {
        [Display(Description = "Transactions for customer")]
        public IReadOnlyList<Transaction> TransactionsForCustomerId(int id)
        {
            return new List<Transaction>();
        }

        [Display(Description = "Transaction by id")]
        public Transaction Transaction(int id)
        {
            return new Transaction();
        }
    }

    [Display(Name="BookLibrary", Description = "Book library related functionality")]
    public class BookLibrary
    {
        [Display(Description = "Search Books with querystring")]
        public IReadOnlyList<Book> SearchBooks(string search)
        {
            return new List<Book>();
        }
        [Display(Description = "Books belonging to specified genre")]
        public IReadOnlyList<Book> BooksForGenre(string genre)
        {
            return new List<Book>();
        }

        [Display(Description = "Book for corresponding id")]
        public Book Book(int id)
        {
            return new Book();
        }

        [Display(Description = "Book for corresponding ISBN")]
        public Book BookByISBN(int isbn)
        {
            return new Book();
        }
    }

    [Display(Description = "Commerce Transaction")]
    public class Transaction
    {
        // if you dont want to expose custom name or description, need no additional markup
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
    }

    [Display(Description = "Book information")]
    public class Book
    {
        public string name => Guid.NewGuid().ToString();
    }
}