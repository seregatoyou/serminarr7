int m;
int n;
int number(int m,int n){
    if (m==n){
        return 0;
    }
    else{
        Console.WriteLine($"{m}");
        m++;
        number(m,n);
        return 0;
    }
}
number(1,10);


