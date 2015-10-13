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
group food by food.MenuCategory into result
select result