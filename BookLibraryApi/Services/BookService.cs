using BookLibraryApi.Models;
using BookLibraryApi.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Services
{
    public class BookService : IBookService
    {
        public async Task<Book> GetBook(string Id)
        {
            var result = new Book();

            using (var cn = new SqlConnection(Settings.GetConnectionString("BookLibrary")))
            {
                cn.Open();
                var sql = $@"SELECT *
                             FROM [Books]
                             WHERE [Id] = @Id";

                result = cn.Query<Book>(sql, new { Id }).FirstOrDefault();
            }

            return result;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var result = new List<Book>();

            using (var cn = new SqlConnection(Settings.GetConnectionString("BookLibrary")))
            {
                cn.Open();
                var sql = $@"SELECT *
                             FROM [Books]";

                result = cn.Query<Book>(sql).ToList();
            }

            return result;
        }
    }
}
