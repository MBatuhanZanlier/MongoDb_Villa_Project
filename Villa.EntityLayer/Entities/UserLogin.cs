using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;

namespace Villa.EntityLayer.Entities
{
	public class UserLogin : IdentityUserLogin<ObjectId>
	{
	}
}
