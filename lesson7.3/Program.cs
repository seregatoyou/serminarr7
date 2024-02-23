int[] array = new int [5];
int m = array.GetLength(0);
for (int i = 0; i<m; i++){
    array[i] =  new Random().Next(10,100);
    Console.Write($"{array[i]}\t");
}
    Console.WriteLine($"");
int massive(int[] array, int m){
    if (m==0){
        return 0;
    }
    else{
        Console.Write($"{array[m-1]}\t");
        m--;
        massive(array, m);
        return 0;
    }
}
massive(array,m);