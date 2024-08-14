using Ardalis.SmartEnum;

namespace GymManagement.Domain.Subscriptions;

public class SubscriptionType : SmartEnum<SubscriptionType>
{
    public static readonly SubscriptionType Free = new(nameof(Free), 0);
    public static readonly SubscriptionType Started = new(nameof(Started), 1);
    public static readonly SubscriptionType Pro = new(nameof(Pro), 2);
    public SubscriptionType(string name, int value) : base(name, value)
    {
    }
}