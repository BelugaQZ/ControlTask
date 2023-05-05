string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

void method(string[] arr) {
    string[] temp = new string[arr.Length];
    int k = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i].Length <= 3) {
            temp[k] = arr[i];
            k++;
        }
    }

    Console.WriteLine(string.Join(" ", temp));
}

Console.WriteLine(string.Join(", ", arr1));
Console.WriteLine(string.Join(", ", arr2));
Console.WriteLine(string.Join(", ", arr3));
Console.WriteLine();
method(arr1);
method(arr2);
method(arr3);