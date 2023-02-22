


public class Pilha<T>
{
    public int index { get; set; } = -1;
    public List<T> Stack { get; private set; } = new List<T>();
    public int Size
    {
        get { return index; }
        private set { }
    }
    
    public bool IsEmpty() => this.index == -1;
    public void Push(T item)
    {
        Stack.Add(item);
        this.index++;
    }

    public T? Pop()
    {
        if (!this.IsEmpty())
        {
            T aux = Stack[index];
            Console.WriteLine(this.index);
            Stack.RemoveAt(this.index);
            index--;
            return aux;
        }
        return default(T);
        
    }

    public void Clear()
    {
        this.index = 0;
        this.Stack = new List<T>();
    }

    public override string ToString()
    {
        string str = "";
        int index = this.index;
        this.Stack.Reverse();
        foreach (var item in this.Stack)
        {
            str += "[" + index + "] - " + item?.ToString() + "\n";
            index--;
        }
        this.Stack.Reverse();

        return str;
    }

}