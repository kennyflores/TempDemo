<Query Kind="Expression">
  <Connection>
    <ID>3a4d489c-8ac7-477d-8964-8d3a2f252acf</ID>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

from place in Stores
orderby place.City, place.Location
select new
{
	City = place.City,
	Location = place.Location,
	Sales = from sale in place.Orders
			where sale.OrderDate.Month == 12
			orderby sale.OrderDate
			group sale by sale.OrderDate into orderDates
			select new
			{
				Date = orderDates.Key,
				numberOrders = orderDates.Count(),
				productsales = orderDates.Select(st => st.SubTotal).Sum(),
				gst = orderDates.Select(gst => gst.GST).Sum()
			}
	
}