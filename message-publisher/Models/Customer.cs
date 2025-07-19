namespace message_publisher.models;

public class Customer
{
	public required Guid Id { get; set; }

	public required string Email { get; set; }

	public required string FullName { get; set; }

	public required DateTime BirthDate { get; set; }

	public override string ToString()
	{
		return $"FullName: {FullName} - Email: {Email} - BirthDate: {BirthDate}";
	}
}
    
