﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public abstract class Character
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Title { get; set; }


        [StringLength(50)]
        [Display(Name = "Race")]
        public string Race { get; set; }
        public string Class { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
        public string Description { get; set; }

    }
}