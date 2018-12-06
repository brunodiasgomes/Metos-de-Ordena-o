using System;
using System.Diagnostics;

class TPordenação
{

    static void Preencher(int[] vetor1,int[]vetor2, int[]vetor3)
    {
        
        for (int i = 0; i <= vetor1.Length - 1; i++)
        {
           
            vetor1[i] = i+ 1 ;

        }
        for (int i = vetor2.Length - 1; i >= 1; i--)
        {
            vetor2[i] = i+ 1;

        }
        
        for (int i = 0; i <= vetor3.Length - 1; i++)
        {
            vetor3[i] = RandomNumber(0, 10000);

        }
    }

       
    public static void Main()
    {
        
        int[] vetor1;
        int[] vetor2;
        int[] vetor3;
        
        bool sair = false;
        do
        {
            Console.Write("Contagem de tempo de ordenação\n" +
            "Menu [1] = BubbleSort\n" +
            "Menu [2] = InsertionSort\n" +
            "Menu [3] = SelectionSort\n" +
            "Menu [4] = MergeSort\n" +
            "Menu [5] = QuickSort\n" +
            "Insira o numero para o menu:\n");
            Stopwatch timer = new Stopwatch();

            bool bubble = false;
            bool insertion = false;
            bool selection = false;
            bool merge = false;
            bool quick = false;

            var menu = Console.ReadKey();
            Console.WriteLine("\n");
            
            if (bubble = menu.KeyChar == '1')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);
                                                                                    
                timer.Start();
                bubbleSort(vetor1);
                bubbleSort(vetor2);
                bubbleSort(vetor3);

                timer.Stop();
                
                TimeSpan tempoBubble = timer.Elapsed;

                 
                Console.WriteLine(tempoBubble.TotalMinutes);


                Console.WriteLine("\nO tempo do Bubble Sort foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble.Minutes, tempoBubble.Seconds, tempoBubble.Milliseconds);

                timer.Reset();
            }
            else if (insertion = menu.KeyChar == '2')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                InsertionSort(vetor1);
                InsertionSort(vetor2);
                InsertionSort(vetor3);
                timer.Stop();
                TimeSpan tempoInsertion = timer.Elapsed;
                
                Console.WriteLine(tempoInsertion.TotalMinutes);

                Console.WriteLine("O tempo do Insertion Sort foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion.Minutes, tempoInsertion.Seconds, tempoInsertion.Milliseconds);

                timer.Reset();
            }
            else if (selection = menu.KeyChar == '3')
            {

                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                SelectionSort(vetor1);
                SelectionSort(vetor2);
                SelectionSort(vetor3);
                timer.Stop();
                TimeSpan tempoSelection = timer.Elapsed;

                
                Console.WriteLine(tempoSelection.TotalMinutes);

                Console.WriteLine("O tempo do Selection Sort foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection.Minutes , tempoSelection.Seconds, tempoSelection.Milliseconds);

                timer.Reset();
            }
            else if (merge = menu.KeyChar == '4')
            {

                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                MergeSort(vetor1, vetor1[0], (vetor1.Length - 1));
                MergeSort(vetor2, (vetor2.Length - 1), vetor2[0]);
                MergeSort(vetor3, vetor3[0], (vetor2.Length - 1));
                timer.Stop();
                TimeSpan tempoMerge = timer.Elapsed;
                
                Console.WriteLine(tempoMerge.TotalMinutes);

                Console.WriteLine("O tempo do Merge Sort foi: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge.Minutes, tempoMerge.Seconds, tempoMerge.Milliseconds);
                timer.Reset();
            }
            else if (quick = menu.KeyChar == '5')
            {
                vetor1 = new int[100000];
                vetor2 = new int[100000];
                vetor3 = new int[100000];
                Preencher(vetor1, vetor2, vetor3);

                timer.Start();
                QuickSort(vetor1, vetor1[0], (vetor1.Length - 1));
                QuickSort(vetor2, (vetor2.Length - 1), vetor2[0]);
                QuickSort(vetor3, vetor3[0], (vetor3.Length - 1));
                timer.Stop();

                TimeSpan tempoQuick = timer.Elapsed;
                
                Console.WriteLine(tempoQuick.TotalMinutes);

                Console.WriteLine("O tempo do Quick Sort foi:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick.Minutes, tempoQuick.Seconds, tempoQuick.Milliseconds);
                timer.Reset();
            }
            else if (menu.KeyChar > 5)
                Console.WriteLine("Insira um numero do menu por favor;");

            Console.WriteLine("\n");
            Console.Write("Deseja Sair?: (se Sim digite S)");
            var finalizar = Console.ReadKey();
            sair = finalizar.KeyChar == 'S' || finalizar.KeyChar == 's';
            Console.WriteLine("\n");
        } while(!sair);

        Console.ReadKey();
    }
   
    static int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    
    static void bubbleSort(int[] Vetor)
    {
        int aux = 0;

        for (int i = 0; i < Vetor.Length; i++)
        {
            for (int j = 0; j < Vetor.Length - 1; j++)
            {
                if (Vetor[j] > Vetor[j + 1])
                {
                    aux = Vetor[j + 1];
                    Vetor[j + 1] = Vetor[j];
                    Vetor[j] = aux;
                }
            }
        }
    }


    static void InsertionSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 1; i < n; ++i)
        {
            int aux = vetor[i];
            int j = i - 1;


            while (j >= 0 && vetor[j] > aux)
            {
                vetor[j + 1] = vetor[j];
                j = j - 1;
            }
            vetor[j + 1] = aux;
        }
    }

    static void SelectionSort(int[] Vetor)
    {
        int menor, i, j, aux;
        for (i = 0; i < Vetor.Length - 1; i++)
        {
            menor = i;
            for (j = i; j < Vetor.Length; j++)
            {
                if (Vetor[j] < Vetor[menor])
                    menor = j;
                aux = Vetor[menor];
                Vetor[menor] = Vetor[i];
                Vetor[i] = aux;
            }
        }
    }

    public static void MergeSort(int[] vetor, int primeiroV, int ultimoV)
    {
        if (primeiroV < ultimoV)
        {
            int meio = (primeiroV + ultimoV) / 2;

            MergeSort(vetor, primeiroV, meio);
            MergeSort(vetor, meio + 1, ultimoV);

           
            int[] leftArray = new int[meio - primeiroV + 1];
            int[] rightArray = new int[ultimoV - meio];
            
            Array.Copy(vetor, primeiroV, leftArray, 0, meio - primeiroV + 1);
            Array.Copy(vetor, meio + 1, rightArray, 0, ultimoV - meio);

            int i = 0;
            int j = 0;
            for (int k = primeiroV; k < ultimoV + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    vetor[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    vetor[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    vetor[k] = leftArray[i];
                    i++;
                }
                else
                {
                    vetor[k] = rightArray[j];
                    j++;
                }
            }
        }
    }

    static public void QuickSort(int[] vetor, int primeiroV, int ultimoV)
    {
        int menor, maior, meio, pivo, aux;
        menor = primeiroV;
        maior = ultimoV;
        meio = (int)((menor + maior) / 2);

        pivo = vetor[meio];

        while (menor <= maior)
        {
            while (vetor[menor] < pivo)
                menor++;
            while (vetor[maior] > pivo)
                maior--;
            

            if (menor < maior)
            {
                aux = vetor[menor];
                vetor[menor++] = vetor[maior];
                vetor[maior--] = aux;
            }
            else
            {
                if (menor == maior)
                {
                    menor++;
                    maior--;
                }
            }
        }

        if (maior > primeiroV)
            QuickSort(vetor, primeiroV, maior);
        if (menor < ultimoV)
            QuickSort(vetor, menor, ultimoV);
    }
}



