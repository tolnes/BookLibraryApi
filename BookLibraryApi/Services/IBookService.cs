using BookLibraryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Services
{
    public interface IBookService
    {
        Task<Book> GetBook(string Id);
    }
}
