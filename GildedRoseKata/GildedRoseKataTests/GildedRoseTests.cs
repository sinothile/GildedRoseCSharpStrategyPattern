using GildedRoseKata.Models;
using GildedRoseKata.Srs;
using NUnit.Framework;

namespace GildedRoseKataTests
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void UpdateQuality_GivenAgedBrieItemAndQualityIsLessThan50_ShouldIncreaseQuality()
        {   
            //Arrange
            var item = new Items()
            {
                Name = "Aged Brie",
                Sellin = 10,
                Quality = 4
            };

            var sut = new AgedBrie();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 5;
            Assert.AreEqual(expected,item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenAgedBrieItemAndQualityIs50_ShouldDoNothing()
        {
            //Arrange       
            var item = new Items()
            {
                Name = "Aged Brie",
                Sellin = 10,
                Quality = 50
            };

            var sut = new AgedBrie();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 50;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenAgedBrieItemAndQualityIsMoreThan50_ShouldDoNothing()
        {
            //Arrange   
            var item = new Items()
            {
                Name = "Aged Brie",
                Sellin = 10,
                Quality = 55
            };

            var sut = new AgedBrie();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 55;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenBackstagePassesItemAndSellingIs10Days_ShouldIncreaseQualityByTwo()
        {
            //Arrange   
            var item = new Items()  
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Sellin = 10,
                Quality = 30
            };

            var sut = new BackstagePasses();

            //Act
            sut.UpdateQuality(item);    

            //Assert
            var expected = 32;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenBackstagePassesItemAndQualityIs50_ShouldDoNothing()
        {
            //Arrange   
            var item = new Items()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert", 
                Sellin = 15,
                Quality = 50
            };

            var sut = new BackstagePasses();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 50;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenBackstagePassesItemAndSellingIs5Days_ShouldIncreaseQualityByThree()
        {
            //Arrange   
            var item = new Items()  
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Sellin = 5,
                Quality = 20
            };

            var sut = new BackstagePasses();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 23;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenSulfurasItemAndQualityIsLessThan50_ShouldDoNothing()
        {   
            //Arrange   
            var item = new Items()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Sellin = 5,
                Quality = 20
            };

            var sut = new DoNothing();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 20;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenNormalItemAndQualityIsLessThan50_ShouldDecreaseQuality()
        {
            //Arrange       
            var item = new Items()
            {
                Name = "Cake ",
                Sellin = 5,
                Quality = 20
            };

            var sut = new Standard();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 19;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]  
        public void UpdateQuality_GivenNormalItemAndQualityIsMoreThan50_ShouldDecreaseQuality()
        {
            //Arrange           
            var item = new Items()  
            {
                Name = "Cake",
                Sellin = 5,
                Quality = 57
            };

            var sut = new Standard();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 56;
            Assert.AreEqual(expected, item.Quality);
        }

        [Test]
        public void UpdateQuality_GivenNormalItemAndQualityIs50_ShouldDecreaseQuality()
        {
            //Arrange               
            var item = new Items()  
            {   
                Name = "Cake",
                Sellin = 5,
                Quality = 50
            };

            var sut = new Standard();

            //Act
            sut.UpdateQuality(item);

            //Assert
            var expected = 49;
            Assert.AreEqual(expected, item.Quality);
        }
    }
}
