<Query Kind="Expression">
  <Connection>
    <ID>11259862-5534-451c-97b1-68e77b21d92e</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

//booking a variable name that I make up
from booking in Reservations 
where booking.EventCode.Equals("A")
select booking 