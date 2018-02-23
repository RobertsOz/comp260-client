using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUD
{
    public class Player
    {
        public int playerID;

        public String playerClass = "";

       
        public static String[] allClasses = { "WARRIOR", "ARCHER", "BARD", "MAGE" };
        public List<String> availableClasses = new List<String>(allClasses);
        Dictionary<String,int> playerInventory;

        public void setClass(String pickedClass)
        {   
            for( int i=0; i < allClasses.Length; i++)
            {
                if (allClasses[i] == pickedClass)
                {
                    this.playerClass = pickedClass;
                    this.availableClasses.Remove(pickedClass);
                }
            }
        }
        public void addToInventory()
        {
            
        }
        
        
    }
}
