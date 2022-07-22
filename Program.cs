int[] data = { 25, 21, 22, 24, 23, 27, 26 };


/// <summary>BUBBLE SORT </summary>
/// <summary>Highest values 'bubble' to the top by comparing neighbours.</summary>

//int lastElementIndex = data.Length - 1;

// we count backwards for the outer loop to account for the biggest being in place already
//for (int i = lastElementIndex; i >= 0; i--)
//{
//    for (int j = 0; j < lastElementIndex; j++)
//    {
//        // check if current is bigger than next
//        if (data[j] > data[j + 1])
//        {
//            // if so, we swap positions
//            (data[j], data[j + 1]) = (data[j + 1], data[j]);
//        }
//    }
//}
/// <summary>INSERTION SORT </summary>
/// <summary>insert values to the furthest right by comparing neighbours.</summary>

// we start at 1 because we use that as our next element
//for (int i = 1; i < data.Length; i++)
//{
//    int j = i - 1;
//    var nextElement = data[i];

//    // the inner loop only goes the length of the sorted numbers so far
//    // its important to check if j is >= 0 first, since data[j] if j = - 1 will throw an error.
//    while (j >= 0 && data[j] > nextElement)
//    {
//        data[j + 1] = data[j];

//        // if this is below 0, it means we've reached the end of the list and the
//        // value we were sorting has been moved to it's furthest right position
//        j = j - 1;

//        // swap element poisitons
//        data[j + 1] = nextElement;
//    }
//}
/// <summary> MERGE SORT </summary>
/// <summary>Based on divide and conquer strategy, splits the array and then merges and sorts in place</summary>
/// 
    List<int> MergeSort(List<int> data)
{

    if (data.Count > 1)
    {
        var mid = data.Count / 2;
        var left = data.GetRange(0, mid);
        var right = data.GetRange(mid, data.Count - mid);

        MergeSort(left);
        MergeSort(right);

        int a = 0;
        int b = 0;
        int c = 0;

        while (a < left.Count && b < right.Count)
        {
            if (left[a] < right[b])
            {
                data[c] = left[a];
                a++;
            } else
            {
                data[c] = right[b];
                b++;
            }
            c++;
        }

        while (a < left.Count)
        {
            data[c] = left[a];
            a++;
            c++;
        }

        while (b < right.Count)
        {
            data[c] = right[b];
            b++;
            c++;
        }        
    }
    Console.WriteLine("[{0}]", string.Join(", ", data));
    return data;
}



MergeSort(data.ToList());