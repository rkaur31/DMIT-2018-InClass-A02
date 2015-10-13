<Query Kind="Expression">
  <Connection>
    <ID>0a9b035d-0fa8-473a-8cbf-7f91fbd79bca</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new
{
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}