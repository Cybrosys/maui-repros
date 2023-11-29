namespace MauiApp1.DependencyInjection.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class SingletonAttribute(string? serviceKey = null) : Attribute
{
    public string? ServiceKey { get; } = serviceKey;
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class SingletonAttribute<TService>(string? serviceKey = null) : SingletonAttribute(serviceKey)
{
}
