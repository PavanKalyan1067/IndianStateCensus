﻿using NUnit.Framework;
using IndianStateCensus;
namespace NunitIndianStateCensus.Test
{
    public class Test
    {
        string indianStateHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        string indianStateCensusfilepath = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/IndiaStateCensusData.csv";
        string wrongfiletype = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/IndiaStateCensusData.txt";
        string wrongfile = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/IndiaStateCensus.csv";
        string delimiterwrong = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/DelimiterIndiaStateCensusData.csv";
        string wrongHeaders = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/WrongIndiaStateCensusData.csv";
        [Test]
        public void GivenCSVfile_ReturnsNumberOfRecord()
        {
            //Arrange
            int expected = 29;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(indianStateCensusfilepath, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }
        [Test]
        public void GivenCSVfileIncorrect_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(wrongfile, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectFiletype_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(wrongfiletype, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectDelimiter_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(delimiterwrong, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }

        [Test]
        public void GivenIncorrectHeaders_ReturnsCustomException()
        {
            //Arrange
            int expected = 0;
            //Act
            StateCensus stateCensus = new StateCensus();
            int totalRecords = stateCensus.GetData(wrongHeaders, indianStateHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }
    }
}

