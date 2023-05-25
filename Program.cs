using System;

namespace Aula
{
    class Program
    {
        //Gera matriz de int com numeros aleatorios
        public static int[,] FazMatriz(int c, int l){
            int[,] a= new int[l,c];
            Random num = new Random();

            //preencher linha e coluna
            for(int i=0;i< l;i++){
                for(int j=0;j < c;j++){
                    a[i,j]= num.Next(0,60);
                    Console.Write(a[i,j]+ " ");
                }
                Console.WriteLine();
            }


            //acessar o valor do item dentro da colecao/somar tds os intes
            foreach (int item in a){
                Console.WriteLine(item);
            }
            
                
            
            return a;
        }
        

        static void Main(string[] args)
        {
            //dando os valores da matriz
            int coluna = 2;
            int linha = 4;
            //criando enomeando a matriz
            int[,] teste = new int[linha, coluna];
            //puxando a funcao e declarando os parametros 
            teste = FazMatriz(coluna, linha);

            //total de itens da matriz
            int tamanho= teste.Length; 
            //total de dimensoes da matriz 
            int dimensao= teste.Rank;

            Console.WriteLine("O tamanho da mtriz é: "+ tamanho);
            Console.WriteLine("A dimensao da matriz é: "+ dimensao);
        }

    }
}
