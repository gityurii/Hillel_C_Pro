namespace HW4;

public class CreditCard
{
    public decimal Balance { get; set; }
    public string Currency { get; set; }

    public CreditCard(decimal balance, string currency)
    {
        Balance = balance;
        Currency = currency;
    }

    public static CreditCard operator +(CreditCard card, decimal amount)
    {
        card.Balance += amount;
        return card;
    }

    public static bool operator ==(CreditCard card1, CreditCard card2)
    {
        if (card1 is null || card2 is null)
        {
            return false;
        }

        return card1.Balance == card2.Balance && card1.Currency == card2.Currency;
    }

    public static bool operator !=(CreditCard card1, CreditCard card2)
    {
        return !(card1 == card2);
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        if (card1 is null || card2 is null)
        {
            throw new ArgumentNullException("CreditCards cannot be null");
        }

        if (card1.Currency != card2.Currency)
        {
            throw new InvalidOperationException("Cannot compare balances in different currencies");
        }

        return card1.Balance < card2.Balance;
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        if (card1 is null || card2 is null)
        {
            throw new ArgumentNullException("CreditCards cannot be null");
        }

        if (card1.Currency != card2.Currency)
        {
            throw new InvalidOperationException("Cannot compare balances in different currencies");
        }

        return card1.Balance > card2.Balance;
    }

    public override bool Equals(object obj)
    {
        if (obj is CreditCard otherCard)
        {
            return Balance == otherCard.Balance && Currency == otherCard.Currency;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Balance, Currency);
    }
}