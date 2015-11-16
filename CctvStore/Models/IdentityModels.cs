using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace CctvStore.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<CctvStore.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SubCategory> SubCategories { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.ProductProperty> ProductProperties { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.Catalog> Catalogs { get; set; }
        public DbSet<Upload> Uploads { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.Specification> Specifications { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpCamera> SpCameras { get; set; }
        public System.Data.Entity.DbSet<CctvStore.Models.SpImage> SpImages { get; set; }
        public System.Data.Entity.DbSet<CctvStore.Models.SpNetwork> SpNetworks { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.Accessories> Accessories { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpInterface> SpInterfaces { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpGeneral> SpGenerals { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpVideo> SpVideos { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpAudio> SpAudios { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpHardDisk> SpHardDisks { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpRecordPlayback> SpRecordPlaybacks { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpVideoAudioInput> SpVideoAudioInputs { get; set; }

        public System.Data.Entity.DbSet<CctvStore.Models.SpVideoAudioOutput> SpVideoAudioOutputs { get; set; }
    }
}