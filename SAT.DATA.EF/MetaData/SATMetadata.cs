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
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        public int SSID { get; set; }
    }
    [MetadataType(typeof(StudentsMetadata))]
    public partial class Students { }
    #endregion

    #region StudentStatuses
    public class StudentStatusesMetadata
    {
        public int SSID { get; set; }
        public string SSName { get; set; }
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusesMetadata))]
    public partial class StudentStatuses { }
    #endregion

    #region Enrollments
    public class EnrollmentsMetadata
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        public System.DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentsMetadata))]
    public partial class Enrollments { }
    #endregion

    #region ScheduledClasses
    public class ScheduledClassesMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string InstuctorName { get; set; }
        public string Location { get; set; }
        public int SCSID { get; set; }
    }
    [MetadataType(typeof(ScheduledClassesMetadata))]
    public partial class ScheduledClasses { }
    #endregion

    #region ScheduledClassStatus
    public class ScheduledClassStatusMetadata
    {
        public int SCISD { get; set; }
        public string SCSName { get; set; }

    }
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
    #endregion

    #region Courses
    public class CoursesMetadata
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public byte CreditHours { get; set; }
        public string Curriculum { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }

    }
    [MetadataType(typeof(CoursesMetadata))]
    public partial class Courses { }
    #endregion

}
