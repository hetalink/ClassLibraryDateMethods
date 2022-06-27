using System;

namespace ClassLibraryDateMethods
{
    public class Class1
    {
        public bool FutureDate(DateTime date)
        {
            DateTime now = DateTime.Today;
            TimeSpan isFuture = now - date;
            int days = Convert.ToInt32(isFuture.Days);

            if (days < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
