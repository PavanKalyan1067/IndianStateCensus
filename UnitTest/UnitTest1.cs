﻿using System;
using IndianStateCensus;
using NUnit.Framework;

namespace NunitIndianStateCensus.Test
{
    class StateCodeTestCases
    {
        string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        string indianStateCodefilepath = @"/Users/nikhilgoud/Projects/Assaignments/IndianStateCensus/IndianStateCensus/Indian state census data/IndiaStateCode.csv";

        [Test]
        public void GivenCSVfile_ReturnsNumberOfRecord()
        {
            //Arrange
            int expected = 37;
            //Act
            StateCensusAnalyser stateCensus = new StateCensusAnalyser();
            int totalRecords = stateCensus.GetStateCodeData(indianStateCodefilepath, indianStateCodeHeaders);
            //Assert
            Assert.AreEqual(expected, totalRecords);
        }
    }
}