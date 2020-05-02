using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Trakify.Domain.Entities;

namespace Trakify.Domain
{
   public class TrakifyContext : DbContext
    {
        public readonly string _connectionString;


        public TrakifyContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            if (!optionsBuilder.IsConfigured)
            {
                var directory = Directory.GetCurrentDirectory().ToString();
                var path = Path.Combine(Directory.GetParent(directory).ToString(), "Trakify-Server/appsettings.json");
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile(path, false)
                   .Build();
                var connectionString = configuration.GetSection("ConnectionString").GetSection("Trakify").Value;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


       
        public DbSet<Trakify_AddressDetails> Trakify_Address { get; set; }
        public DbSet<Trakify_Assets> Trakify_Assets { get; set; }
        public DbSet<Trakify_BillToAddressDetails> Trakify_BillToAddress { get; set; }
        public DbSet<Trakify_Client> Trakify_Clients { get; set; }
        public DbSet<Trakify_Code> Trakify_Codes { get; set; }
        public DbSet<Trakify_ContactDetails> Trakify_ContactDetails { get; set; }
        public DbSet<Trakify_Contracts> Trakify_Contracts { get; set; }
        public DbSet<Trakify_ContractType> Trakify_ContractTypes { get; set; }
        public DbSet<Trakify_Country> Trakify_Countries { get; set; }
        public DbSet<Trakify_Documents> Trakify_Documents { get; set; }
        public DbSet<Trakify_Job> Trakify_Jobs { get; set; }
        public DbSet<Trakify_PaymentTerms> Trakify_PaymentTerms { get; set; }
        public DbSet<Trakify_Role> Trakify_Roles { get; set; }
        public DbSet<Trakify_State> Trakify_States { get; set; }
        public DbSet<Trakify_TaxCode> Trakify_TaxCodes { get; set; }
        public DbSet<Trakify_Employee> Trakify_Employees { get; set; }
        public DbSet<Trakify_User> Trakify_Users { get; set; }
        public DbSet<Trakify_WorkOrderType> Trakify_WorkOrderTypes { get; set; }
        public DbSet<Trakify_Projects> Trakify_Projects { get; set; }
        public DbSet<Trakify_AssetsService> Trakify_Services { get; set; }
        public DbSet<Trakify_Part> Trakify_Parts { get; set; }
        public DbSet<Trakify_BasicSettings> Trakify_BasicSettings { get; set; }
        public DbSet<Trakify_Currency> Trakify_Currency { get; set; }
        public DbSet<Trakify_DateFormat> Trakify_DateFormat { get; set; }
        public DbSet<Trakify_PartCategory> Trakify_PartCategory { get; set; }
        public DbSet<Trakify_TImeZone> Trakify_TImeZone { get; set; }
        public DbSet<Trakify_Vendors> Trakify_Vendors { get; set; }
        public DbSet<Trakify_PartVendors> Trakify_PartVendors { get; set; }


        //public DbSet<Country> Countries { get; set; }



        //public DbSet<ContactDetails> Contact { get; set; }
        //public DbSet<Job> Job { get; set; }

    }
}
