using ЗнижкоСвіт;

namespace UnitTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardInitialization()
        {
            // Arrange
            int id = 1;
            string name = "TestCard";
            string address = "TestAddress";
            int price = 100;
            int discount = 10;
            string imagePath = "TestImagePath";

            // Act
            Card card = new Card(id, name, address, price, discount, imagePath);

            // Assert
            Assert.AreEqual(id, card.Id);
            Assert.AreEqual(name, card.Name);
            Assert.AreEqual(address, card.Address);
            Assert.AreEqual(price, card.Price);
            Assert.AreEqual(discount, card.Discount);
            Assert.AreEqual(imagePath, card.ImagePath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNegativeId()
        {
            // Arrange
            int id = -1;
            string name = "TestCard";
            string address = "TestAddress";
            int price = 100;
            int discount = 10;
            string imagePath = "TestImagePath";

            // Act
            Card card = new Card(id, name, address, price, discount, imagePath);

            //assert нема бо очікую виключення
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyName()
        {
            // Arrange
            int id = 1;
            string name = "";
            string address = "TestAddress";
            int price = 100;
            int discount = 10;
            string imagePath = "TestImagePath";

            // Act & Assert
            Card card = new Card(id, name, address, price, discount, imagePath);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyAddress()
        {
            // Arrange
            int id = 1;
            string name = "TestCard";
            string address = "";
            int price = 100;
            int discount = 10;
            string imagePath = "TestImagePath";

            // Act & Assert
            Card card = new Card(id, name, address, price, discount, imagePath);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestZeroPrice()
        {
            // Arrange
            int id = 1;
            string name = "TestCard";
            string address = "TestAddress";
            int price = 0;
            int discount = 10;
            string imagePath = "TestImagePath";

            // Act & Assert
            Card card = new Card(id, name, address, price, discount, imagePath);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestZeroDiscount()
        {
            // Arrange
            int id = 1;
            string name = "TestCard";
            string address = "TestAddress";
            int price = 100;
            int discount = 0;
            string imagePath = "TestImagePath";

            // Act & Assert
            Card card = new Card(id, name, address, price, discount, imagePath);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyImagePath()
        {
            // Arrange
            int id = 1;
            string name = "TestCard";
            string address = "TestAddress";
            int price = 100;
            int discount = 10;
            string imagePath = "";

            // Act & Assert
            Card card = new Card(id, name, address, price, discount, imagePath);
            
        }

        [TestMethod]
        public void TestCardComparison()
        {
            // Arrange
            Card card1 = new Card(1, "AAA", "Address1", 100, 10, "ImagePath1");
            Card card2 = new Card(2, "BBB", "Address2", 200, 20, "ImagePath2");
            Card card3 = new Card(3, "AAA", "Address3", 300, 30, "ImagePath3");

            // Act & Assert
            Assert.IsTrue(card1.CompareTo(card2) < 0); 
            Assert.IsTrue(card2.CompareTo(card1) > 0); 
            Assert.IsTrue(card1.CompareTo(card3) == 0); 
        }

    }


    [TestClass]
    public class GuestTests
    {
        [TestMethod]
        public void TestGuestInitialization()
        {
            // Arrange
            Guest guest;

            // Act
            guest = new Guest();

            // Assert
            Assert.IsNotNull(guest);
            Assert.AreEqual("Guest", guest.Name);
            Assert.AreEqual("Guest", guest.Role);
        }
    }


    [TestClass]
    public class SignInUserTests
    {
        [TestMethod]
        public void TestSignInUserInitialization()
        {
            // Arrange
            string name = "TestUser";
            string password = "TestPassword";

            // Act
            SignInUser user = new SignInUser(name, password);

            // Assert
            Assert.IsNotNull(user);
            Assert.AreEqual(name, user.Name);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual("SignIn", user.Role);
            Assert.IsNotNull(user.FavCards);
            Assert.AreEqual(0, user.FavCards.Count);
        }
    }


    [TestClass]
    public class UserManagerTests
    {

        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    // Код, що виконується перед кожним тестом
        //    UserManager.users.Clear(); // Очищення списку користувачів
        //    UserManager.CurrentUser = new Guest(); // Скидання поточного користувача до Guest
        //}

        [TestMethod]
        public void TestRegisterUser_ValidCredentials_Success()
        {
            // Arrange
            string username = "testuser1";
            string password = "12345";

            // Act
            UserManager.RegisterUser(username, password);

            // Assert
            Assert.IsTrue(UserManager.users.Exists(u => u.Name == username));
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterUser_InvalidUsername_ExceptionThrown()
        {
            // Arrange
            string username = "wrong$#!";
            string password = "12345";

            // Act
            UserManager.RegisterUser(username, password);

            // Assert
            // Exception should be thrown
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterUser_InvalidPassword_ExceptionThrown()
        {
            // Arrange
            string username = "testuser";
            string password = "password";

            // Act
            UserManager.RegisterUser(username, password);

            // Assert
            // Exception should be thrown
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterUser_UsernameTooLong_ExceptionThrown()
        {
            // Arrange
            string username = "verylongusernameexceedingcharacterlimit";
            string password = "12345";

            // Act
            UserManager.RegisterUser(username, password);

            // Assert
            // Exception should be thrown
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterUser_PasswordTooShort_ExceptionThrown()
        {
            // Arrange
            string username = "testuser";
            string password = "123";

            // Act
            UserManager.RegisterUser(username, password);

            // Assert
            // Exception should be thrown
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRegisterUser_UsernameAlreadyExists_ExceptionThrown()
        {
            // Arrange
            string username = "existinguser";
            string password = "12345";
            UserManager.RegisterUser(username, password); // Реєстрація користувача

            // Act
            UserManager.RegisterUser(username, "newpassword"); // Повторна реєстрація з тим самим ім'ям користувача

            // Assert
            // Exception should be thrown
        }

        [TestMethod]
        public void TestLoginUser_ValidCredentials_Success()
        {
            // Arrange
            string username = "testuser";
            string password = "12345";
            UserManager.RegisterUser(username, password); // Реєстрація користувача

            // Act
            SignInUser loggedInUser = UserManager.LoginUser(username, password);

            // Assert
            Assert.IsNotNull(loggedInUser);
            Assert.AreEqual(username, loggedInUser.Name);
            Assert.AreEqual(password, loggedInUser.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLoginUser_InvalidCredentials_ExceptionThrown()
        {
            // Arrange
            string username = "testuser";
            string password = "invalidpassword";

            // Act
            UserManager.LoginUser(username, password);

            // Assert
            // Exception should be thrown
        }

    }


    [TestClass]
    public class CardManagerTests
    {
        [TestMethod]
        public void TestAddCard()
        {
            // Arrange
            CardManager cardManager = new CardManager();
            Card card = new Card(1, "TestCard", "TestAddress", 100, 10, "TestImagePath");

            // Act
            cardManager.AddCard(card);

            // Assert
            Assert.IsTrue(cardManager.GetCards().Contains(card));
        }

        [TestMethod]
        public void TestRemoveCard()
        {
            // Arrange
            CardManager cardManager = new CardManager();
            Card card = new Card(1, "TestCard", "TestAddress", 100, 10, "TestImagePath");
            cardManager.AddCard(card);

            // Act
            cardManager.RemoveCard(card);

            // Assert
            Assert.IsFalse(cardManager.GetCards().Contains(card));
        }

        [TestMethod]
        public void TestAddToFavorites()
        {
            // Arrange
            CardManager cardManager = new CardManager();
            Card card = new Card(1, "TestCard", "TestAddress", 100, 10, "TestImagePath");
            SignInUser user = new SignInUser("TestUser", "TestPassword");
            UserManager.CurrentUser = user;

            // Act
            cardManager.AddToFavorites(card);

            // Assert
            Assert.IsTrue(user.FavCards.Contains(card));
            Assert.IsTrue(card.IsFavorite);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddToFavoritesDuplicate()
        {
            // Arrange
            CardManager cardManager = new CardManager();
            Card card = new Card(1, "TestCard", "TestAddress", 100, 10, "TestImagePath");
            SignInUser user = new SignInUser("TestUser", "TestPassword");
            UserManager.CurrentUser = user;
            cardManager.AddToFavorites(card);

            // Act
            cardManager.AddToFavorites(card);
        }

        [TestMethod]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        public void TestAddToFavoritesUnauthorized()
        {
            // Arrange
            CardManager cardManager = new CardManager();
            Card card = new Card(1, "TestCard", "TestAddress", 100, 10, "TestImagePath");
            UserManager.CurrentUser = new Guest();

            // Act
            cardManager.AddToFavorites(card);
        }
    }

     [TestClass]
    public class FavoriteManagerTests
    {
        [TestMethod]
        public void TestGetCards_ReturnsListOfFavoriteCards()
        {
            // Arrange
            SignInUser user = new SignInUser("testuser", "12345");
            List<Card> favoriteCards = new List<Card>
            {
                new Card(1, "Favorite Card 1", "Address 1", 100, 10, "image1.jpg"),
                new Card(2, "Favorite Card 2", "Address 2", 200, 20, "image2.jpg")
            };
            user.FavCards = favoriteCards;
            FavoriteManager favoriteManager = new FavoriteManager(user);

            // Act
            List<Card> retrievedCards = favoriteManager.GetCards();

            // Assert
            CollectionAssert.AreEqual(favoriteCards, retrievedCards);
        }

        [TestMethod]
        public void TestRemoveCardFromFavorites_CardExistsInFavorites_CardRemoved()
        {
            // Arrange
            SignInUser user = new SignInUser("testuser", "12345");
            Card cardToRemove = new Card(3, "Card to Remove", "Address", 150, 15, "image3.jpg");
            List<Card> favoriteCards = new List<Card>
            {
                new Card(1, "Favorite Card 1", "Address 1", 100, 10, "image1.jpg"),
                cardToRemove,
                new Card(2, "Favorite Card 2", "Address 2", 200, 20, "image2.jpg")
            };
            user.FavCards = favoriteCards;
            FavoriteManager favoriteManager = new FavoriteManager(user);

            // Act
            favoriteManager.RemoveCardFromFavorites(cardToRemove);

            // Assert
            Assert.IsFalse(user.FavCards.Contains(cardToRemove));
        }

        [TestMethod]
        public void TestRemoveCardFromFavorites_CardDoesNotExistInFavorites_NothingRemoved()
        {
            // Arrange
            SignInUser user = new SignInUser("testuser", "12345");
            Card cardToRemove = new Card(4, "Non-existing Card", "Address", 300, 30, "image4.jpg");
            List<Card> favoriteCards = new List<Card>
            {
                new Card(1, "Favorite Card 1", "Address 1", 100, 10, "image1.jpg"),
                new Card(2, "Favorite Card 2", "Address 2", 200, 20, "image2.jpg")
            };
            user.FavCards = favoriteCards;
            FavoriteManager favoriteManager = new FavoriteManager(user);

            try
            {
                // Act
                favoriteManager.RemoveCardFromFavorites(cardToRemove);

                // Assert
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException ex)
            {
                // Assert
                Assert.AreEqual($"{cardToRemove.Name} is not in your favorites.", ex.Message);
            }
        }
    }


}