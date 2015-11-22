using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Glória
{
    class Positions
    {
        public String currentPosition { get; set; }

        public Positions()
        {
            List<String> allPositions = new List<string>();

            allPositions.Add("Ínicio!\n Beba e jogue o dado!");
            allPositions.Add("Todos bebem!");
            allPositions.Add("Aponte para a pessoa que irá beber.");
            allPositions.Add("Você está com sorte! Você bebe.");
            allPositions.Add("O jogador que está á sua esquerda bebe!");
            allPositions.Add("Mande dois jogadores beberem!");
            allPositions.Add("Todos bebem menos você");
            allPositions.Add("Beba a quantia de dose correspondente ao número no dado");
            allPositions.Add("Náo faça nada.");
            allPositions.Add("Beba e volte 7 casas");
            allPositions.Add("O dono do jogo bebe 3");
            allPositions.Add("Todas as mulheres bebem.");
            allPositions.Add("Todos voltam uma casa e realizam o desafio correspondente");
            allPositions.Add("Todos os jogadores sem C,N ou H no nome bebem");
            allPositions.Add("Beba 3 ou volta 8 casas.");
            allPositions.Add("Jogue dado novamente, beba o número que ele mostrar");
            allPositions.Add("Mande 3 jogadores beberem");
            allPositions.Add("Os jogadores do seu lado bebem");
            allPositions.Add("Todos os homem bebem");
            allPositions.Add("Todos os jogadores usando preto bebem.");
            allPositions.Add("A mulher que você apontar bebe 3");
            allPositions.Add("Volte 10 casas");
            allPositions.Add("Todos jogam o dado, quem tirar 6 VOLTA ao ÍNICIO");
            allPositions.Add("O jogador que estiver mais longe do fim, bebe!");
            allPositions.Add("Jogue uma moeda\n CARA: Só você bebe \nCOROA: Todos bebem");
            allPositions.Add("Jogue o dado, beba e volte para trás o número do resultado.");
            allPositions.Add("Conte uma piada ou beba 4");
            allPositions.Add("Beba e fica uma rodada sem jogar");
            allPositions.Add("Beba com o DONO do jogo!");
            allPositions.Add("Beba e volte 8 casas!");
            allPositions.Add("Faça um brinde com todos os jogadores. Se leste isto corretamente VOLTA AO ÍNICIO");
            allPositions.Add("FIM!");
        }
    }
}
