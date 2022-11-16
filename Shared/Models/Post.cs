using System.Text.Json;

namespace Shared.Models;

public class Post
{
    public User user { get; set; }
    public String title { get; set; }
    public String body { get; set; }
    public int postId { get; set; }

    public Post(User user, string title, string body)
    {
        this.user = user;
        this.title = title;
        this.body = body;
    }
    
    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
    
    private Post() {}
    
    
}