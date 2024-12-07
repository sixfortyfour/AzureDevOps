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
    }
}