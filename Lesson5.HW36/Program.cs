// Задача 36

void rndsumchet(int N){
    Random rnd = new Random();
    int sum = 0;
    int[] mas = new int[N];
    for(int i =0 ; i<N; i++)
    {
        mas[i] = rnd.Next(1,10);
        if((i+1)%2!=0)
            sum = sum + mas[i];
        Console.Write(mas[i]+ ", ");
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов на нечетных позициях - "+ sum);
}


rndsumchet(5);