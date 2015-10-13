<Query Kind="Expression">
  <Connection>
    <ID>0a9b035d-0fa8-473a-8cbf-7f91fbd79bca</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>


(from theBill in BillItems
where theBill.BillID == 104
select theBill.SalePrice * theBill.Quantity).Sum()

// Without .Sum(), it display all total price of each item 