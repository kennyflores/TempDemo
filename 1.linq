<Query Kind="Expression">
  <Connection>
    <ID>e9b87c20-ce31-477a-b7fb-60d4465c84ae</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from item in Products
orderby item.OrderLists.Count() descending, item.Description
select new
{
	Product = item.Description,
	TimesPurchased = item.OrderLists.Count()
}