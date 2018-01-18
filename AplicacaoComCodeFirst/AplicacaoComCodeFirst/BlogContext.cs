using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class BlogContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public BlogContext() : base("name=BlogContext")
    {
        Database.Connection.ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=BlogBDLivro; Integrated Security=SSPI";
    }

    public System.Data.Entity.DbSet<AplicacaoComCodeFirst.Models.Categorias> Categorias { get; set; }

    public System.Data.Entity.DbSet<AplicacaoComCodeFirst.Models.Posts> Posts { get; set; }
}
