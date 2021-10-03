using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models
{
    [Table("POSTS")]
    public class Post : IModelBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Body { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        [InverseProperty("Posts")]
        public User User { get; set; }


        /*[ForeignKey("RUser")]
        public int RUserId { get; set; }
        [InverseProperty("RPosts")]
        public User RUser { get; set; }*/
    }
}
