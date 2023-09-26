
namespace OOP
{
    internal class Character
    {
        public int HP = 100;
        int DMG = 5;

        void Damage(int x)
        {
            HP -= x;
        }

        public void Attack(Character c)     //VOID skickar inte tillbaka ett värde men
                                            // modifierar något
        {
            c.Damage(DMG);
        }

    }
}
