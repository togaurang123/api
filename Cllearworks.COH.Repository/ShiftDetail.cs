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
    
    public partial class ShiftDetail
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public bool IsWorkingDay { get; set; }
        public int DayOfWeek { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<decimal> WorkingHours { get; set; }
        public Nullable<decimal> BreakHours { get; set; }
    
        public virtual Shift Shift { get; set; }
    }
}