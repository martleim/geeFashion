CREATE PROCEDURE [dbo].[GetProductByWarehouseId]
@WarehouseId int
AS
SELECT p.Name as Name, p.Price as Price, (count(1)-1) as Quantity
FROM Product p
Left Join Item i
on i.ProductId=p.Id
WHERE i.WarehouseId=@WarehouseId
and i.Status=1
group by
p.Name, p.Price