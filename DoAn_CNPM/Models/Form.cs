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
    
    public partial class Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Form()
        {
            this.DetailForms = new HashSet<DetailForm>();
            this.DiseaseStatisticLists = new HashSet<DiseaseStatisticList>();
        }
    
        public int FormId { get; set; }
        public Nullable<System.DateTime> ExamTime { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int StaffId { get; set; }
        public Nullable<System.DateTime> CreatedDay { get; set; }
        public string ReasonForVisit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailForm> DetailForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiseaseStatisticList> DiseaseStatisticLists { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
