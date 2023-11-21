CREATE TABLE [dbo].[Produtos] (
    [Id]           INT         NOT NULL,
    [Nome]         NCHAR (45)  NULL,
    [Preco]        NCHAR (10)  NULL,
    [Descricao]    NCHAR (100) NULL,
    [Categoria_id] INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_Categoria] FOREIGN KEY ([Categoria_id]) REFERENCES [dbo].[Categoria] ([Id])
);

