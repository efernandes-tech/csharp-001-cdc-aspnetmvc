﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            Database.Connection.ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=BlogBDLivro; Integrated Security=SSPI";
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public Database Database { get; }
    }
}
