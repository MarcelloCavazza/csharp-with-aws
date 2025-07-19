using System;
using message_publisher.models;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;


var customerTest = new Customer()
{
	Id = Guid.NewGuid(),
	FullName = "Teste",
	Email = "email@gmail.com",
	BirthDate = DateTime.Now
};


Console.WriteLine(customerTest);
