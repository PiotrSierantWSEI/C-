int[] a = { -2, -1, 0, 1, 4, 1 };
int[] b = { -3, -2, -1, 1, 2, 3 };

int[] c = { 1, 2, 3 };
int[] d = { -3, -2, -1 };

Print(a, b);
Print(c, d);
static void Print(int[] a, int[] b)
{
    bool empty = true;
    int[] result = new int[0];
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                empty = false;
                bool isExist = false;
                for (int k = 0; k < result.Length; k++)
                {
                    if (result[k] == a[i])
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = a[i];
                }

                break;
            }
        }
    }
    if (empty)
    {
        Console.WriteLine("empty");
    } else {
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
