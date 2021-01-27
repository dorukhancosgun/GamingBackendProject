using GamingBackendProject;
using System;

namespace GamingBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.PlayerName = "Magnus";
            player1.PlayerSurname = "Carlsen";
            player1.TcNo = "245165496";
            player1.PlayerBirthday = "30.11.1990";

            Player player2 = new Player();
            player2.PlayerName = "Hikaru";
            player2.PlayerSurname = "Nakamura";
            player2.TcNo = "996526512";
            player2.PlayerBirthday = "9.12.1987";

            E_Devlet eDevletPlayerInformation1 = new E_Devlet();
            eDevletPlayerInformation1.E_devlet_Isim = "Magnus";
            eDevletPlayerInformation1.E_devlet_Soyad = "Carlsen";
            eDevletPlayerInformation1.E_devlet_TcNo = "245165496";
            eDevletPlayerInformation1.E_devlet_Birthday = "30.11.1990";

            Game game1 = new Game();
            game1.GameName = "Cyberpunk";
            game1.GamePrice = 249;

            Game game2 = new Game();
            game2.GameName = "Age of Empires II";
            game2.GamePrice = 31;

            Game game3 = new Game();
            game1.GameName = "Assasin's Creed: Odyssey";
            game1.GamePrice = 249;

            Game game4 = new Game();
            game1.GameName = "SpiderMan: Miles Morales";
            game1.GamePrice = 499;


            Verification verification = new Verification();
            verification.PlayerControl(player1, eDevletPlayerInformation1);

            Console.WriteLine("------------------------------");

            ICampaignServices campaignManager = new CampaignManager();
            campaignManager.CampaignEntry(game1);
            campaignManager.DeleteCampaign(game1);
            campaignManager.UpdateCampaign(game1);

            Console.WriteLine("----------------------------");

            IPlayerServices playerManager = new PlayerManager();
            playerManager.NewPlayer(player1);
            playerManager.DeletePlayer(player1);
            playerManager.UpdatePlayer(player1);

            Console.WriteLine("-------------------------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.GameSale(player1, game2);

            Console.WriteLine("------------------------------");

            Console.ReadLine();
		}
    }
}
