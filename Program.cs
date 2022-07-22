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

Console.WriteLine("[{0}]", string.Join(", ", data));
