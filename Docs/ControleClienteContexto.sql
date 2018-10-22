create database [ControleCliente]
go

create table [dbo].[Agencia] (
    [IdAgencia] [int] not null identity,
    [NomeAgencia] [nvarchar](max) not null,
    [Endereco] [nvarchar](max) null,
    primary key ([IdAgencia])
)
go


create table [dbo].[Cliente] (
    [IdCliente] [int] not null identity,
    [PrimeiroNome] [nvarchar](150) not null,
    [SobreNome] [nvarchar](150) not null,
    [Email] [nvarchar](150) not null,
    [Ativo] [bit] not null,
    [CPF] [nvarchar](max) not null,
    primary key ([IdCliente])
)
go

create table [dbo].[Conta] (
    [IdConta] [int] not null identity,
    [IdAgencia] [int] not null,
    [IdCliente] [int] not null,
    [IdTipoConta] [int] not null,
    [NumeroConta] [int] not null,
    [Saldo] [float] not null,
    [Cliente_IdCliente] [int] null,
    primary key ([IdConta])
)
go

create table [dbo].[TipoConta] (
    [IdTipoConta] [int] not null identity,
    [NomeTipoConta] [nvarchar](max) not null,
    primary key ([IdTipoConta])
)
go

alter table [dbo].[Conta] add constraint [Cliente_Contas] foreign key ([Cliente_IdCliente]) references [dbo].[Cliente]([IdCliente])
go

alter table [dbo].[Conta] add constraint [Conta_Agencia] foreign key ([IdAgencia]) references [dbo].[Agencia]([IdAgencia])
go

alter table [dbo].[Conta] add constraint [Conta_Cliente] foreign key ([IdCliente]) references [dbo].[Cliente]([IdCliente])
go

alter table [dbo].[Conta] add constraint [Conta_TipoConta] foreign key ([IdTipoConta]) references [dbo].[TipoConta]([IdTipoConta])
go
