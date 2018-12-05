<Query Kind="Expression">
  <Connection>
    <ID>e9b87c20-ce31-477a-b7fb-60d4465c84ae</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from cat in Categories 
orderby cat.Description
select new
{
	Category = cat.Description,
	OrderProducts = from item in OrderLists
					where item.OrderID == 33 && item.Product.CategoryID == cat.CategoryID
					orderby item.Product.Description
					select new
					{
						Product = item.Product.Description,
						Price = item.Price,
						PickedQty = item.QtyPicked,
						Discount = item.Discount,
						SubTotal = (item.Price * (decimal)item.QtyPicked) - item.Discount,
						Tax = ((item.Price * (decimal)item.QtyPicked) - item.Discount) * (decimal).05,
						ExtendedPrice = (item.Price * (decimal)item.QtyPicked) - item.Discount + 
										((item.Price * (decimal)item.QtyPicked) - item.Discount) * (decimal).05
					}
}