namespace BuyAirtime.Contracts;

public class BuyAirtimeRequest
{
    public string ToUser { get; set; }
    public string FromUser { get; set; }
    public int Amount { get; set; }

    public BuyAirtimeRequest(string toUser, string fromUser, int amount)
    {
        ToUser = toUser;
        FromUser = fromUser;
        Amount = amount;
    }
}