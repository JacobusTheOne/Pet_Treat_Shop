using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Treat_Shop
{
    public class Treats
    {
        public int amountOfChewies { get; set; } = 0;
        public int amountOfVitamins { get; set; } = 0;
        public int amountOfBiscuits { get; set; } = 0;
        private float totalOwed { get; set; }
        public bool large { get; set; } = false;
        public bool weekend { get; set; } = false;
        public string CalculateAmount()
        {

            if (large)
            {
                totalOwed = amountOfChewies * 4.50f + amountOfVitamins * 4.15f + amountOfBiscuits * 3.75f;
            }
            else
            {
                totalOwed = amountOfChewies * 4.10f + amountOfVitamins * 2.50f + amountOfBiscuits * 2.00f;
            }
            
            if(weekend)
            {
                totalOwed *= 115f / 100f;
            }
            if( (amountOfBiscuits+amountOfChewies+amountOfVitamins) >= 20)
            {
                totalOwed *= 80f / 100f;
            } 
            if( amountOfChewies >= 10 && large)
            {
                totalOwed *= 90f / 100f;
            } 
            if( amountOfVitamins >= 7 && !large)
            {
                totalOwed *= 95f / 100f;
            }
            totalOwed += 2;
            // return String.Format("{0:C}",totalOwed); this formatting if you want to return in rand.
            return String.Format("{0}",Math.Round(totalOwed,2));
        }

        public void SetBucketSize(string bucketSize = "normal")
        {
            if (bucketSize.ToUpper() == "LARGE")
            {
                large = true;
            }
            else
            {
                large = false;
            }
        }

        public void SetWeekend(string isWeekend = "N")
        {
            if (isWeekend == "Y")
            {
                weekend = true;
            }
            else
            {
                weekend = false;
            }
        }
    }
}
