using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAKapp
{
   public  class Bussiness
    {
        #region Start of Milk calculation
        /// <summary>
        /// This is the method to calculate milk produced by yaklab
        /// for each yaks combined
        /// </summary>
        /// <param name="listOfHerd"></param>
        /// <param name="calculationForDays"></param>
        /// <returns></returns>
        public decimal GetMilkCalculation(List<Herd> listOfHerd, int calculationForDays)
        {
            decimal producedMilk = 0.0m;
            decimal dayForMilkCalculation = 0.0m;
            decimal daysMultiplicationFactor = 0.03m;
            int daysInYear = 100;

            //formula to calculate milk is 50-D*0.0.3 is fixed
            //1 years is 100 days
            try
            {
            foreach (var herd in listOfHerd)
            {
                dayForMilkCalculation = herd.Age * daysInYear;
                decimal milkProdcuedByEach = (50-(dayForMilkCalculation * daysMultiplicationFactor)) * calculationForDays;
                producedMilk = producedMilk + milkProdcuedByEach;
            }
            }
            catch (Exception)
            {

                throw;
            }
            return producedMilk;
        }
        #endregion End of Milk calculation
    }
}
