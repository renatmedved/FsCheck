using FsCheck.Fluent;
using FsCheck.Xunit;
using Xunit;

namespace FsCheck.XUnit.CSharpExamples;

public class TheoryExample
{
    [PropertyTheory]
    [InlineData(42, "42")]
    public Property Check(int a, string s)
    {
        return (a == 42 && s=="42").ToProperty();
    }
}