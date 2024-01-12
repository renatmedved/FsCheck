using FsCheck.Fluent;
using FsCheck.Xunit;
using Xunit;

namespace FsCheck.XUnit.CSharpExamples;

public class PropertyConfigProviderTest
{
    private class PropertyConfigProviderAttribute : FactAttribute, IPropertyConfigProviderAttribute
    {
        public PropertyAttribute GetPropertyTestConfig()
        {
            return new PropertyAttribute();
        }
    }
    
    [PropertyConfigProvider]
    public Property ShouldWork_IPropertyConfigProviderAttribute()
    {
        return true.ToProperty();
    }
}