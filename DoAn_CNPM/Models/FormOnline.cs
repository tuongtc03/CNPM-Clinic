//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormOnline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormOnline()
        {
            this.DetailForms = new HashSet<DetailForm>();
        }
    
        public int FOId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string ExamSession { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public string ReasonForVisit { get; set; }
        public Nullable<System.DateTime> CreatedDay { get; set; }
        public string DOBFormatted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailForm> DetailForms { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}