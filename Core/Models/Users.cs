namespace first_blazor_app.Core.Models.Users;

public class User
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Profile { get; set; }

	public User(string id, 
		string userName, 
		string profile)
	{
		Id = id;
		UserName = userName;
		Profile = profile;
	}
}
