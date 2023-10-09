using FluentAssertions;
using Kata.Template.Features;

namespace Kata.Template.Tests.Unit.Features
{
    public class AwesomeFeatureTests
    {
        [Fact]
        public void ItCreatesAnObject()
        {
            var awesomeFeature = new AwesomeFeature();

            awesomeFeature.Should().NotBeNull();
        }
    }
}