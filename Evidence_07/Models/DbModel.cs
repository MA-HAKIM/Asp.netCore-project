using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence_07.Models
{
    public class Course
    {
        public Course()
        {
            this.Trainees = new List<Trainee>();
        }
        public int CourseId { get; set; }
        [Required, StringLength(40), Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Required]
        public int Round { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
    public class Trainee
    {
        public int TraineeId { get; set; }
        [Required, StringLength(40), Display(Name = "Trainee Name")]
        public string TraineeName { get; set; }
        [StringLength(400)]
        public string Picture { get; set; }
        [Required, StringLength(40)]
        public string Email { get; set; }
        [Required, StringLength(30), Display(Name = "Training Location")]
        public string TLocation { get; set; }
        [Required, ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
    public class TraineeCourseDbContext : DbContext
    {
        public TraineeCourseDbContext(DbContextOptions<TraineeCourseDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
    }
}
