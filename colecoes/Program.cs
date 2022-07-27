// using colecoes.helper;

//         int[] arrayNumero = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};


//         var minimo = arrayNumero.Min();
//         var maximo = arrayNumero.Max();
//         var medio = arrayNumero.Average();
//         var soma = arrayNumero.Sum();
//         var arrayUnico = arrayNumero.Distinct().ToArray();
        

//         System.Console.WriteLine($"minimo: {minimo}");
//         System.Console.WriteLine($"maximo: {maximo}");
//         System.Console.WriteLine($"medio : {medio}");
//         System.Console.WriteLine($"soma: {soma}");
//         System.Console.WriteLine($"array original: {string.Join(", ", arrayNumero)}");
//         System.Console.WriteLine($"array distinto: {string.Join(", ", arrayUnico)}");




        // var numerosParesQuery = 
        //         from num in arrayNumero
        //         where num % 2 == 0
        //         orderby num
        //         select num;

        // var numerosParesMetodo = arrayNumero.Where(x=> x % 2 == 0).OrderBy(x=> x).ToList();

        // System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
        // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));



        // Dictionary<string, string> estados = new Dictionary<string, string>();

        // estados.Add("SP","São Paulo");
        // estados.Add("MG","Minas Gerais");
        // estados.Add("BA","Bahia");

        // foreach (KeyValuePair<string, string> item in estados)
        // {
        //         // System.Console.WriteLine($"Chaves: {item.Key}, Valor {item.Value}");
        // }

        // string valorProcurado = "sc";

        //var teste = estados["SC"];

        // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
        // {
        //         System.Console.WriteLine(estadoEncontrado);
        // }
        // else
        // {
        //         System.Console.WriteLine($"chave {valorProcurado} não existe no dicionário");
        // }

        // System.Console.WriteLine($"removendo o valor: {valorProcurado}");

        // estados.Remove(valorProcurado);

        // foreach (KeyValuePair<string, string> item in estados)
        // {
        //         System.Console.WriteLine($"Chaves: {item.Key}, Valor {item.Value}");
        // }

        // System.Console.WriteLine("Valor original: ");
        // System.Console.WriteLine(estados[valorProcurado]);

        // estados[valorProcurado] = "BA - teste atualização";

        // System.Console.WriteLine("Valor atualizado: ");
        // System.Console.WriteLine(estados[valorProcurado]);

        // Stack<string> pilhaLivros = new Stack<string>();

        // pilhaLivros.Push(".NET");
        // pilhaLivros.Push("DDD");
        // pilhaLivros.Push("Código limpo");

        // System.Console.WriteLine($"Livro para leitura: {pilhaLivros.Count}");
        // while (pilhaLivros.Count > 0)
        // {
        //     System.Console.WriteLine($"Proximo livro para a leitura: {pilhaLivros.Peek()}");
        //     Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
        // }

        // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

//Queue<string> fila = new Queue<string>();

//fila.Enqueue("Leonardo");
//fila.Enqueue("Eduardo");
//fila.Enqueue("André");

//System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

//while (fila.Count > 0)
//{
//    System.Console.WriteLine($"Vez de: {fila.Peek()}");
//    System.Console.WriteLine($"{fila.Dequeue()} atendido");
//}

//System.Console.WriteLine($"Pessoa na fila: {fila.Count}");

//OperacoesLista opLista = new OperacoesLista();
//List<string> estados = new List<string>{"SP", "MG", "BA"};
//string[] estadosArray = new string[2] {"SC", "MT"};

//System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

//opLista.ImprimirListaString(estados);

//System.Console.WriteLine("removendo o elemento");
//estados.Remove("MG");

//estados.AddRange(estadosArray);

//estados.Insert(1,"RJ");

//opLista.ImprimirListaString(estados);



//operacoesArray op = new operacoesArray();

//int [] array = new int[5] {6,3,8,1,9,};
//int [] arrayCopia = new int[10];
//string[] arrayString = op.converterParaArrayString(array);

//int ValorProcurado = 8;

//System.Console.WriteLine($"capacidade atual do array : {array.Length}");

//op.RedimensionarArray(ref array, array.Length * 2);

//System.Console.WriteLine($"capacidade atual do array após redimensionar: {array.Length}");

// int indice = op.ObterIndice(array, ValorProcurado);

// if(indice > -1)
// {
//     System.Console.WriteLine($"o indice do elemento {ValorProcurado} é: {indice}", ValorProcurado, indice);
// }
// else
// {
//     System.Console.WriteLine("valor não existente no Array");
// }

// bool Existe = op.Existe(array, ValorProcurado);

// if (Existe)
// {
//     System.Console.WriteLine("encontrei o valor: {0}", ValorProcurado);
// }
// else
// {
//     System.Console.WriteLine("não encontrei o valor: {0}", ValorProcurado);
//}

// System.Console.WriteLine("Array original:");
// op.ImprimirArray(array);

//op.OrdenarBubbleSort(ref array);
//op.Ordenar(ref array);


// System.Console.WriteLine("Array ordenado:");
// op.ImprimirArray(array);

// System.Console.WriteLine("Array antes da copia:");
// op.ImprimirArray(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);
// System.Console.WriteLine("array após a copia:");
// op.ImprimirArray(arrayCopia);

// int[,] matriz = new int[4,2]
// {
//     { 8, 8},
//     {10,20},
//     {50,100},
//     {90,200}
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine(matriz[i, j]);
//     }
// }

//int[] arryInteiros = new int[3];
// arryInteiros[0] = 10;
// arryInteiros[1] = 20;
// arryInteiros[2] = 30;


// arryInteiros[3] = 30;

// System.Console.WriteLine("Percorrendo o array pelo for");
// for (int i = 0; i < arryInteiros.Length; i++)
// {
//     System.Console.WriteLine(arryInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo foreach");
// foreach (int item in arryInteiros)
// {
//     System.Console.WriteLine(item);
// }