using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trakify.Domain.Entities
{
    class BasicFeedbackSystem
    {
        [Key]
        public int Id { get; set; }
        public int FeedBackType { get; set; }
    }
}
