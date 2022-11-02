using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Metadata
{
    public class CourseMetadata
    {        
           
        public int CourseId { get; set; }


        [Required(ErrorMessage = "*Course is required")]
        [StringLength(50, ErrorMessage = "*Must be 50 characters or less")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;


        [Required(ErrorMessage = "*Course Description is required")]
        [StringLength(int.MaxValue, ErrorMessage = "*Must be 50 characters or less")]
        [Display(Name = "OCourse Description")]
        public string CourseDescription { get; set; } = null!;


        [Required(ErrorMessage = "*# of Credit Hours is required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }


        [StringLength(250, ErrorMessage = "*Must be 250 characters or less")]
        [Display(Name = "Curriculum")]
        public string? Curriculum { get; set; }


        [StringLength(500, ErrorMessage = "*Must be 500 characters or less")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }


        [Required(ErrorMessage = "*IsActive is required")]
        [Display(Name = "Is ACtive?")]
        public bool IsActive { get; set; }

                    
    }


    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }


        public int StudentId { get; set; }


        public int ScheduledClassId { get; set; }


        [Required(ErrorMessage = "*Enrollment Date is required")]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }      

    }


    public class ScheduledClassMetadata
    {
       

        public int ScheduledClassId { get; set; }


        public int CourseId { get; set; }



        [Required(ErrorMessage = "*Start Date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "*End Date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


        [Required(ErrorMessage = "*Instructor Name is required")]
        [StringLength(40, ErrorMessage = "*Must be 40 characters or less")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; } = null!;


        [Required(ErrorMessage = "*Location is required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characters or less")]
        [Display(Name = "Location")]
        public string Location { get; set; } = null!;

        public int Scsid { get; set; }
    }


    public class ScheduledClassStatusMetadata
    {
        
        public int Scsid { get; set; }


        [Required(ErrorMessage = "*SCS Name is required")]
        [StringLength(30, ErrorMessage = "*Must be 30 characters or less")]
        [Display(Name = "Scheduled Class Status")]
        public string Scsname { get; set; } = null!;

        
    }


    public class StudentMetadata
    {
        
        public int StudentId { get; set; }


        [Required(ErrorMessage = "*First is required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characters or less")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "*Last is required")]
        [StringLength(20, ErrorMessage = "*Must be 20 characters or less")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;


        [StringLength(15, ErrorMessage = "*Must be 15 characters or less")]
        [Display(Name = "Current Major")]
        public string? Major { get; set; }


        [StringLength(50, ErrorMessage = "*Must be 50 characters or less")]
        [Display(Name = "Address")]
        public string? Address { get; set; }


        [StringLength(25, ErrorMessage = "*Must be 25 characters or less")]
        [Display(Name = "City")]
        public string? City { get; set; }


        [StringLength(2, ErrorMessage = "*Must be 2 characters or less")]
        [Display(Name = "State")]
        public string? State { get; set; }


        [StringLength(10, ErrorMessage = "*Must be 10 characters or less")]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }


        [StringLength(13, ErrorMessage = "*Must be 13 characters or less")]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }


        [StringLength(60, ErrorMessage = "*Must be 60 characters or less")]
        [Required(ErrorMessage = "*Email is required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = null!;


        [StringLength(50, ErrorMessage = "*Must be 50 characters or less")]
        [Display(Name = "Photo URL")]
        public string? PhotoUrl { get; set; }


        public int Ssid { get; set; }

    }


    public class StudentStatusMetadata
    {
        
        public int Ssid { get; set; }

        [Required(ErrorMessage = "*SS Name is required")]
        [StringLength(30, ErrorMessage = "*Must be 30 characters or less")]
        [Display(Name = "Student Status")]
        public string Ssname { get; set; } = null!;


        [StringLength(250, ErrorMessage = "*Must be 250 characters or less")]
        [Display(Name = "Student Status Description")]
        public string? Ssdescription { get; set; }
      
    }
}
