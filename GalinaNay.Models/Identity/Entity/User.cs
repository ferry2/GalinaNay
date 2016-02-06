using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GalinaNay.Models.Identity.Entity
{
	[Table(nameof(User))]
	public class User : IdentityUser<int>
    {
    }
}
