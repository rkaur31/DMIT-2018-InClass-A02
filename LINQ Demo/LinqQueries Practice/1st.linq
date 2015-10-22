<Query Kind="Expression">
  <Connection>
    <ID>b4ba2e19-074a-4848-a12c-9f8d95e8a757</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in SpecialEvents
where eachRow.Active
select  eachRow