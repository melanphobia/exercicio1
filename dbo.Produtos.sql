CREATE TABLE [dbo].[Produtos] (
    [Id]           INT         NOT NULL,
    [Nome]         NCHAR (45)  NOT NULL,
    [Preco]        NCHAR (10)  NOT NULL,
    [Descricao]    NCHAR (100) NOT NULL,
    [Categoria_id] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Categoria] FOREIGN KEY ([Categoria_id]) REFERENCES [dbo].[Categoria] ([Id])
);

