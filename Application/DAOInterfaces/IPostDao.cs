﻿using Shared.DTOs;
using Shared.Models;

namespace Application.DAOInterfaces;

public interface IPostDao
{
    Task<Post> CreatePostAsync(Post post);
    Task<Post?> GetPostByIdAsync(int id);
    Task<IEnumerable<Post>> GetAllPosts();

    
}