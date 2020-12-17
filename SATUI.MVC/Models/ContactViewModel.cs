using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SATUI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is requred.")]
        [StringLength(250, ErrorMessage = "Message cannot exceed 250 characters.")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}