namespace MauiApp1.DependencyInjection.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class ScopedAttribute(string? serviceKey = null) : Attribute
{
    public string? ServiceKey { get; } = serviceKey;
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class ScopedAttribute<TService>(string? serviceKey = null) : ScopedAttribute(serviceKey)
{
}