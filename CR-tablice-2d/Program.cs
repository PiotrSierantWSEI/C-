int[] a = new int[] {-2, -1, 0, 1, 4};
int[] b = new int[] {-3, -2, -1, 1, 2, 3};
int[] c = new int[] {0, 1, 1, 2, 3, 3, 3};
int[] d = new int[] {0, 1, 2, 3, 3};

Print(a, b);
Print(c, d);

a = new int[] {-2, -1, 0, 1, 4};
b = new int[] {-3, -2, -1, 1, 2, 3};

static void Print(int[] a, int[] b) {
    bool empty = true;
    int[] result = new int[0];

    for (int i = 0; i < a.Length; i++) {
        bool isExist = false;
        for (int j = 0; j < b.Length; j++) {
            if (a[i] == b[j]) {
                isExist = true;
                break;
            }
        }
        if (!isExist) {
            empty = false;
            bool isDuplicate = false;
            for (int k = 0; k < result.Length; k++) {
                if (result[k] == a[i]) {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate) {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = a[i];
            }
        }
    }

    for (int i = 0; i < b.Length; i++) {
        bool isExist = false;
        for (int j = 0; j < a.Length; j++) {
            if (b[i] == a[j]) {
                isExist = true;
                break;
            }
        }
        if (!isExist) {
            empty = false;
            bool isDuplicate = false;
            for (int k = 0; k < result.Length; k++) {
                if (result[k] == b[i]) {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate) {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = b[i];
            }
        }
    }

    if (empty) {
        Console.WriteLine("empty");
    } else {
        Array.Sort(result);
        Console.WriteLine(string.Join(" ", result));
    }
}