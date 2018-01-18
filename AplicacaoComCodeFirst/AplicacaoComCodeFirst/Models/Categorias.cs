﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirst.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Posts> Posts { get; set; }
    }
}