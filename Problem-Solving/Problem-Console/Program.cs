using BinarySearch;
using Pair;
using Sort;
using Triplets;


static void printArray(int[] arr, int size)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < size; i++)
        Console.Write(arr[i] + " ");
    Console.Write("]");
}

int[] array = new[] { 15, -1, 13, 3, 5, 0, 9, 12, 14, 10 };

var binary = new BinarySearch.BinarySearchAlgo(array);
Console.WriteLine("index Target = " + binary.GetIndexTarget(9));
Console.WriteLine("index Target = " + binary.GetIndexTarget(binary.Numbers, 0, binary.Numbers.Length - 1, 9));

//var resPair = PairAlgo.PairSum(binary.Numbers, 13);
//foreach (var p in resPair)
//    Console.WriteLine("Pair Target = " + p);

Console.WriteLine("Sort");

int[] arr = { -6, -3, -1, 2, 4, 5 };
var SortArray = SquaresOfSortedArray.NEWSORT(arr);
for (int i = 0; i < arr.Length; i++)
    Console.Write(SortArray[i] + " ");


Console.WriteLine("\nPairSum_Index");
int[] APairSum_IndexArray = { -1, 0 };
var PairSum_Index = PairAlgo.PairSum_Index(APairSum_IndexArray, -1);
printArray(PairSum_Index, 2);

Console.WriteLine("\nTriplet");
int[] A = { 1, 2, 4, 5, 3, 6 };
int n = A.Length;

var triplets = TripletAlgo.GetTriplets(A, n, 8);
foreach (var triplet in triplets)
    printArray(triplet, 3);


Console.WriteLine();
Console.WriteLine("\nmoveZeros");
int[] moveZeros = new int[] { 0, 1, 2, 0, 3 };
printArray(moveZeros, moveZeros.Length);
MoveZeroAlgo.pushZerosToEnd(moveZeros, moveZeros.Length);
printArray(moveZeros, moveZeros.Length);











