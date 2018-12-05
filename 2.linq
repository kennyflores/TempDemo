<Query Kind="Expression">
  <Connection>
    <ID>3a4d489c-8ac7-477d-8964-8d3a2f252acf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from place in Stores
orderby place.Location
select new
{
	Location = place.Location,
	Clients = from order in place.Orders
			  group order by order.Customer into customerAddress
			  select new
			{
				Address = customerAddress.Key.Address,
				City = customerAddress.Key.City,
				Province = customerAddress.Key.Province
			}
}