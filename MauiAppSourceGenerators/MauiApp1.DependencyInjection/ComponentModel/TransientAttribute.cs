namespace MauiApp1.DependencyInjection.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class TransientAttribute(string? serviceKey = null) : Attribute
{
    public string? ServiceKey { get; } = serviceKey;
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class TransientAttribute<TService>(string? serviceKey = null) : TransientAttribute(serviceKey)
{
}
