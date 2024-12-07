using Sixfortyfour.ConsoleApp;

namespace Sixfortyfour.ConsoleAppTests
{
    public class PersonTests
    {
        [Fact]
        public void Person_has_name()
        {
            var person = new Person() { Id = 1, Name = "Bob" };

            Assert.True(person.Name.Length > 0);
        }

        [Fact]
        public void Person_does_not_have_name()
        {
            var person = new Person() { Id = 1, Name = "" };

            Assert.False(person.Name.Length > 0);
        }
    }
}