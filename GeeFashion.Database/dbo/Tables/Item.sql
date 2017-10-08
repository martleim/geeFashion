CREATE TABLE [dbo].[Item] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
	[WarehouseId] INT NOT NULL,
    [Size] INT NOT NULL, 
    [Color] NVARCHAR(50) NOT NULL, 
    [Status] INT NULL, 
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Item_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id]),
	CONSTRAINT [FK_Item_Warehouse] FOREIGN KEY ([WarehouseId]) REFERENCES [dbo].[Warehouse] ([Id])
);

