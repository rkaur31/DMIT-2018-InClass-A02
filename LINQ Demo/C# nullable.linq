<Query Kind="Program" />

//C# PRIMER on nullable-types and extension methods

void Main ()
{
	int? totalCount = null;
	totalCount.Dump();
	
	if (totalCount.HasValue) // .HasValue is true if there is no int value
	{
		"It has a value".Dump();
	}
	else
	{
		"It does not have a value - it us 'null'".Dump();
	}
	totalCount = 99;
	totalCount.Dump();	
}


//Define other methods and classes here