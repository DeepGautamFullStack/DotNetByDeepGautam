using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YAKapp
{
    public static class Utility
    {
        #region Start of read xml file
        /// <summary>
        /// This is the method which will load XML file from a given path and 
        /// convert that file in to IEnumerable<XElement>
        /// </summary>
        /// <param name="pathOfFile"></param>
        /// <returns>IEnumerable<XElement></returns>
        public static IEnumerable<XElement> ReadXml(string pathOfFile)
        {
            IEnumerable<XElement> herdEntries = new List<XElement>();
            try
            {
                XElement root = XElement.Load(pathOfFile);
                herdEntries = root.Elements();
            }
            catch (Exception)
            {
                //Call the logger class to log the exception
                throw;
            }

            return herdEntries;
        }
        #endregion End of read xml file

        public static IEnumerable<XElement> ReadFile(string pathOfFile,string fileType)
        {
            IEnumerable<XElement> herdEntries = new List<XElement>();
            try
            {
                XElement root = XElement.Load(pathOfFile);
                herdEntries = root.Elements();
            }
            catch (Exception)
            {
                //Call the logger class to log the exception
                throw;
            }

            return herdEntries;
        }

        #region Start of converting XElement to list of object
        /// <summary>
        /// This is the method which will accept IEnumerable<XElement> obj as parameter 
        /// and return you back a List<herd> object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>List<Herd></returns>
        public static List<Herd> ConvertXElementToObject(IEnumerable<XElement> obj)
        {
            List<Herd> listHerd = new List<Herd>();
            
            try
            {
                foreach (var item in obj)
                {
                    Herd herdObj = new Herd();
                    Console.WriteLine("Name:{0},Age:{1},Sex:{2}", item.Attribute("name").Value, item.Attribute("age").Value, item.Attribute("sex").Value);

                    herdObj.Name = item.Attribute("name").Value;
                    herdObj.Age = Convert.ToDecimal(item.Attribute("age").Value);
                    herdObj.Sex = item.Attribute("sex").Value;

                    listHerd.Add(herdObj);
                }
            }
            catch (Exception)
            {
                //Call the logger class to log the exception
                throw;
            }
            return listHerd;
        }
        #endregion End of converting XElement to list of object
    }
}
