using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18homework
{
    abstract class NPC1
    {
        protected int _x;
        protected string _name;
        public NPC1()
        {
            _x = 0;
            _name = "";
        }
        public NPC1(int x, string name)
        {
            _x = x;
            _name = name;
        }
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    interface IInteractable
    {
        public void Interact();
    }
    class SmithNPC : NPC1, IInteractable
    {
        public SmithNPC(int x, string name):base(x,name)
        {
            _x = x;
            _name = name;
        }
        public void Interact()
        {
            Console.WriteLine("강화하시겠습니까?");
        }
    }
    class StorageNPC : NPC1, IInteractable 
    {
        public StorageNPC(int x, string name) : base(x, name)
        {
            _x = x;
            _name = name;
        }
        public void Interact()
        {
            Console.WriteLine("창고를 열겠습니까?"); 
        }
    }

    class ExtraNPC : NPC1
    {
        public ExtraNPC(int x, string name) : base(x, name)
        {
            _x = x;
            _name = name;
        }

    }


}
