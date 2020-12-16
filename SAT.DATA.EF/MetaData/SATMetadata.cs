using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.MetaData
{
    #region Students
    public class StudentsMetadata
    {

        //public int StudentID { get; set; }
        [Required(ErrorMessage = "First name required")]
        [Display(Name ="First Name")]
        [StringLength(20, ErrorMessage ="First name can not exceed 20 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "Last name can not exceed 20 characters")]
        public string LastName { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(15,ErrorMessage ="Major can not exceed 15 charactes")]
        public string Major { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(50, ErrorMessage = "Address can not exceed 50 charactes")]
        public string Address { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(25, ErrorMessage = "City can not exceed 25 charactes")]
        public string City { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(2, ErrorMessage = "State can not exceed 2 charactes")]
        public string State { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(10, ErrorMessage = "Zip Code can not exceed 10 charactes")]
        public string ZipCode { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(13, ErrorMessage = "Phone can not exceed 13 charactes")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email required")]
        [StringLength(60, ErrorMessage = "Email can not exceed 60 charactes")]
        public string Email { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100, ErrorMessage = "PhotoURL can not exceed 100 charactes")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "SSID required")]
        public int SSID { get; set; }
    }
    [MetadataType(typeof(StudentsMetadata))]
    public partial class Students { }
    #endregion

    #region StudentStatuses
    public class StudentStatusesMetadata
    {
        //public int SSID { get; set; }

        [Required(ErrorMessage = "SSName required")]
        [Display(Name = "Student Status Name")]
        [StringLength(30, ErrorMessage = "SSName can not exceed 30 characters")]
        public string SSName { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Student Status description")]
        [StringLength(250, ErrorMessage = "Description can not exceed 250 characters")]
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusesMetadata))]
    public partial class StudentStatuses { }
    #endregion

    #region Enrollments
    public class EnrollmentsMetadata
    {
        //public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "Student ID required")]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Student Class ID required")]
        [Display(Name = "Student Class ID")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Enrollment Date required")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public System.DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollments { }
    #endregion

    #region ScheduledClasses
    public class ScheduledClassesMetadata
    {
        //public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Course ID required")]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date required")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date required")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime EndDate { get; set; }

        [Display(Name = "Instructor")]
        [StringLength(40, ErrorMessage = "Instructor name can not exceed 40 characters")]
        public string InstuctorName { get; set; }

        [Display(Name = "Location")]
        [StringLength(20, ErrorMessage = "Location can not exceed 20 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "SCSID required")]
        public int SCSID { get; set; }
    }
    [MetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClasses { }
    #endregion

    #region ScheduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        //public int SCISD { get; set; }

        [Required(ErrorMessage = "Scheduled Class Status name required")]
        [Display(Name = "Scheduled Class Status")]
        public string SCSName { get; set; }

    }
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion

    #region Courses
    public class CoursesMetadata
    {
        //public int CourseId { get; set; }

        [Required(ErrorMessage = "Course name required")]
        [Display(Name = "Course")]
        [StringLength(50, ErrorMessage = "Course can not exceed 50 characters")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Description required")]
        [Display(Name = "Description")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Credit Hours required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Cirruculum cannot exceed 250 characters.")]
        [DisplayFormat(NullDisplayText ="[N/A]")]
        public string Curriculum { get; set; }

        [StringLength(500, ErrorMessage ="Notes cannot exceed 500 characters.")]
        [DisplayFormat(NullDisplayText ="[N/A]")]
        public string Notes { get; set; }

        [Required(ErrorMessage ="Activity required")]
        public bool IsActive { get; set; }

    }
    [MetadataType(typeof(CoursesMetadata))]
    public partial class Courses { }
    #endregion

}
