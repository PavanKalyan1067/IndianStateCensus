﻿using NUnit.Framework;
using IndianStateCensus;

namespace NunitIndianStateCensus.Test
{
    public class Tests
    {
        string indianStateHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        string indianStateCensusfilepath = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/IndiaStateCensusData.csv";


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
    }
}