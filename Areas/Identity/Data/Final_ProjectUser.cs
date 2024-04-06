using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Final_Project.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Final_ProjectUser class
public class Final_ProjectUser : IdentityUser
{

    [PersonalData]
    [Column(TypeName ="nvarchar(100)")]
    public string Name{ get; set; }
}

