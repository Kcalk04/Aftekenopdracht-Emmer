namespace Aftekenopdracht_Emmer
{
    [TestFixture]
    public class BucketTest
    {
        [TestCase(18, typeof(ContentOverFlowException))]
        [TestCase(-5, typeof(ContentUnderFlowException))]
        public void FillBucket_OverFlowAndUnderFlow_ReturnError(int input, Type excpectedException)
        {
            // Arrange
            Bucket bucket = new Bucket(17);

            // Act & Assert
            Assert.Throws(excpectedException, () => bucket.Fill(input));
        }

        [TestCase(0, 0)]
        [TestCase(4, 4)]
        public void FillBucket_Fill_ReturnNewContents(int input, int result)
        {
            // Arrange
            Bucket bucket = new Bucket(17);

            //Act
            bucket.Fill(input);

            //Assert
            Assert.AreEqual(bucket.Content, result);
        }

        [TestCase(0, 0)]
        [TestCase(4, 0)]
        public void Empty_BucketContent_Zero(int input, int result)
        {
            //Arrange
            Bucket bucket = new Bucket(12);

            //Act
            bucket.Fill(input);
            result = bucket.Empty();

            //Assert
            Assert.AreEqual(bucket.Content, result);
        }

        [TestCase(-5, typeof(InvalidCapacityException))]
        [TestCase(0, typeof(InvalidCapacityException))]
        [TestCase(5000, typeof(InvalidCapacityException))]
        public void BucketConstructor_InvalidArguments_InvalidCapacityException(int input, Type excpectedException)
        {
            //Arrange, Act & Assert
            Assert.Throws(excpectedException, () => new Bucket(input));
        }

        [TestCase(12, 12)]
        [TestCase(30, 30)]
        public void BucketConstructor_ValidArguments_ValidNewBucket(int input, int result)
        {
            //Arrange
            Bucket bucket = new Bucket(input);

            //Act
            result = bucket.Capacity;

            //Assert
            Assert.AreEqual(bucket.Capacity, result);
        }
    }


    [TestFixture]
    public class OildrumTest
    {
        [TestCase(200, typeof(ContentOverFlowException))]
        [TestCase(-5, typeof(ContentUnderFlowException))]
        public void FillOildrum_OverFlowAndUnderFlow_ReturnError(int input, Type excpectedException)
        {
            // Arrange
            OilDrum oildrum = new OilDrum();

            // Act & Assert
            Assert.Throws(excpectedException, () => oildrum.Fill(input));
        }

        [TestCase(0, 0)]
        [TestCase(100, 100)]
        public void FillOildrum_Fill_ReturnNewContents(int input, int result)
        {
            // Arrange
            OilDrum oildrum = new OilDrum();

            //Act
            oildrum.Fill(input);

            //Assert
            Assert.AreEqual(oildrum.Content, result);
        }

        [TestCase(0, 0)]
        [TestCase(4, 0)]
        public void Empty_OildrumContent_Zero(int input, int result)
        {
            //Arrange
            OilDrum oildrum = new OilDrum();

            //Act
            oildrum.Fill(input);
            result = oildrum.Empty();

            //Assert
            Assert.AreEqual(oildrum.Content, result);
        }

        [TestCase(-5, typeof(InvalidCapacityException))]
        [TestCase(0, typeof(InvalidCapacityException))]
        [TestCase(5000, typeof(InvalidCapacityException))]
        public void OildrumConstructor_InvalidArguments_InvalidCapacityException(int input, Type excpectedException)
        {
            //Arrange, Act & Assert
            Assert.Throws(excpectedException, () => new OilDrum(input));
        }

        [TestCase(159, 159)]
        public void OildrumConstructor_ValidArguments_ValidNewOildrum(int input, int result)
        {
            //Arrange
            OilDrum oildrum = new OilDrum(input);

            //Act
            result = oildrum.Capacity;

            //Assert
            Assert.AreEqual(oildrum.Capacity, result);
        }
    }

    [TestFixture]
    public class RainbarrelTest
    {
        [TestCase(120, typeof(ContentOverFlowException))]
        [TestCase(-5, typeof(ContentUnderFlowException))]
        public void FillRainbarrel_OverFlowAndUnderFlow_ReturnError(int input, Type excpectedException)
        {
            // Arrange
            Rainbarrel rainbarrel = new Rainbarrel(100);

            // Act & Assert
            Assert.Throws(excpectedException, () => rainbarrel.Fill(input));
        }

        [TestCase(0, 0)]
        [TestCase(20, 20)]
        public void Fill_Rainbarrel_ReturnNewContents(int input, int result)
        {
            // Arrange
            Rainbarrel rainbarrel = new Rainbarrel(100);

            //Act
            rainbarrel.Fill(input);

            //Assert
            Assert.AreEqual(rainbarrel.Content, result);
        }

        [TestCase(0, 0)]
        [TestCase(20, 0)]
        public void Empty_RainbarrelContent_Zero(int input, int result)
        {
            //Arrange
            Rainbarrel rainbarrel = new Rainbarrel(100);

            //Act
            rainbarrel.Fill(input);
            result = rainbarrel.Empty();

            //Assert
            Assert.AreEqual(rainbarrel.Content, result);
        }

        [TestCase(-5, typeof(InvalidCapacityException))]
        [TestCase(76, typeof(InvalidCapacityException))]
        [TestCase(140, typeof(InvalidCapacityException))]
        public void RainbarrelConstructor_InvalidArguments_InvalidCapacityException(int input, Type excpectedException)
        {
            //Arrange, Act & Assert
            Assert.Throws(excpectedException, () => new Rainbarrel(input));
        }

        [TestCase(80, 80)]
        [TestCase(100, 100)]
        [TestCase(120, 120)]
        public void RainbarrelConstructor_ValidArguments_ValidNewRainbarrel(int input, int result)
        {
            //Arrange
            Rainbarrel rainbarrel = new Rainbarrel(input);

            //Act
            result = rainbarrel.Capacity;

            //Assert
            Assert.AreEqual(rainbarrel.Capacity, result);
        }
    }
}


