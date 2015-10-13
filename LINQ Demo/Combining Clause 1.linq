<Query Kind="Expression">
  <Connection>
    <ID>0a9b035d-0fa8-473a-8cbf-7f91fbd79bca</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//List all the menu items that are Entrees
//in order from most to least expensive
from food in Items
where food.MenuCategory.Description == "Entree"
orderby food.CurrentPrice descending
select food