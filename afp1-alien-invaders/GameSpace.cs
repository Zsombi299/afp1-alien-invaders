using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace afp1_alien_invaders
{
    internal static class GameSpace
    {
        private static Random rnd = new Random(); //private mert önző vagyok >:3 muhaha
        private static Entity[,] field = new Entity[9, 7];

        static int[] hp = { 1, 2, 5, 10 };
        static string[] name = {"Sentinel", "Guardian", "Protector", "Titan"};
        static Image[] txtres = { Image.FromFile("enemy1.png"), Image.FromFile("enemy2.png"), Image.FromFile("enemy3.png"), Image.FromFile("enemy4.png") };
        static Player player = null;

        public static void InitializeField(int difficulty) {
            /*
            - fel kell tölteni a pályát alienekkel meg egy játékossal 
            - kell csinálni egy "buffer" sort ami nem látszódik és nem lehet
                lőni rá ami majd a következő lesz
            - kell hogy mozogjanak maguktól az enemyk és gombra a player (az lehet nem ez a class lesz hanem a saját)
            - kell elkezdenem a mystical agriculturt minecraftban
            - meg a powaht
            - kell egy cigi
            - kell majd egy szerver amin lesznek a játékos scoreok (ha akarjuk online tartani)
            */
            player = new Player((3 - difficulty), Image.FromFile("player.png"));

            for(int i = 0; i < 3; i++) {
                for (int j = 0; j < field.GetLength(1); j++) { // lehet nem hajnali 4kor kéne programoznom
                    int enemyId = rnd.Next(0, hp.Length);
                    field[i, j] = new Enemy(hp[enemyId], name[enemyId], txtres[enemyId], player); //4:24 AM
                }
            }

            Tick();
        }

        private static void Tick() {
            for (int i = 0; i < field.GetLength(0); i++) {
                for (int j = (field.GetLength(1) - 1); j > -1; j++) {
                    if (field[i, j] is Enemy) {
                        Enemy enemy = field[i,j] as Enemy;
                        enemy.Mv();

                    } //4:39 AM
                }
            }
            Enemy[] buffer = new Enemy[field.GetLength(0)];
            for (int i = 0; i < buffer.GetLength(0); i++) {
                int enemyId = rnd.Next(0, hp.Length);
                buffer[i] = new Enemy(hp[enemyId], name[enemyId], txtres[enemyId], player);
            }
            for(int i = 0; i < buffer.GetLength(1); i++) {
                field[i, 0] = buffer[i];
            }
        }
    }
}
