using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InforQui_17933.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        //***********************************************************************
        //      Os dados do utilizador que está a referenciar a classe 'registo'
        //***********************************************************************

        //O Nome do utilizador
        
        public string Nome { get; set; }

        public string Morada { get; set; }

        public string CodPostal { get; set; }

        public int NIF { get; set; }

        public string Contacto { get; set; }

        public string Imagem { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //representar a Base de Dados descrevendo as tabelas que lá estão contidas

    //representar o 'construtor' desta classe
    //identifica onde se encontra a base de dados

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("InforQuiDBConnection", throwIfV1Schema: false)
        {
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }


        //Classe Create vai criar as tabelas para o modelo (base de dados) ApplicationDBContext
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        } //fim da classe Create

        //descrever as tabelas que estão na base de dados

        //tabela de Utilizadores
        public virtual DbSet<Utilizadores> Utilizadores { get; set; }
        //tabela de Produtos
        public virtual DbSet<Produtos> Produtos { get; set; }
        //tabela de Compras_Produtos
        public virtual DbSet<Compras_Produtos> Compras_Produtos { get; set; }
        //tabela de Compras
        public virtual DbSet<Compras> Compras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // não podemos usar a chave seguinte, nesta geração de tabelas
            // por causa das tabelas do Identity (gestão de utilizadores)
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}