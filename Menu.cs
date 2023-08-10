using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Task
{
    internal class Menu
    {
        private string title;
        private List<string> menuItems;

        public Menu(string title)
        {
            this.title = title;
            menuItems = new List<string>();
        }

        public void AddMenuItem(string item)
        {
            menuItems.Add(item);
        }

        public void Show()
        {
            Console.WriteLine(title + ":");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
            }
        }
    }

}
