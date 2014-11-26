﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? Published { get; set; }


        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
