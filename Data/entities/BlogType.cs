﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entities
{
    public class BlogType:BaseType
    {
        public BlogType() { 
        Blogs=new List<Blog>();
        }
        public List<Blog> Blogs { get; set; }
    }
}
