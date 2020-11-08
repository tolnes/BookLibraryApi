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
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<Book> Get([FromRoute] Guid id)
        {
            return await _bookService.GetBook(id.ToString());
        }

        [HttpGet]
        public async Task<List<Book>> GetAll()
        {
            return await _bookService.GetAllBooks();
        }

    }
}
