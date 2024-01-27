using ContactCreator.DTO;
using ContactCreator.Model;
using ContactCreator.Services;

namespace ContactCreator
{
    public class Tests
    {
        private readonly UserService _userService;

        public Tests()
        {
            _userService = new UserService();
        }

        [Test]
        public void WhenContactCreatedShouldReturnCreatedContact()
        {
            //AAA
            //ARRANGE
            ContactToCreateDTO newContact = new ContactToCreateDTO
            {
                FirstName = "Adrian",
                LastName = "Widlak",
            };

            //ACT
            Contact contact = _userService.Create(newContact);

            //ASSERT
            Assert.NotNull(contact);
            Assert.That(contact.Id, Is.Not.EqualTo(Guid.Empty));
            Assert.That(contact.FirstName, Is.EqualTo("Adrian"));
            Assert.That(contact.LastName, Is.EqualTo(newContact.LastName));

        }

        [Test]
        public void WhenContactCreatedIsNullShouldThrowArgumentException()
        {
            //ARRANGE

            //ACT
            var contact = Assert.Throws<ArgumentNullException>(() => _userService.Create(null));

            //ASSERT
            Assert.That(contact.ParamName, Is.EqualTo("contactToCreateDTO"));
        }
    }
}
