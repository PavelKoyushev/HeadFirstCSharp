using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_IClown
{

    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    class TallGuy : IClown
    {
        public string Name;

        public int Height;

        public string FunnyThingIHave { get { return "большие ботинки"; } }

        public void Honk() { MessageBox.Show("Би! Би!" + FunnyThingIHave); }

        public void TalkAboutYourself()
        {
            MessageBox.Show("Мое имя " + Name + " мой рост " + Height + " см.");
        }
    }
}
