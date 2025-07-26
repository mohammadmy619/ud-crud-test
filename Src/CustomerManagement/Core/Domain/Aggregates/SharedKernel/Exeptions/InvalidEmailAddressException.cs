using Domain.Aggregates.SharedKernel.Domain;
using System.Diagnostics.CodeAnalysis;
using System.Net.Mail;


namespace Domain.Aggregates.SharedKernel.Domain;

public class InvalidEmailAddressException : DomainException
{
    private const string _messages = "Invalid Email Address.";

    public InvalidEmailAddressException() : base(_messages) { }

    public static void Throw(string email)
    {
        if (!MailAddress.TryCreate(email, out _))
        {
            throw new InvalidEmailAddressException();
        }
    }
}