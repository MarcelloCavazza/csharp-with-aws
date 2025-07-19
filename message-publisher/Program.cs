using System;
using message_publisher.models;

var customerTest = new Customer()
{
	Id = Guid.NewGuid(),
	FullName = "Teste",
	Email = "email@gmail.com",
	BirthDate = DateTime.Now
};


Console.WriteLine(customerTest);
