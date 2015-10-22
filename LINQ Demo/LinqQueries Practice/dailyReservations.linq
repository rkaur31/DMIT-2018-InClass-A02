<Query Kind="Expression">
  <Connection>
    <ID>b4ba2e19-074a-4848-a12c-9f8d95e8a757</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from eachRow in Reservations
where eachRow.ReservationStatus =='B' // USE "B" IN Visual Studio
					// TBA - && each row has the correct EventCode..
orderby eachRow.ReservationDate
//select eachRow
group eachRow by new{ eachRow.ReservationDate.Month, eachRow.ReservationDate.Day}
into dailyReservation
select new { // DailyReservation() // create a class called DailyReservation()
	Month = dailyReservation.Key.Month,
	Day = dailyReservation.Key.Day,
	Reservations = from booking in dailyReservation
					select new // Booking() // Create a Booking DTO class
					{
						Name = booking.CustomerName,
						Time = booking.ReservationDate.TimeOfDay,
						NumberInParty = booking.NumberInParty,
						Phone = booking.ContactPhone,
						Event = booking.SpecialEvents.Description
					}
}