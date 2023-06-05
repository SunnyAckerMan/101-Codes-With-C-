int[] arr = new int[] { 1, 2, 3 };
int[] arr2 = new int[3];
arr2 = arr;
arr2[0] = 10;
Console.WriteLine(arr[0]); 