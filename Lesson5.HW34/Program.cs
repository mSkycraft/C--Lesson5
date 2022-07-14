// Задача 34

void rndchetmas(int N){
    Random rnd = new Random();
    int[] mas = new int[N];
    int count = 0;
    for(int i =0 ; i<N; i++)
    {
        mas[i] = rnd.Next(100,999);
        if(mas[i]%2==0)
            count = count + 1;
        Console.Write(mas[i]+ ", ");
    }
    Console.WriteLine();
    Console.WriteLine("Количество четных - "+ count);
}


rndchetmas(5);