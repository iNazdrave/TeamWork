using Alpha_Records_WPF.Contracts;
using System;
using System.Collections.Generic;

namespace Alpha_Records_WPF.Utils
{
    public static class Validator
    {
        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void EmptySlotForPresentation (IEnumerable<IPresentation> listOfPresentations, DateTime date, string message)
        {
            foreach (IPresentation pres in listOfPresentations)
            {
                int presentationCounter = 0;
                if (pres.Date == date)
                {
                    presentationCounter++;
                }
                if (presentationCounter >= 6)
                {
                    throw new ArgumentNullException(message);
                }
            }
        }        
    }
}
