Pilha<int> pilha = new Pilha<int>();

pilha.Push(1);
pilha.Push(4);
pilha.Push(5);
pilha.Push(10);

Console.WriteLine(pilha);

pilha.Pop();
Console.WriteLine("After the first pop: ");
Console.WriteLine(pilha);
Console.WriteLine(pilha.Pop());
Console.WriteLine("After the second pop: ");
Console.WriteLine(pilha);

pilha.Clear();
Console.WriteLine("After the clear function");
Console.WriteLine(pilha);
