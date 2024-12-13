using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18homework
{
    internal class Player
    {
        int _x=5;
        public void InteractWithNPC(IInteractable npc)
        {
            npc.Interact();
        }
        public void ShowInteractable(NPC1[] npcs)
        {
            foreach (var npc in npcs)
            {
                if (Math.Abs(_x - npc.x) < 5)
                {
                    if (npc is IInteractable)
                    {
                        Console.WriteLine(npc.name);
                    }
                }
            }
        }
    }
}
