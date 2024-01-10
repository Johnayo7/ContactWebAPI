using ContactWebAPI.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;

namespace ContactWebAPI.SqlServer
{
    public class ContactContext : IdentityDbContext
    {
        private readonly IConfiguration _configuration;

        public ContactContext(DbContextOptions<ContactContext> contextOptions) : base(contextOptions)
        {
        }

        //public ContactContext(IConfiguration configuration)
        //{
        //    _configuration= configuration;
        //}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ContactDB"));
        //}
    }
}