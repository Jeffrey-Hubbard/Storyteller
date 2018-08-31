using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storyteller.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Need { get; set; }
        public string WhatsAtStake { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}