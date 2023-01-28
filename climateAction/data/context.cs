using climateAction.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class context: IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration configuration;
        public context(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Question> questions { set; get; }
        public DbSet<QuestionCategory> questionCategories { set; get; }
        public DbSet<Answers> Answers { set; get; }
        public DbSet<Assessments> assessments { set; get; }
        public DbSet<Directorates> directorates { set; get; }
        public DbSet<Domains> domains { set; get; }
        public DbSet<Facility_Type> facility_Types { set; get; }
        public DbSet<Facilities> facilities { set; get; }
        public DbSet<FacilityGeneralInfo> facilityGeneralInfos { set; get; }
        public DbSet<Governorates> governorates { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ClimateConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
