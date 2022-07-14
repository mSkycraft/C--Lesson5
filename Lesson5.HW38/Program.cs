// Задача 38

int N = 5;
double flrazn(int N){
    Random rnd = new Random();
    double[] fmas = new double[N];
    for(int i =0 ; i<N; i++)
    {
        fmas[i] = (double)((int)(rnd.NextDouble()*1000))/100;
        Console.Write(fmas[i]+ ", ");
    }
    Console.WriteLine();
    double max,min;
    max = fmas[0];
    min = fmas[0];
    for(int i =1 ; i<N; i++)
    {
        if(max<fmas[i])
            max = fmas[i];
        if(min>fmas[i])
            min = fmas[i];
    }
    return max-min;
}

Console.WriteLine("Разность равна - " + flrazn(5));