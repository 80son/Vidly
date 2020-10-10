using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
<<<<<<< HEAD

        public bool IsSubscribedToNewsletter { get; set; }

        public DateTime? Birthday { get; set; }

=======
        public bool IsSubscribedToNewsLetter { get; set; }
>>>>>>> 2c041b800ef3e43a0c1cd2a9e9b63e1fdf803415
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}