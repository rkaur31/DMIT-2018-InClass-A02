<Query Kind="Expression">
  <Connection>
    <ID>0a9b035d-0fa8-473a-8cbf-7f91fbd79bca</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

Waiters.First() // Display the first waiter in the list

Waiters.First(person => person.FirstName.StartsWith("D")) // Display the first waiter name start with D in the list

Waiters.FirstOrDefault(person => person.FirstName.StartsWith("W")) // Display the first waiter name start with W in the list and display default value if dont have that name