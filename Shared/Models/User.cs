using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class User
{
    [MinLength(5)]
    public String? userName { get; set; }
    
    public String? password { get; set; }
    


    public User()
    {
        
    }

    public User(string? userName, string? password)
    {
        this.userName = userName;
        this.password = password;
    }
}