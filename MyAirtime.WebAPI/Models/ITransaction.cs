namespace MyAirtime.WebAPI.Models;

public class ITransaction
{
    protected static string? GenerateTransactionId(string toUser, string fromUser)
    {
        string? returnString = null;
        if (toUser != null && fromUser != null)
        {
            returnString = string.Concat(fromUser.AsSpan(fromUser.Length - 3), toUser.AsSpan(toUser.Length - 3));
        }

        return returnString;
    }
}