using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using YAKapp;

namespace YAKappUnitTest
{
    [TestClass]
    public class YAKAppUnitTest
    {
        #region Start of reading the file test case
        [TestMethod]
        public void ReadFile()
        {

            //Read xml file via utility class
            var herdEntries = Utility.ReadXml(@"C:\Users\deepgautam\Documents\Visual Studio 2015\Projects\YAKapp\YAKapp\herd.xml");

            if (herdEntries != null)
            {
                //Convert Xml element data in to list of herd class object
                Console.Write("File read is successful.");
            }
            else
            {
                //this is the case when xml file does not have the data
                Console.Write("No data to read from the file.");
            }
        }
        #endregion End of reading the file test case

        #region start of converting XML to object test case
        [TestMethod]
        public void ConvertXElementToObject()
        {

            //Read xml file via utility class
            var herdEntries = Utility.ReadXml(@"C:\Users\deepgautam\Documents\Visual Studio 2015\Projects\YAKapp\YAKapp\herd.xml");
            if (herdEntries != null)
            {
                //Convert Xml element data in to list of herd class object
                Console.Write("File read is successful.");
                var listOfHerd = Utility.ConvertXElementToObject(herdEntries);

                if (listOfHerd.Count > 0)
                {
                    Console.Write("Data conversion is successful.");
                }
            }
            else
            {
                //this is the case when xml file does not have the data
                Console.Write("No data to read from the file.");
            }
        }
        #endregion End of converting XML to object test case

        #region Start of calculation of milk test case
        [TestMethod]
        public void GetCalculationForMilk()
        {

            //Read xml file via utility class
            var herdEntries = Utility.ReadXml(@"C:\Users\deepgautam\Documents\Visual Studio 2015\Projects\YAKapp\YAKapp\herd.xml");
            if (herdEntries != null)
            {
                //Convert Xml element data in to list of herd class object
                Console.Write("File read is successful.");
                var listOfHerd = Utility.ConvertXElementToObject(herdEntries);

                if (listOfHerd.Count > 0)
                {
                    //Case 1 calculation for 13 days, which will trun as number 12 as per note given document
                    Bussiness bussinessObj = new Bussiness();
                    decimal milkProducedByAll = bussinessObj.GetMilkCalculation(listOfHerd, 13);
                }
            }
            else
            {
                //this is the case when xml file does not have the data
                Console.Write("No data to read from the file.");
            }

        }
        #endregion End of calculation of milk test case
    }
}
