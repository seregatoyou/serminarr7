﻿    static int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, 1);
        return A(n - 1, A(n, m - 1));
    }
        Console.WriteLine(A(2, 5));
        Console.WriteLine(A(1, 2));
