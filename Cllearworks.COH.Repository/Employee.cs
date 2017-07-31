//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cllearworks.COH.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Attendances = new HashSet<Attendance>();
            this.HolidayDetails = new HashSet<HolidayDetail>();
            this.Leaves = new HashSet<Leave>();
            this.Leaves1 = new HashSet<Leave>();
            this.ShiftEmployeeHistories = new HashSet<ShiftEmployeeHistory>();
        }
    
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string GmcId { get; set; }
        public string ApnId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> FailedLoginAttemptCount { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> PlaceId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string EmployeeCode { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
        public int Status { get; set; }
        public string ImagePath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Client Client { get; set; }
        public virtual Department Department { get; set; }
        public virtual User User { get; set; }
        public virtual Place Place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayDetail> HolidayDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave> Leaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave> Leaves1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftEmployeeHistory> ShiftEmployeeHistories { get; set; }
    }
}