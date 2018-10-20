namespace ControleClientes.Data.Migrations
{
    using ControleClientes.Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ControleClientes.Data.Contextos.ControleClienteContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ControleClientes.Data.Contextos.ControleClienteContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            List<Conta> contasLuiz = new List<Conta>();
            contasLuiz.Add(new Conta() { IdConta = 1, IdAgencia = 1, IdTipoConta = 1, IdCliente = 1, NumeroConta = 554681, Saldo = 100 });
            contasLuiz.Add(new Conta() { IdConta = 2, IdAgencia = 1, IdTipoConta = 2, IdCliente = 1, NumeroConta = 223548, Saldo = 300 });

            List<Conta> contasSandra = new List<Conta>();
            contasLuiz.Add(new Conta() { IdConta = 3, IdAgencia = 2, IdTipoConta = 3, IdCliente = 1, NumeroConta = 154896, Saldo = 300 });
            contasLuiz.Add(new Conta() { IdConta = 4, IdAgencia = 1, IdTipoConta = 2, IdCliente = 1, NumeroConta = 354681, Saldo = 700 });

            List<Conta> contasMarcelo = new List<Conta>();
            contasLuiz.Add(new Conta() { IdConta = 5, IdAgencia = 2, IdTipoConta = 1, IdCliente = 1, NumeroConta = 987951, Saldo = 500 });
            contasLuiz.Add(new Conta() { IdConta = 6, IdAgencia = 2, IdTipoConta = 1, IdCliente = 1, NumeroConta = 112357, Saldo = 150 });

            List<Conta> contasWillian = new List<Conta>();
            contasLuiz.Add(new Conta() { IdConta = 7, IdAgencia = 1, IdTipoConta = 3, IdCliente = 1, NumeroConta = 168574, Saldo = 350 });
            contasLuiz.Add(new Conta() { IdConta = 8, IdAgencia = 2, IdTipoConta = 3, IdCliente = 1, NumeroConta = 135498, Saldo = 600 });

            context.TipoConta.AddOrUpdate(x => x.IdTipoConta, 
                    new TipoConta() { IdTipoConta = 1, NomeTipoConta = "Ouro" },
                    new TipoConta() { IdTipoConta = 2, NomeTipoConta = "Prata" },
                    new TipoConta() { IdTipoConta = 3, NomeTipoConta = "Bronze" }
                );

            context.Agencia.AddOrUpdate(x => x.IdAgencia,
                new Agencia() { IdAgencia = 1, NomeAgencia = "Parque São Paulo" },
                new Agencia() { IdAgencia = 2, NomeAgencia = "Interlagos" });

            context.Cliente.AddOrUpdate(x => x.IdCliente,
                new Cliente() { IdCliente = 1, Ativo = true, PrimeiroNome = "Luiz Henrique", SobreNome = "Silva", CPF = "42167429800", Email = "henrique@email.com", Contas = contasLuiz },
                new Cliente() { IdCliente = 2, Ativo = true, PrimeiroNome = "Sandra Lima", SobreNome = "Silva", CPF = "57517026895", Email = "sandra@email.com", Contas = contasSandra },
                new Cliente() { IdCliente = 3, Ativo = true, PrimeiroNome = "Marcelo", SobreNome = "Santos", CPF = "38494264834", Email = "marcelo@email.com", Contas = contasMarcelo },
                new Cliente() { IdCliente = 4, Ativo = true, PrimeiroNome = "Willian", SobreNome = "Oliveira", CPF = "04656240818", Email = "willian@email.com", Contas = contasWillian });
        }
    }
}
