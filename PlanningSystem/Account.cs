
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace PlanningSystem
{

using System;
    using System.Collections.Generic;
    
public partial class Account
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Account()
    {

        this.Unavailability = new HashSet<Unavailability>();

        this.Course = new HashSet<Course>();

    }


    public int userId { get; set; }

    public string username { get; set; }

    public string password { get; set; }

    public string name { get; set; }

    public int roleId { get; set; }

    public System.DateTime createdAt { get; set; }

    public bool firstLogin { get; set; }

    public bool isResetted { get; set; }

    public bool isDisabled { get; set; }



    public virtual Role Role { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Unavailability> Unavailability { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Course> Course { get; set; }

}

}
