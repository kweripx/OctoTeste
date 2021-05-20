using Microsoft.EntityFrameworkCore;
using OctoTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoTeste.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = Guid.NewGuid(),
                    Nome = "Renato",
                    Cpf = "371.920.561-46",
                    dataNascimento = "08/03/1995",
                    Telefone = "(27) 99345-4790",
                    tipoTelefone = "Celular",
                    Cep = "29031-843",
                    Endereco = "Rua Dezessete de Dezembro",
                    tipoEndereco = "Cobrança",
                    Numero = 872
                },
                 new Cliente
                 {
                     Id = Guid.NewGuid(),
                     Nome = "Renato",
                     Cpf = "371.920.561-46",
                     dataNascimento = "08/03/1995",
                     Telefone = "(27) 99345-4790",
                     tipoTelefone = "Celular",
                     Cep = "29031-843",
                     Endereco = "Rua Dezessete de Dezembro",
                     tipoEndereco = "Cobrança",
                     Numero = 872
                 },
                  new Cliente
                  {
                      Id = Guid.NewGuid(),
                      Nome = "Renato",
                      Cpf = "371.920.561-46",
                      dataNascimento = "08/03/1995",
                      Telefone = "(27) 99345-4790",
                      tipoTelefone = "Celular",
                      Cep = "29031-843",
                      Endereco = "Rua Dezessete de Dezembro",
                      tipoEndereco = "Cobrança",
                      Numero = 872
                  },
                   new Cliente
                   {
                       Id = Guid.NewGuid(),
                       Nome = "Renato",
                       Cpf = "371.920.561-46",
                       dataNascimento = "08/03/1995",
                       Telefone = "(27) 99345-4790",
                       tipoTelefone = "Celular",
                       Cep = "29031-843",
                       Endereco = "Rua Dezessete de Dezembro",
                       tipoEndereco = "Cobrança",
                       Numero = 872
                   },
                    new Cliente
                    {
                        Id = Guid.NewGuid(),
                        Nome = "Renato",
                        Cpf = "371.920.561-46",
                        dataNascimento = "08/03/1995",
                        Telefone = "(27) 99345-4790",
                        tipoTelefone = "Celular",
                        Cep = "29031-843",
                        Endereco = "Rua Dezessete de Dezembro",
                        tipoEndereco = "Cobrança",
                        Numero = 872
                    },
                     new Cliente
                     {
                         Id = Guid.NewGuid(),
                         Nome = "Renato",
                         Cpf = "371.920.561-46",
                         dataNascimento = "08/03/1995",
                         Telefone = "(27) 99345-4790",
                         tipoTelefone = "Celular",
                         Cep = "29031-843",
                         Endereco = "Rua Dezessete de Dezembro",
                         tipoEndereco = "Cobrança",
                         Numero = 872
                     },
                      new Cliente
                      {
                          Id = Guid.NewGuid(),
                          Nome = "Renato",
                          Cpf = "371.920.561-46",
                          dataNascimento = "08/03/1995",
                          Telefone = "(27) 99345-4790",
                          tipoTelefone = "Celular",
                          Cep = "29031-843",
                          Endereco = "Rua Dezessete de Dezembro",
                          tipoEndereco = "Cobrança",
                          Numero = 872
                      },
                       new Cliente
                       {
                           Id = Guid.NewGuid(),
                           Nome = "Renato",
                           Cpf = "371.920.561-46",
                           dataNascimento = "08/03/1995",
                           Telefone = "(27) 99345-4790",
                           tipoTelefone = "Celular",
                           Cep = "29031-843",
                           Endereco = "Rua Dezessete de Dezembro",
                           tipoEndereco = "Cobrança",
                           Numero = 872
                       },
                        new Cliente
                        {
                            Id = Guid.NewGuid(),
                            Nome = "Renato",
                            Cpf = "371.920.561-46",
                            dataNascimento = "08/03/1995",
                            Telefone = "(27) 99345-4790",
                            tipoTelefone = "Celular",
                            Cep = "29031-843",
                            Endereco = "Rua Dezessete de Dezembro",
                            tipoEndereco = "Cobrança",
                            Numero = 872
                        },
                         new Cliente
                         {
                             Id = Guid.NewGuid(),
                             Nome = "Renato",
                             Cpf = "371.920.561-46",
                             dataNascimento = "08/03/1995",
                             Telefone = "(27) 99345-4790",
                             tipoTelefone = "Celular",
                             Cep = "29031-843",
                             Endereco = "Rua Dezessete de Dezembro",
                             tipoEndereco = "Cobrança",
                             Numero = 872
                         },
                          new Cliente
                          {
                              Id = Guid.NewGuid(),
                              Nome = "Renato",
                              Cpf = "371.920.561-46",
                              dataNascimento = "08/03/1995",
                              Telefone = "(27) 99345-4790",
                              tipoTelefone = "Celular",
                              Cep = "29031-843",
                              Endereco = "Rua Dezessete de Dezembro",
                              tipoEndereco = "Cobrança",
                              Numero = 872
                          },
                           new Cliente
                           {
                               Id = Guid.NewGuid(),
                               Nome = "Renato",
                               Cpf = "371.920.561-46",
                               dataNascimento = "08/03/1995",
                               Telefone = "(27) 99345-4790",
                               tipoTelefone = "Celular",
                               Cep = "29031-843",
                               Endereco = "Rua Dezessete de Dezembro",
                               tipoEndereco = "Cobrança",
                               Numero = 872
                           }, 
                           new Cliente
                           {
                               Id = Guid.NewGuid(),
                               Nome = "Renato",
                               Cpf = "371.920.561-46",
                               dataNascimento = "08/03/1995",
                               Telefone = "(27) 99345-4790",
                               tipoTelefone = "Celular",
                               Cep = "29031-843",
                               Endereco = "Rua Dezessete de Dezembro",
                               tipoEndereco = "Cobrança",
                               Numero = 872
                           },
                            new Cliente
                            {
                                Id = Guid.NewGuid(),
                                Nome = "Renato",
                                Cpf = "371.920.561-46",
                                dataNascimento = "08/03/1995",
                                Telefone = "(27) 99345-4790",
                                tipoTelefone = "Celular",
                                Cep = "29031-843",
                                Endereco = "Rua Dezessete de Dezembro",
                                tipoEndereco = "Cobrança",
                                Numero = 872
                            },
                             new Cliente
                             {
                                 Id = Guid.NewGuid(),
                                 Nome = "Renato",
                                 Cpf = "371.920.561-46",
                                 dataNascimento = "08/03/1995",
                                 Telefone = "(27) 99345-4790",
                                 tipoTelefone = "Celular",
                                 Cep = "29031-843",
                                 Endereco = "Rua Dezessete de Dezembro",
                                 tipoEndereco = "Cobrança",
                                 Numero = 872
                             },
                              new Cliente
                              {
                                  Id = Guid.NewGuid(),
                                  Nome = "Renato",
                                  Cpf = "371.920.561-46",
                                  dataNascimento = "08/03/1995",
                                  Telefone = "(27) 99345-4790",
                                  tipoTelefone = "Celular",
                                  Cep = "29031-843",
                                  Endereco = "Rua Dezessete de Dezembro",
                                  tipoEndereco = "Cobrança",
                                  Numero = 872
                              },
                               new Cliente
                               {
                                   Id = Guid.NewGuid(),
                                   Nome = "Renato",
                                   Cpf = "371.920.561-46",
                                   dataNascimento = "08/03/1995",
                                   Telefone = "(27) 99345-4790",
                                   tipoTelefone = "Celular",
                                   Cep = "29031-843",
                                   Endereco = "Rua Dezessete de Dezembro",
                                   tipoEndereco = "Cobrança",
                                   Numero = 872
                               },
                                new Cliente
                                {
                                    Id = Guid.NewGuid(),
                                    Nome = "Renato",
                                    Cpf = "371.920.561-46",
                                    dataNascimento = "08/03/1995",
                                    Telefone = "(27) 99345-4790",
                                    tipoTelefone = "Celular",
                                    Cep = "29031-843",
                                    Endereco = "Rua Dezessete de Dezembro",
                                    tipoEndereco = "Cobrança",
                                    Numero = 872
                                },
                                 new Cliente
                                 {
                                     Id = Guid.NewGuid(),
                                     Nome = "Renato",
                                     Cpf = "371.920.561-46",
                                     dataNascimento = "08/03/1995",
                                     Telefone = "(27) 99345-4790",
                                     tipoTelefone = "Celular",
                                     Cep = "29031-843",
                                     Endereco = "Rua Dezessete de Dezembro",
                                     tipoEndereco = "Cobrança",
                                     Numero = 872
                                 },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  },
                                   new Cliente
                                   {
                                       Id = Guid.NewGuid(),
                                       Nome = "Renato",
                                       Cpf = "371.920.561-46",
                                       dataNascimento = "08/03/1995",
                                       Telefone = "(27) 99345-4790",
                                       tipoTelefone = "Celular",
                                       Cep = "29031-843",
                                       Endereco = "Rua Dezessete de Dezembro",
                                       tipoEndereco = "Cobrança",
                                       Numero = 872
                                   },
                                  new Cliente
                                  {
                                      Id = Guid.NewGuid(),
                                      Nome = "Renato",
                                      Cpf = "371.920.561-46",
                                      dataNascimento = "08/03/1995",
                                      Telefone = "(27) 99345-4790",
                                      tipoTelefone = "Celular",
                                      Cep = "29031-843",
                                      Endereco = "Rua Dezessete de Dezembro",
                                      tipoEndereco = "Cobrança",
                                      Numero = 872
                                  }

                );
        }

    }
}


