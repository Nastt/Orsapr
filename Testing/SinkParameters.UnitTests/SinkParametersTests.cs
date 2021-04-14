using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace SinkParameters.UnitTests
{
    [TestFixture]
    public class SinkParametersTests
    {
        [Test]
        public void SinkLenght_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 1200.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkLenght = sourceValue;
            var actualValue = parameter.SinkLenght;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SinkLenght_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 400.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLenght = sourceValue;
                }
            );
        }

        [Test]
        public void SinkLenght_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters
            {
                CupSinkLenght = 440.00,
            };

            var sourceValue = 450.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLenght = sourceValue;
                }
            );
        }

        [Test]
        public void SinkWidth_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 700.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkWidth = sourceValue;
            var actualValue = parameter.SinkWidth;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SinkWidth_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 800.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkWidth = sourceValue;
                }
            );
        }

        [Test]
        public void SinkWidth_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters
            {
                CupSinkWidth = 460.00,
            };

            var sourceValue = 480.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkWidth = sourceValue;
                }
            );
        }

        [Test]
        public void SinkHeight_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 200.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkHeight = sourceValue;
            var actualValue = parameter.SinkHeight;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SinkHeight_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 300.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkHeight = sourceValue;
                }
            );
        }

        [Test]
        public void DrainHoleDiameter_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 60.00;
            var expectedValue = sourceValue;

            //Act
            parameter.DrainHoleDiameter = sourceValue;
            var actualValue = parameter.DrainHoleDiameter;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void DrainHoleDiameter_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 100.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.DrainHoleDiameter = sourceValue;
                }
            );
        }

        [Test]
        public void DrainHoleDiameter_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters
            {
                CraneHoleDiameter = 50.00,
            };

            var sourceValue = 53.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.DrainHoleDiameter = sourceValue;
                }
            );
        }

        [Test]
        public void CraneHoleDiameter_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 40.00;
            var expectedValue = sourceValue;

            //Act
            parameter.CraneHoleDiameter = sourceValue;
            var actualValue = parameter.CraneHoleDiameter;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CraneHoleDiameter_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters();
            var sourceValue = 100.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CraneHoleDiameter = sourceValue;
                }
            );
        }

        [Test]
        public void CraneHoleDiameter_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameters
            {
                DrainHoleDiameter = 50.00,
            };

            var sourceValue = 53.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.CraneHoleDiameter = sourceValue;
                }
            );
        }     
    }
}