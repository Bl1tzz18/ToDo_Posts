using Application.DAOInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shared.DTOs;
using Shared.Models;

namespace EfcDataAccess.DAOs;

public class UserEfcDao : IUserDao
{
    private readonly PostContext context;
    
    public UserEfcDao(PostContext context)
    {
        this.context = context;
    }
    public async Task<UserCreationDTO> CreateUser(User user)
    {
        EntityEntry<User> createUser = await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        
        UserCreationDTO userToSend = new UserCreationDTO(createUser.Entity.userName);
        return userToSend;
    }

    public async Task<User?> GetByUsername(string username)
    {
        User? existing = await context.Users.FirstOrDefaultAsync(u =>
            u.userName.ToLower().Equals(username.ToLower())
        );
        return existing;
    }
}