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

            // criar a Role 'Veterinario'
            if (!roleManager.RoleExists("Veterinario"))
            {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Veterinario";
                roleManager.Create(role);
            }

            // Criar a role 'Funcionario'
            if (!roleManager.RoleExists("Funcionario"))
            {
                var role = new IdentityRole();
                role.Name = "Funcionario";
                roleManager.Create(role);

                // criar um utilizador 'Funcionario'
                var user = new ApplicationUser();
                user.UserName = "c@a.cc";
                user.Email = "c@c.cc";
                //user.UserName = "Luís Freitas";
                string userPWD = "123_Asd";
                var chkUser = userManager.Create(user, userPWD);

                //Adicionar o Utilizador à respetiva Role-Funcionario-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Funcionario");
                }

            }

            // Criar a role 'Dono'
            if (!roleManager.RoleExists("Dono"))
            {
                var role = new IdentityRole();
                role.Name = "Dono";
                roleManager.Create(role);

                // criar um utilizador 'Funcionario'
                var user = new ApplicationUser();
                user.UserName = "a@a.aa";
                user.Email = "a@a.aa";
                //user.UserName = "Luís Freitas";
                string userPWD = "123_Asd";
                var chkUser = userManager.Create(user, userPWD);

                //Adicionar o Utilizador à respetiva Role-Funcionario-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Dono");
                }


                // criar um utilizador 'Dono'
                var user1 = new ApplicationUser();
                user1.UserName = "b@b.bb";
                user1.Email = "b@b.bb";
                //user.Name = "Luís Freitas";
                string userPWD1 = "123_Asd";
                var chkUser1 = userManager.Create(user1, userPWD1);

                //Adicionar o Utilizador à respetiva Role-Dono-
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user1.Id, "Dono");
                }
            }

            // https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97
        }



    }

}
