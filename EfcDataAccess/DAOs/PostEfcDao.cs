using Application.DAOInterfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace EfcDataAccess.DAOs;

public class PostEfcDao : IPostDao
{
    private readonly PostContext context;

    public PostEfcDao(PostContext context)
    {
        this.context = context;
    }

    public async Task<Post> CreatePostAsync(Post post)
    {
        await context.Posts.AddAsync(post);
        await context.SaveChangesAsync();
        return post;
    }

    public async Task<Post?> GetPostByIdAsync(int id)
    {
        var post = await context.Posts
            .Include(posts => posts.user)
            .FirstOrDefaultAsync(p => p.postId == id);
        return post;
    }

    public async Task<IEnumerable<Post>> GetAllPosts()
    {
        
        IEnumerable<Post> posts = await context.Posts.
            Include(posts => posts.user).ToListAsync();

        return posts;
    }
}