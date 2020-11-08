using BookLibraryApi.Models;
using BookLibraryApi.Services;
using BookLibraryApi.Utils;
using Dapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]

    public class BookController : ControllerBase
    {
        private readonly IDapper _dapper;
        public BookController(IDapper dapper)
        {
            _dapper = dapper;
        }

        [HttpGet(nameof(GetById))]
        public async Task<Book> GetById(string Id)
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
            //var result = await Task.FromResult(_dapper.Get<Book>($"Select * from '[Books]' where Id = '{Id}'", null, commandType: CommandType.Text));
            //return result;
        }
    }
}
