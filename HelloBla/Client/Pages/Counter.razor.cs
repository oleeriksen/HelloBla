using System;
namespace HelloBla.Client.Pages
{
	public partial class Counter
	{
        private int currentCount = 0;

        private string NumberColor
        {
            get
            {
                if (currentCount % 2 == 0)
                    return "red";
                else
                    return "black";
            }
        }

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}

