//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aural_Novel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Seller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seller()
        {
            this.Books = new HashSet<Book>();
        }
    
        public int sid { get; set; }
        [Required(ErrorMessage = "Enter your first name")]
        [Display(Name = "First Name")]
        public string sfname { get; set; }
        [Required(ErrorMessage = "Enter your last name")]
        [Display(Name = "Last Name")]
        public string slname { get; set; }
        [Required(ErrorMessage = "Enter your email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string semail { get; set; }
        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string spass { get; set; }
        [Required(ErrorMessage = "Enter your phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string sphone { get; set; }
        public string spic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }
        public virtual Seller Seller1 { get; set; }
        public virtual Seller Seller2 { get; set; }
    }
}
