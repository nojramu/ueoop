using Microsoft.EntityFrameworkCore;
using Serverample.Data;
using System.Security.Cryptography;
using System.Text;

namespace Serverample.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUserAsync(string username, string email, string password)
        {
            try
            {
                // Check if username or email already exists
                var existingUser = await _context.Users
                    .FirstOrDefaultAsync(u => u.Username == username || u.Email == email);
                
                if (existingUser != null)
                {
                    return false; // User already exists
                }

                // Hash the password
                var passwordHash = HashPassword(password);

                // Create new user
                var user = new User
                {
                    Username = username,
                    Email = email,
                    PasswordHash = passwordHash,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering user: {ex.Message}");
                return false;
            }
        }

        public async Task<User?> LoginUserAsync(string username, string password)
        {
            try
            {
                // Find user by username
                var user = await _context.Users
                    .FirstOrDefaultAsync(u => u.Username == username && u.IsActive);

                if (user == null)
                {
                    return null; // User not found
                }

                // Verify password
                if (VerifyPassword(password, user.PasswordHash))
                {
                    return user;
                }

                return null; // Invalid password
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during login: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UserExistsAsync(string username, string email)
        {
            return await _context.Users
                .AnyAsync(u => u.Username == username || u.Email == email);
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "salt123")); // Simple salt
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            var hashOfInput = HashPassword(password);
            return hashOfInput == hashedPassword;
        }
    }
}