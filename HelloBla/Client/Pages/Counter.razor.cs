using System;
using HelloBla.Client.CommonStuff;
namespace HelloBla.Client.Pages
{
	public partial class Counter
	{
        private int currentCount = 0;

        private Dice myDice = new Dice();

        private void IncrementCount(){
            currentCount++;
        }

        private string NumberColor {
            get {
                if (currentCount % 2 == 0)
                    return "red";
                else
                    return "black";
            }
        } 
    }
}

