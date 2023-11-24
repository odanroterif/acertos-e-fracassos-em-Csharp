using System; //usa e gerencia o sistema para executar app
using System.Collections.Generic;
using System.Linq;
using System.Text; //manipula/altera texto
using System.Threading.Tasks; //lida com multithread
//using System.IO = altera arquivos do seu sistema
//using system.net = para aplicações que se conectam a rede

namespace testes1
{
    class Program //inicio do programa 
    {
        static void Main(string[] args) //função
        {
         var texto = "digite algum número: "; /* var: em C#, declara variavel sem definir tipo
        o var texto agora mesmo se trata de uma string,quando o C# identifica o tipo ela não
            muda*/
            /*dynamic color = "azul"; //dynamic: a mesma coisa do var com a diferença de que
             a variavel pode mudar o seu tipo ao longo do código, veja abaixo como mudo color
            de string para int
            color = 54346; */
         int number;
            /*long number = 5; long: é um int que suporta mais números, enquanto int é largunra 
              32 bits (suporta de -2.147.483.648 atee 2.147.483.647) o long é largura 64 bits
             e suporta valores de -9.223.372.036.854.775.808 ate 9.223.372.036.854.775.807)
             
         /*float = 3.2f;// no C# é necessado sufixo para sinalar número decimal
         (f para floats d para doubles e m para decimal)
         decimal/double = //também se referem a números quebrados/float
         floar(é 32 bits) = //representa números com decimais menores, usado principalmente em 
         bibliotecas gráficas e em situações onde erros de arredondamento não são muito importantes 
         vai até 7 casas decimais
         double(é 64 bits) = //15-17 digitos, tem maior precisão
         decimal(é 128 bits) = //decimais menores com maior precisão, usado em aplicação
         financeira para evitar erro */
            //----------------------------------------------------
            Console.Write(texto); // write: exibe texto sem pular linha
         Console.WriteLine("5 + "); //writeline: exibe texto pulando linha, é o \n do C#
            number = Convert.ToInt32(Console.ReadLine());
            /*read e readline sempre leram string, idependente do tipo da variavel ou função
             então os comandos convert.To são necessario para que o read/readline leia
            a variavel como ela deveria ser lida, neste caso ela é int, o 32 é por que os ints
            são variaveis inteiras de 32 bits, ja los longs são de 64 bits*/
            Console.WriteLine("resultado: " + (5 + number));
            Console.ReadLine(); //esse readline no final evita que o promt feche na minha cara
        }
    }
}

