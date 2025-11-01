using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace afp1_alien_invaders {
    internal static class GameSpace {
        private static Random rnd = new Random(); //private mert önző vagyok >:3 muhaha
        private static Entity[,] field = new Entity[9, 7]; // játéktér

        // Enemy statok -----------------------------------------------------------------------------------------------------------------------------------
        static int[] hp = { 1, 2, 5, 10 };
        static string[] name = {"Sentinel", "Guardian", "Protector", "Titan"};
        static Image[] txtres = { Image.FromFile("enemy1.png"), Image.FromFile("enemy2.png"), Image.FromFile("enemy3.png"), Image.FromFile("enemy4.png") };
        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //player deklarálása
        static Player player = null;
        public static Entity[,] Field { get; }

        public static void InitializeField(byte difficulty) {
            /*
            - kell majd egy szerver amin lesznek a játékos scoreok (ha akarjuk online tartani)
            */
            player = new Player((byte)(4 - difficulty), Image.FromFile("player.png"));                                      // játékos inicializálás

            for(int i = 0; i < 3; i++) {
                for (int j = 0; j < field.GetLength(1); j++) {                                                              // lehet nem hajnali 4kor kéne programoznom
                    int enemyId = rnd.Next(0, hp.Length);
                    field[i, j] = new Enemy(hp[enemyId], name[enemyId], txtres[enemyId], player);                           //random fajta enemy
                    field[i, j].XCoord = i;
                }
            }
            Thread tick = new Thread(Tick);                                                                                 //külön mennek az enemyk
            Thread plyr = new Thread(() => player.Move());                                                                  // és külön a player
            plyr.Start();
        }

        private static void Tick() {
            for (int i = 0; i < field.GetLength(0); i++) {
                for (int j = (field.GetLength(1) - 1); j > -1; j++) {
                    if (field[i, j] is Enemy) {                                                                             // ha enemy akkor mozogjon
                        Enemy enemy = field[i,j] as Enemy;
                        enemy.Mv();
                    }
                }
            }
            Enemy[] buffer = new Enemy[field.GetLength(0)];                                                                 // buffer amit majd feltöltünk a pályára
            for (int i = 0; i < buffer.GetLength(0); i++) {
                int enemyId = rnd.Next(0, hp.Length);
                buffer[i] = new Enemy(hp[enemyId], name[enemyId], txtres[enemyId], player);
            }
            for(int i = 0; i < buffer.GetLength(1); i++) {                                                                  // itt pedig fel is töltjük
                field[i, 0] = buffer[i];
            }
            Thread.Sleep(500);                                                                                              // kell a Thread.Sleep mert nem akarjuk hogy
            Tick();                                                                                                         // instant lent legyenek az enemyk xd
        }
    }
}
