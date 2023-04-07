//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //exercicio 1
//            int metros, cm, mm;
//                Console.WriteLine("Digite o numero de matros: ");
//              metros = int. Parse(Console.ReadLine());
//            cm = metros * 100;    
//            mm = metros * 1000;
//            Console.WriteLine("A quantidade em cm é:  " + cm);
//            Console.WriteLine("A quantidade em mm é:  " +mm);
//            Console.ReadKey();

//        }
//    }
//}




//exrecicio 2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
////            int fa1, resint
////              float fa2, resfloat
////              Console.WriteLine("etre com a temperatura em farenheit int: ");
////            fa1 = int.Parse(Console.ReadLine());
////            Console.WriteLine("etre com a temperatura em farenheit float: ");
////            fa2 = float.Parse(Console.ReadLine());

////            resint = (fa1 - 32) * (5 / 9);
////            resfloat = (fa2 - 32.0f) * (5.0f / 9.0f);

////            Console.WriteLine("resultado float: " + resfloat);
////            Console.WriteLine("resultado int: " + resint);
////            Console.ReadKey;







////        }
////    }
////}




////exercicio 3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//float peso, altura, res;
//            Console.WriteLine("digite o peso da pessoa desejada: ");
//            peso = float.Parse(Console.ReadLine());
//            Console.WriteLine("digite a altura da pessoa desejada: ");
//            altura = float.Parse(Console.ReadLine());

//            res = peso / (altura * altura);

//            Console.WriteLine("Resultado imc: " + res);
//            Console.ReadKey();






//        }
//    }
//}


//exercicio 4
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float peso1, peso2, peso3, valor1, valor2, valor3, res;

//            Console.WriteLine("Digite o primeiro peso desejado: ");
//            peso1 = float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o segundo peso desejado: ");
//            peso2 = float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o terceiro peso desejado: ");
//            peso3 = float.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o primeiro valor desejado: ");
//             valor1= float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o segundo valor desejado: ");
//             valor2= float.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o terceiro valor desejado: ");
//             valor3= float.Parse(Console.ReadLine());

//            res = (peso1*valor1 +  peso2*valor2 + peso3*valor3) / (peso1 + peso2 + peso3);

//            Console.WriteLine("O valor da media ponderada é: " + res);
//            Console.ReadKey();







//        }
//    }
//}




//exerciocio 5
//ondas estacionarias
//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace lista1pr2
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            float tamanhoonda, frequencia, res;

//            console.writeline("digite o tamanho da onda: ");
//            tamanhoonda = float.parse(console.readline());
//            console.writeline("digite a frequencia da onda: ");
//            frequencia = float.parse(console.readline());

//            res = tamanhoonda * frequencia;
//            console.writeline("a velocidade da onda é: "  + res + "  m/s);
//            console.readkey();










//        }
//    }
//}




//exercicio 6
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float salario, res, por;

//            Console.WriteLine("Digite o salario que deseja acrescentar 25%: ");
//            salario = float.Parse(Console.ReadLine());


//            por = (salario * 25) / 100;
//            res = salario + por;


//                Console.WriteLine("Seu salario com o acrescimo de 25% é: " + res);
//                Console.ReadKey();  


//        }
//    }
//}


//EXERCICIO 7
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float dolar, real;

//            Console.WriteLine("Digite um valor em Reais: ");
//            real= float.Parse(Console.ReadLine());

//            dolar = real / 5.20f;

//            Console.WriteLine("o Valor em dolar é: " + dolar + "  dolar");
//            Console.ReadKey();



//        }
//    }
//}





//EXERCICIO 8
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int num, triplo, dobro, res, sucessorTriplo, antecessorDobro;

//            Console.WriteLine("Digite um numero inteiro: ");
//            num = int.Parse (Console.ReadLine());

//            triplo = num * 3;
//            dobro = num * 2;

//            sucessorTriplo = triplo + 1;
//            antecessorDobro = dobro - 1;

//            res = sucessorTriplo + antecessorDobro;

//            Console.WriteLine("O resultado da soma do sucessor de seu triplo com o antecessor de seu dobro é: " + res);
//            Console.ReadKey();



//        }
//    }
//}




//EXERCICIO 9
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num, linha1, linha2, linha3, linha4;
//                Console.WriteLine("Digite um numero com 4 digitos: ");
//                num = int.Parse(Console.ReadLine());

//            linha1 = num / 1000;
//                 Console.WriteLine(linha1);
//            num = num % 1000;
//            linha2 = num / 100;
//                Console.WriteLine(linha2);
//            num = num % 100;
//            linha3 = num / 10;
//                Console.WriteLine(linha3);
//            linha4 = num % 10;
//                Console.WriteLine(linha4);

//            Console.ReadKey();








//        }
//    }
//}






//exercicio 10
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            float investimento = 1000.0f;
//            float dia1 = -0.034f;
//            float dia2 = 0.028f;
//            float dia3 = 0.14f;
//            float dia4 = -0.085f;


//            investimento = investimento * (1 + dia1);
//            investimento = investimento * (1 + dia2);
//            investimento = investimento * (1 + dia3);
//            investimento = investimento * (1 + dia4);

//            Console.WriteLine($"O valor atual do investimento de Marquesito é: R$"+ investimento);
//            Console.ReadKey();



//        }
//    }
//}





//EXERCICIO11
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float numero, quadrado, cubo ;

//            Console.WriteLine("Digite um numero: ");
//            numero = float.Parse(Console.ReadLine());

//            quadrado = numero * numero;
//            cubo = (numero * numero)* numero;

//            Console.WriteLine("o numero ao quadrado é: " + quadrado);
//            Console.WriteLine("o numero ao cubo é: " + cubo);
//            Console.ReadKey();




//        }
//    }
//}







//EXERCICIO 12
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lista1PR2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float Hh,Hm, homem, mulher;

//            Console.WriteLine("entre com a altura da pessoa do sexo masculino desejada para saber seu peso ideal: ");
//            Hh = float.Parse(Console.ReadLine());
//            Console.WriteLine("entre com a altura da pessoa do sexo feminino desejada para saber seu peso ideal: ");
//            Hm = float.Parse(Console.ReadLine());


//            homem = (72.7f * Hh) -58;
//            mulher = (62.1f * Hm) - 44.7f;

//            Console.WriteLine("O peso proporcional a sua altura do sexo masculino é: " + homem);
//            Console.WriteLine("O peso proporcional a sua altura do sexo feminino é: " + mulher);
//            Console.ReadKey();




//        }
//    }
//}



//EXERCICIO 13
// O GIT é um Sistema de Controle de Versões Distribuído.
//Estes sistemas de controle possuem a função de registrar quaisquer alterações feitas em cima de um código,
// armazenando essas informações e permitindo que, caso seja necessário, um(a) programador(a) possa regredir a
// versões anteriores de uma aplicação de modo simples e rápido.
//Este tipo de sistema também simplifica muito o processo de compartilhamento de um projeto com um time,
// por exemplo, ou com outros(as) programadores(as).

//O GITHUB é uma espécie de rede social voltada a profissionais de TI cuja tecnologia que o sustenta é o GIT.
// é uma plataforma totalmente online onde você pode criar repositórios e hospedar neles seus projetos,
//e interagir com códigos de terceiros.


//10 COMANDOS DO GIT:

//1. Git clone
//Git clone é uma comando para baixar o código-fonte existente de um repositório remoto (como, por exemplo,
// o Github). Em outras palavras, git clone, basicamente, faz uma cópia idêntica da versão mais recente de um
// projeto em um repositório e a salva em seu computador.

//2. Git branch
//Branches(algo como ramificações, em português) são altamente importantes no mundo do git. Usando as branches,
// vários desenvolvedores conseguem trabalhar em paralelo no mesmo projeto simultaneamente. Podemos usar o 
//comando git branch para criar, listar e excluir as branches.

//3. Git checkout
//Esse também é um dos comandos do Git mais usados. Para trabalhar em uma branch, primeiro, é preciso "entrar"
// nela. Usamos git checkout, na maioria dos casos, para trocar de uma branch para outra. Também podemos usar o
// comando para fazer o checkout de arquivos e commits.

//4. Git status
//O comando git status nos dá todas as informações necessárias sobre a branch atual.
//Obtemos as seguintes informações:
//Se a branch em que estamos no momento está atualizada
//Se precisamos fazer o commit, push ou pull de algo
//Se os arquivos estão em fase de stage, fora dessa fase ou se não estão sendo rastreados
//Se arquivos foram criados, modificados ou excluídos.

//5.Git add
//Ao criarmos, modificarmos ou excluirmos um arquivo, essas alterações acontecerão em nosso espaço de trabalho 
//local e não serão incluídas no próximo commit (a menos que alteremos as configurações).
//Precisamos usar o comando git add para incluir as alterações de um ou vários arquivos em nosso próximo commit.

//6.Git commit
//Talvez esse seja o comando mais usado do Git. Quando chegamos a determinado ponto em desenvolvimento,
// queremos salvar nossas alterações (talvez após uma tarefa ou resolução de problema específica).
//Git commit é como definir um ponto de verificação no processo de desenvolvimento. Você pode voltar a esse
// ponto mais tarde, se necessário.

//7. Git push
//Após fazer o commit de suas alterações, a próxima coisa a fazer é enviar suas alterações ao servidor remoto.
// Git push faz o upload dos seus commits no repositório remoto.

//8.Git pull
//O comando git pull é usado para obter as atualizações de um repositório remoto. Esse comando é uma
// combinação de git fetch e git merge, o que significa que, quando usamos git pull, ele recebe as atualizações
// do repositório remoto (git fetch) e aplica imediatamente as alterações mais recentes em seu espaço de 
//trabalho local (git merge).

//9. Git revert
//Às vezes, precisamos desfazer as alterações que fizemos. Existem várias maneiras de se desfazer as alterações
// em nosso espaço de trabalho local ou remotamente (dependendo do que você necessita), mas devemos usar esses
//comandos com cuidado para evitar exclusões indesejadas.

//10. Git merge
//Quando você concluir o desenvolvimento em sua branch e quando tudo funcionar bem, a etapa final é fazer o
// merge (mesclar ou unir, em português) da branch com a branch pai (dev ou master/main, em geral). Isso é 
//feito com o comando git merge.
//Git merge, basicamente, integra sua branch com o recurso e todos os seus commits na branch de desenvolvimento
// (dev) ou na branch principal (master ou main). É importante lembrar que, primeiro, você precisa estar na
// branch específica na qual você quer fazer o merge de sua branch com o recurso.

