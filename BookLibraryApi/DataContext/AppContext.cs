﻿using Microsoft.EntityFrameworkCore;

namespace BookLibraryApi.DataContext
{
    public class AppContext : DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
