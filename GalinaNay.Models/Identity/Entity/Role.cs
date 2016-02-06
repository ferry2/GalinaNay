using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GalinaNay.Models.Identity.Entity
{
	[Table(nameof(Role))]
	public class Role : IdentityRole<int>
    {
    }
}
