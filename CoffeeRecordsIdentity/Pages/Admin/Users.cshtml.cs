using CoffeeRecordsIdentity.Data;
using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoffeeRecordsIdentity.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class UsersModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<ApplicationUser> Users { get; set; }

        public UsersModel(ApplicationDbContext context) => _context = context;

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}
