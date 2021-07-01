using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool2.Models
{
    [Table("Course")]
    public partial class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        [StringLength(128)]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        [Required]

        public DateTime DateTime { get; set; }
        public Category Category { get; set; }

        [Required]

        public int CategoryId { get; set; }

        public String Name;




        public List<Category> ListCategory = new List<Category>();
    }

}