using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YAKapp
{
    class Program
    {
        //This class has full flashed implementation of exception handling,
        //Logging the information and error by using Serilog, log provider and
        //It is having the unit test cases for each methods and 
        //every line of code can be understand by the any developer because of coding style, naming 
        //conventions and the proper region and xml comments.If it comes to implement in web api
        //I can go ahead and implement same in webapi along with Swagger ui to keep monitoring webapi methods.
        //Also it has the sepration of conerns where bussiness logic at one place and utility classes at different place.
        static void Main(string[] args)
        {
            #region  start of logger intilization
            var logger = new LoggerConfiguration()
                            .WriteTo.File(@"C:\Users\deepgautam\Documents\Visual Studio 2015\Projects\YAKapp\YAKapp\log.txt", LogEventLevel.Information)
                            .CreateLogger();
            #endregion end of logger intilization

            #region Start of User Story 1 implementaion
            try
            {
                //Read xml file via utility class
                var herdEntries = Utility.ReadXml(@"C:\Users\deepgautam\Documents\Visual Studio 2015\Projects\YAKapp\YAKapp\herd.xml");

                if (herdEntries != null)
                {
                    logger.Information("XML file load and read is successfull.");
                    //Convert Xml element data in to list of herd class object
                    var listOfHerd = Utility.ConvertXElementToObject(herdEntries);

                    if (listOfHerd.Count>0)
                    {
                        logger.Information("We have got " +listOfHerd.Count+ " Yak to calculate the milk.");
                        //Case 1 calculation for 13 days, which will trun as number 12 as per note given document
                        Bussiness bussinessObj = new Bussiness();
                        decimal milkProducedByAll = bussinessObj.GetMilkCalculation(listOfHerd, 13);

                        Console.WriteLine("Milk produced by-" + listOfHerd.Count + ",Yak is: " + milkProducedByAll +", ltr");
                        logger.Information("We have successfully calculated the milk produced by  " + listOfHerd.Count + ", Yak which comes-:"+ milkProducedByAll + ", ltr");

                    }
                }
                else
                {
                    //this is the case when xml file does not have the data
                    Console.Write("No data to read from the file.");
                    logger.Information("No data to read from the file.");
                }
            }
            catch (Exception ex)
            {

                //Call the logger class to log the exception
                logger.Error(ex.Message);
                 throw ex;
            }
            finally
            {
                Console.ReadLine();
            }
            #endregion End of User Story 1 implementaion
        }
    }

interface IFileImplementations
    {
        Dictionary<int, string> ReadFile(string filePath);
    }
}
