using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InforQui_17933.Models
{
        //o DbContext é a superclasse do entity

        public class InforQuiDB : DbContext
        {
            //representar a Base de Dados descrevendo as tabelas que lá estão contidas

            //representar o 'construtor' desta classe
            //identifica onde se encontra a base de dados
            public InforQuiDB() : base("InforQuiDBConnection") { }

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
