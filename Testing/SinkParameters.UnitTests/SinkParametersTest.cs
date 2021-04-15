﻿using System;
using NUnit.Framework;
using Sink;

namespace SinkParameters.UnitTests
{
    [TestFixture]
    public class SinkParametersTest
    {
        [Test]
        public void SinkLenght_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 1200.00;
            var expectedValue = sourceValue;

            //Act
            parameter.SinkLength = sourceValue;
            var actualValue = parameter.SinkLength;

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SinkLenght_OutOfRangeValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter();
            var sourceValue = 400.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLength = sourceValue;
                }
            );
        }

        [Test]
        public void SinkLenght_IncorrectValue_ThrowsException()
        {
            //Setup
            var parameter = new SinkParameter
            {
                SinkLength = 490.00,
                CupSinkLength = 440.00,
            };

            var sourceValue = 450.00;

            //Act
            NUnit.Framework.Assert.Throws<ArgumentException>
            (
                () =>
                {
                    //Act
                    parameter.SinkLength = sourceValue;
                }
            );
        }

        [Test]
        public void SinkWidth_CorrectValue_ReturnCorrectValue()
        {
            //Setup
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter
            {
                SinkWidth = 500.00,
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter
            {
                DrainHoleDiameter = 50.00,
                CraneHoleDiameter = 40.00,
            };

            var sourceValue = 54.00;

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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter();
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
            var parameter = new SinkParameter
            {
                DrainHoleDiameter = 60.00,
                CraneHoleDiameter = 40.00,
            };

            var sourceValue = 55.00;

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