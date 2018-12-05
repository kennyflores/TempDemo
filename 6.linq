<Query Kind="Expression">
  <Connection>
    <ID>3a4d489c-8ac7-477d-8964-8d3a2f252acf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from person in Customers
where person.CustomerID == 1
select new
{
	Customer = person.LastName + ", " + person.FirstName,
	OrdersCount = person.Orders.Count(),
	Items = from item in OrderLists
			where item.Order.CustomerID == 1
			group item by item.Product into items
			orderby items.Key.Description.Count() descending, items.Key.Description
			select new
			{
				Description = items.Key.Description,
				timesbought = items.Key.Description.Count()
			}
}