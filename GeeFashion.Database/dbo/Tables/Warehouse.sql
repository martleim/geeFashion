CREATE TABLE [dbo].[Warehouse] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Location] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED ([Id] ASC)
);

