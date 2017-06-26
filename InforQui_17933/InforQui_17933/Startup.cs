using System;
using Owin;
using InforQui_17933.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace InforQui_17933
{
    //
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //invocaçã de um método que vai configurar e criar as Roles e os primeiros Utilizadoes
            iniciaAplicacao();
        }


        /// <summary>
        /// cria, caso não existam, as Roles de suporte à aplicação: Veterinario, Funcionario, Dono
        /// cria, nesse caso, também, um utilizador...
        /// </summary>
        private void iniciaAplicacao()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // criar a Role 'Administrador'
            if (!roleManager.RoleExists("Administrador"))
            {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Administrador";
                roleManager.Create(role);

                // criar o utilizador 'Santos Pires'
                var user = new ApplicationUser();
                user.UserName = "santospires@hotmail.com";
                user.Email = "santospires@hotmail.com";
                //user.UserName = "Santos Pires";
                string userPWD = "1990Daucua.";
                var chkUser = userManager.Create(user, userPWD);

                //Adicionar o Utilizador à respetiva Role-Administrador-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Administrador");
                }
                //-------------------------------------------------------------------------
                // criar o utilizador 'Andre Quintão'
                var user1 = new ApplicationUser();
                user1.UserName = "andrequintao99@yahoo.com";
                user1.Email = "andrequintao99@yahoo.com";
                //user.UserName = "Andre Quintão";
                string userPWD1 = "1990Daucua.";
                var chkUser1 = userManager.Create(user1, userPWD1);

                //Adicionar o Utilizador à respetiva Role-Administrador-
                if (chkUser1.Succeeded)
                {
                    var result1 = userManager.AddToRole(user1.Id, "Administrador");
                }
            }

            // Criar a role 'Funcionario'
            if (!roleManager.RoleExists("Funcionario"))
            {
                var role = new IdentityRole();
                role.Name = "Funcionario";
                roleManager.Create(role);

                // criar o utilizador 'Manuel Pinto Sousa'
                var user = new ApplicationUser();
                user.UserName = "manuel1982@hotmail.com";
                user.Email = "manuel1982@hotmail.com";
                //user.UserName = "Manuel Pinto Sousa";
                string userPWD = "1990Daucua.";
                var chkUser = userManager.Create(user, userPWD);

                //Adicionar o Utilizador à respetiva Role-Funcionario-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Funcionario");
                }

                //-------------------------------------------------------------
                // criar o utilizador 'Mariano Freitas'
                var user1 = new ApplicationUser();
                user1.UserName = "freitasmariano90@gmail.com";
                user1.Email = "freitasmariano90@gmail.com";
                //user.UserName = "Mariano Freitas";
                string userPWD1 = "1990Daucua.";
                var chkUser1 = userManager.Create(user1, userPWD1);

                //Adicionar o Utilizador à respetiva Role-Funcionario-
                if (chkUser1.Succeeded)
                {
                    var result1 = userManager.AddToRole(user1.Id, "Funcionario");
                }

            }

            // Criar a role 'Cliente'
            if (!roleManager.RoleExists("Cliente"))
            {
                var role = new IdentityRole();
                role.Name = "Cliente";
                roleManager.Create(role);

                // criar o utilizador 'Mario Suares'
                var user = new ApplicationUser();
                user.UserName = "suares1985@gmail.com";
                user.Email = "suares1985@gmail.com";
                //user.UserName = "Mario Suares";
                string userPWD = "1990Daucua.";
                var chkUser = userManager.Create(user, userPWD);

                //Adicionar o Utilizador à respetiva Role-Cliente-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Cliente");
                }

                // criar o utilizador 'Martinho Gusmão'
                var user1 = new ApplicationUser();
                user1.UserName = "gusmao1979@hotmail.com";
                user1.Email = "gusmao1979@hotmail.com";
                //user.Name = "Martinho Gusmão";
                string userPWD1 = "1990Daucua.";
                var chkUser1 = userManager.Create(user1, userPWD1);

                //Adicionar o Utilizador à respetiva Role-Cliente-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user1.Id, "Cliente");
                }

                // criar o utilizador 'Rosito Belo Martins'
                var user3 = new ApplicationUser();
                user3.UserName = "rositobelo@yahoo.com";
                user3.Email = "rositobelo@yahoo.com";
                //user.Name = "Rosito Belo Martins";
                string userPWD3 = "1990Daucua.";
                var chkUser3 = userManager.Create(user3, userPWD3);

                //Adicionar o Utilizador à respetiva Role-Cliente-
                if (chkUser3.Succeeded)
                {
                    var result1 = userManager.AddToRole(user3.Id, "Cliente");
                }
            }

            // https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97
        }



    }

}
