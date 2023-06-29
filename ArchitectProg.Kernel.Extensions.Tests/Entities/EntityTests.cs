using AutoFixture;
using FluentAssertions;
using NUnit.Framework;

namespace ArchitectProg.Kernel.Extensions.Tests.Entities;

public class EntityTests
{
    private readonly Fixture fixture = new();

    [TestCase(1, 1, true)]
    [TestCase(1, 2, false)]
    public void EqualOperator_When_Should_Return_Expected_Result(int firstId, int secondId, bool expected)
    {
        var first = GetTestEntity(firstId);
        var second = GetTestEntity(secondId);

        var result = first == second;

        result.Should().Be(expected);
    }

    [Test]
    public void EqualOperator_When_Entities_Is_Null_Should_Return_True()
    {
        var first = default(TestEntity);
        var second = default(TestEntity);

        var result = first == second;

        result.Should().BeTrue();
    }

    [Test]
    public void EqualOperator_When_One_Entity_Is_Null_Should_Return_False()
    {
        var id = fixture.Create<int>();
        var first = default(TestEntity);
        var second = GetTestEntity(id);

        var result = first == second;

        result.Should().BeFalse();
    }

    [TestCase(1, 1, false)]
    [TestCase(1, 2, true)]
    public void NotEqualOperator_When_Should_Return_Expected_Result(int firstId, int secondId, bool expected)
    {
        var first = GetTestEntity(firstId);
        var second = GetTestEntity(secondId);

        var result = first != second;

        result.Should().Be(expected);
    }

    [Test]
    public void NotEqualOperator_When_Entities_Is_Null_Should_Return_False()
    {
        var first = default(TestEntity);
        var second = default(TestEntity);

        var result = first != second;

        result.Should().BeFalse();
    }

    [Test]
    public void NotEqualOperator_When_One_Entity_Is_Null_Should_Return_True()
    {
        var id = fixture.Create<int>();
        var first = default(TestEntity);
        var second = GetTestEntity(id);

        var result = first != second;

        result.Should().BeTrue();
    }

    [TestCase(1, 1, true)]
    [TestCase(1, 2, false)]
    public void Equal_Should_Return_Expected_Result(int firstId, int secondId, bool expected)
    {
        var first = GetTestEntity(firstId);
        var second = GetTestEntity(secondId);

        var result = first.Equals(second);

        result.Should().Be(expected);
    }

    [Test]
    public void Equal_When_Other_Entity_Is_Null_Should_Return_False()
    {
        var id = fixture.Create<int>();
        var first = GetTestEntity(id);
        var second = default(TestEntity);

        var result = first.Equals(second);

        result.Should().BeFalse();
    }

    [Test]
    public void Equal_When_Entities_Are_Same_Is_Null_Should_Return_True()
    {
        var id = fixture.Create<int>();
        var first = GetTestEntity(id);
        var second = first;

        var result = first.Equals(second);

        result.Should().BeTrue();
    }

    [Test]
    public void Equal_When_Entities_Have_Different_Types_Should_Return_False()
    {
        var id = fixture.Create<int>();
        var first = GetTestEntity(id);
        var second = GetNestedTestEntity(id);

        var result = first.Equals(second);

        result.Should().BeFalse();
    }

    private TestEntity GetTestEntity(int id)
    {
        var testProperty = fixture.Create<float>();
        var result = new TestEntity
        {
            Id = id,
            TestProperty = testProperty
        };

        return result;
    }

    private NestedTestEntity GetNestedTestEntity(int id)
    {
        var testProperty = fixture.Create<float>();
        var result = new NestedTestEntity
        {
            Id = id,
            TestProperty = testProperty
        };

        return result;
    }
}