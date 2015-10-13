<Query Kind="Expression" />

from person in Waiters
where person.ReleaseDate == null // People still employed
select new
{
	Name = person.FirstName + " " + person>LastName,
	Phone = person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}