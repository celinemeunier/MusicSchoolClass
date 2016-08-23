using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchoolClass.AsyncTask
{
    public class AsyncFactory
    {
        public void TestIt()
        {
            //CountTo10000();
            //await CountTo10000();
            //Attend l'execution du Task (oblige a mettre la methode en public async void) 
        }

        /* private Task CountTo10000()
         {
             Action count = new Action(() =>
             {
                 for (int i = 0; i < 10000; i++)
                 {
                     Console.WriteLine(i);
                 }
             });
             return Task.Run (count);*/

        private Task<Int32> CountTo10000withReturn()
        {
            Func<Int32> count = new Func<Int32>(() =>
            {
                int i = 0;
                for (; i < 10000; i++)
                {
                    Console.WriteLine(i);
                }
                return i;
            });
            return Task.Run(count);
        }
    }
}
