using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Data.EntityConfig
{
    public class EntityInitializer : CreateDatabaseIfNotExists<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            context.Perfil.AddRange(
                new Collection<Perfil>
                {
                    new Perfil
                    {
                        Descricao = "Administrador", 
                        Ativo = true,
                        Usuario = new Collection<Usuario>
                        {
                            new Usuario
                            {
                                Nome = "Admin GpsMonitor",
                                Email = "admin.gps@teste.com.br",
                                Login = "admin.gps",
                                Senha = "T8BDdQokQd79jjXS4j6E8A==",
                                DataCadastro = DateTime.Now,
                                Ativo = true
                            },
                            new Usuario
                            {
                                Nome = "Aderbal Farias",
                                Email = "aderbalfarias@hotmail.com",
                                Login = "aderbal.farias",
                                Senha = "T8BDdQokQd79jjXS4j6E8A==",
                                DataCadastro = DateTime.Now,
                                Ativo = true
                            },
                            new Usuario
                            {
                                Nome = "Iran Marley",
                                Email = "iran_marley@live.com",
                                Login = "iran.marley",
                                Senha = "T8BDdQokQd79jjXS4j6E8A==",
                                DataCadastro = DateTime.Now,
                                Ativo = true
                            }
                        }
                    },
                    new Perfil
                    {
                        Descricao = "Usuário", 
                        Ativo = true,
                        Usuario = new Collection<Usuario>
                        {
                            new Usuario
                            {
                                Nome = "Teste",
                                Email = "teste@teste.com",
                                Login = "teste.teste",
                                Senha = "T8BDdQokQd79jjXS4j6E8A==",
                                DataCadastro = DateTime.Now,
                                Ativo = true
                            }
                        }
                    }
                }
            );
            
            context.SaveChanges();
        }
    }
}
