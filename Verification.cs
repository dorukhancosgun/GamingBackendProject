using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackendProject
{
    class Verification
    {
        public void PlayerControl(Player player, E_Devlet e_Devlet)
        {
            if (player.PlayerName == e_Devlet.E_devlet_Isim)
            {
                Console.WriteLine("Players name is verified.");
            }
            else
            {
                Console.WriteLine("Name is not verified.");
            }

            if (player.PlayerSurname == e_Devlet.E_devlet_Soyad)
            {
                Console.WriteLine("Surname is verified.");
            }
            else
            {
                Console.WriteLine("Surname is NOT verified.");
            }

            if (player.TcNo == e_Devlet.E_devlet_TcNo)
            {
                Console.WriteLine("TC No is verified.");
            }
            else
            {
                Console.WriteLine("TC No is NOT verified.");
            }

            if (player.PlayerBirthday == e_Devlet.E_devlet_Birthday)
            {
                Console.WriteLine("Birthday is verified.");
            }
            else
            {
                Console.WriteLine("Birthday is NOT verified.");
            }

        }
    }
}
