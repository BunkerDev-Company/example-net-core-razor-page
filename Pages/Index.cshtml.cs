using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ExampleApplication.Pages
{
    public class IndexModel : PageModel
    {
        public string Text = "";
        public void OnGet()
        {
            int d = 0;
            decimal year = 2015;

            int blabla = 0;

            for (int i = 0; i < 10; i = i + 1)
            {
                blabla = blabla + i;
            }

            if (year == 2016)
            {
                Text = "Больше 2016 " + blabla;
            }
            if (year == 2017)
            {

            }
            else
            {
                Text = "Меньше 2016 ";
            }
            MyMethod();
            switch (year)
            {
                case 2016:

                    break;
                case 2017:

                    break;
            }
        }

        public void MyMethod()
        {
            Console.WriteLine("Привет мир из консоли!");
        }
    }
}
