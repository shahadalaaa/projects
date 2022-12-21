using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number, perfectOrnot, sum;

            Console.WriteLine("enter the first number") ;
            int start =int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int end = int.Parse(Console.ReadLine());
            // if the user entered the first number but its bigger than the second number so  will swap them 
            if(start > end)
            {
                int swap = start;
                start = end;
                end = swap;
            }
              Console.WriteLine();
            // هنا بيبتدي عد وبيخبتر  من اول رقم لحد اخر رقم دخله اليوزر     والشرط انه يقف عند الرقم التاني 
            for(number=start; number<=end; number++)
            {
                perfectOrnot = 1; //  وسميته برفكت او نت  عشان يدل على استعمال المتغير دا بدات اقسم من رقم واحد عشان البرفكت نمبر مش ليها علاقه بالقسمه على صفر او نفسها 
                 
                sum=0; //متغير حطيته عشان ابقى احط فيه مجموع العوامل  الي الرقم بيبقبل القسمه عليها وبتكون عوامله  

                while(perfectOrnot < number) //  هنا الشرط بتاعي انه العمليه هتتكرر لحد ما  العامل الي هقسم عليه ميبقاش يساوي الرقم او اكبر منه 
                {
                    if(number % perfectOrnot == 0) // هنا ببدا اشوف اذا هو قابل للقسمه عليه ولا لا لو قابل يبقى من عوامله ولما الشرط يتحقق  
                    {
                        sum += perfectOrnot; //  هنا بجمع العوامل الي الرقم  قابل القسمه عليها وبخزنها في المتغير  سم كل ما  الشرط يتحقق
                    }
                    perfectOrnot++; //هنا بزود العامل واحد وارجع اكرر العمليه عشان اشوفه من عوامل الرقم ولا لا وارجع اعيد العمليه لحد ما الشرط ميتحققش   
                }
                if(sum==number) //   هنا قا بشوف هل مجموع العوامل بتساوي الرقم ولا لا لو بتساويه يبقى برفكت  
                {
                    Console.WriteLine(number);
                }
            
            }



        }
    }
}
