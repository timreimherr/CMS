﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GamingGuruBlog.Data.Models
{
    public class StaticPage
    {
        public int StaticPageId { get; set; }
        public string UserId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Title can only be 100 Characters Long", MinimumLength = 1)]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please add content to Body")]
        [UIHint("tinyMCE"), AllowHtml]
        public string Body { get; set; }


    }
}
