
namespace GettingIntoCAgain.CodeCademyApplications
{
    public class DeWarrior
    {
        public string sword;
        public string Sword
        { 
            get; set; 
        }
        public string name;
        public string Name
        {
            get; set; 
        }
        private int itemLevel;
        public int ItemLevel
        {
            get
            {
                return itemLevel;
            }
            set
            {
                if (itemLevel < 100)
                {
                    itemLevel = value;
                }
                else
                {
                    itemLevel = 100;
                }
            }
        }
        public DeWarrior(int itemLevel, string name, string sword)
        {
            Sword = sword;
            Name = name;
            ItemLevel = itemLevel;
        }
    }
}
