using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAll_Basic()
        {
            var users = new List<User>()
            {
                new User
                {
                    Name = "Антон"
                },
                new User
                {
                    Name = "Иван"
                },
                new User
                {
                    Name = "Алексей"
                }
            };

            var mockUser = new Mock<IUserRepository>();

            mockUser.Setup(s => s.FindAll()).Returns(users);

            Assert.That(users.Count == 3);
            Assert.That(users[0].Name == "Антон");
            Assert.That(users[1].Name == "Иван");
            Assert.That(users[2].Name == "Алексей");
        }
    }
}