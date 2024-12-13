namespace day18homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            NPC1 smith = new SmithNPC(12,"Pergerson");
            NPC1 storage = new StorageNPC(7,"왕서방");
            NPC1 extra = new ExtraNPC(3,"레기오로스맨");
            NPC1[] npcs = { smith, storage, extra };
           // player.InteractWithNPC((smith as IInteractable));
            //player.InteractWithNPC((storage as IInteractable));
            player.ShowInteractable(npcs);
            //player.InteractWithNPC(extra);//작동 안함
        }
    }
}
