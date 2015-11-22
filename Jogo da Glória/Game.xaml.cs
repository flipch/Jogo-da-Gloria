using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Jogo_da_Glória
{
    /// <summary>
    /// The actual game page.
    /// </summary>
    public sealed partial class Game : Page
    {

        public int maxPlayers, currentPlayer = 1, currentPosition;

        Dictionary<String, int> allPositions = new Dictionary<string, int>();

        List<Player> allPlayers = new List<Player>();

        public Game()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            maxPlayers = (int)e.Parameter;
            Debug.WriteLine("There will be " + maxPlayers + " players in this game");

            #region gameText
            allPositions.Add("Ínicio!\n Beba e jogue o dado!", 0);
            allPositions.Add("Todos bebem!", 0);
            allPositions.Add("Aponte para a pessoa que irá beber.", 0);
            allPositions.Add("Você está com sorte! Você bebe.", 0);
            allPositions.Add("O jogador que está á sua esquerda bebe!", 0);
            allPositions.Add("Mande dois jogadores beberem!", 0);
            allPositions.Add("Todos bebem menos você", 0);
            allPositions.Add("Beba a quantia de dose correspondente ao número no dado", 0);
            allPositions.Add("Náo faça nada.", 0);
            allPositions.Add("Beba e volte 7 casas", -7);
            allPositions.Add("O dono do jogo bebe 3", 0);
            allPositions.Add("Todas as mulheres bebem.", 0);
            allPositions.Add("Todos voltam uma casa e realizam o desafio correspondente", -1);
            allPositions.Add("Todos os jogadores sem C,N ou H no nome bebem", 0);
            allPositions.Add("Beba 3 ou volta 8 casas.", -8);
            allPositions.Add("Jogue dado novamente, beba o número que ele mostrar", 0);
            allPositions.Add("Mande 3 jogadores beberem", 0);
            allPositions.Add("Os jogadores do seu lado bebem", 0);
            allPositions.Add("Todos os homem bebem", 0);
            allPositions.Add("Todos os jogadores usando preto bebem.", 0);
            allPositions.Add("A mulher que você apontar bebe 3", 0);
            allPositions.Add("Volte 10 casas", -10);
            allPositions.Add("Todos jogam o dado, quem tirar 6 VOLTA ao ÍNICIO", 0);
            allPositions.Add("Pode ir a casa de banho", 0);
            allPositions.Add("Jogue uma moeda\n CARA: Só você bebe \nCOROA: Todos bebem", 0);
            allPositions.Add("Jogue o dado, beba e volte para trás o número do resultado.", 0);
            allPositions.Add("Conte uma piada ou beba 4", 0);
            allPositions.Add("Beba e fica uma rodada sem jogar", 0);
            allPositions.Add("Beba com o DONO do jogo!", 0);
            allPositions.Add("Beba e volte 8 casas!", -8);
            allPositions.Add("Faça um brinde com todos os jogadores", 0);
            allPositions.Add("FIM!", 0);
            #endregion

            for (int i = 0; i < maxPlayers; i++)
            {
                allPlayers.Add(new Player(i + 1, 0)); //Initializes all players with their ID and Current Position
            }

            txt_current_player.Text = ("Jogador " + allPlayers.ElementAt(0).ID);
            txt_instructions.Text = allPositions.ElementAt(0).Key;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            if (currentPlayer == allPlayers.Last().ID)
                currentPlayer = 1;
            else
                currentPlayer = currentPlayer + 1;

            var player = allPlayers.ElementAt(currentPlayer - 1);

            txt_current_player.Text = ("Jogador " + player.ID);

            int seed = 0;
            if (!player.firstTime)
            { //If not start
              //Get seed of dice
                
                do
                {
                    seed = r.Next(7);
                } while (seed == 0);
                //Cant be 0 and must be less than 7
                player.currentPos = player.currentPos + seed;

                txt_instructions.Text = allPositions.ElementAt(player.currentPos).Key;

                player.currentPos = player.currentPos + allPositions.ElementAt(player.currentPos).Value;

            }
            else
            {
                player.firstTime = false;
            }
            //Prevent griefers
            /* this.button.IsEnabled = false;
             System.Threading.Tasks.Task.Delay(4000).Wait();
             this.button.IsEnabled = true;*/ //TODO
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
