<Query Kind="Expression">
  <Connection>
    <ID>0a9b035d-0fa8-473a-8cbf-7f91fbd79bca</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

(from customer in Bills
where customer.PaidStatus == true
select customer.BillItems.Sum(theBill => theBill.SalePrice * theBill.Quantity)).Max()
// Without .Max() it display all of total price for each item