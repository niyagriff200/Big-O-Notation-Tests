using System.Diagnostics;

namespace Big_O_Notation_Tests
{
    public partial class BigONotation : Form
    {
        // Creates an integer array with 100,000 elements
        // This array is used for all tests
        private int[] arrayNum = new int[100000];

        // Creates a Random object with a fixed seed
        // A fixed seed ensures the same numbers are generated every run
        // This removes other variables such as different numbers being the cause of a slowdown
        private Random rdm = new Random(42);

        // This is used to re-run the code a certain number of times (10)
        int repeatCount = 10;


        public BigONotation()
        {
            
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Fills the array with random integers
            for (int i = 0; i < arrayNum.Length; i++)
            {
                // Assigns a random number between 1 and 100000 to each index
                arrayNum[i] = rdm.Next(1, 100001);
            }

            // Displays a message confirming the array was filled in the textbox
            txtResults.AppendText("Generated 100,000 random numbers\r\n");

            btnBinary.Enabled = false;
            btnLinear.Enabled = false;

            btnMerge.Enabled = true;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            // Creates a stopwatch to measure merge sort time
            Stopwatch swMerge = new Stopwatch();

            for (int run = 0; run < repeatCount; run++)
            {

                swMerge.Start();

                // Calls merge sort on the entire array
                MergeSort(arrayNum, 0, arrayNum.Length - 1);

                swMerge.Stop();

                // Displays the elapsed time in milliseconds
                txtResults.AppendText("Merge Sort Time: " + swMerge.Elapsed.TotalMilliseconds + " ms\r\n");
            }

            btnLinear.Enabled = true;
            btnBinary.Enabled = true;
        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            // Selects a target value from the middle of the array
            int target = arrayNum[arrayNum.Length / 2];

            // Creates a stopwatch to measure linear search time
            Stopwatch swLinear = new Stopwatch();

            for (int run = 0; run < repeatCount; run++)
            {

                swLinear.Start();

                // Performs linear search
                int index = LinearSearch(arrayNum, target);

                swLinear.Stop();

                // Displays the elapsed time and index
                txtResults.AppendText("Linear Search Time: " + swLinear.Elapsed.TotalMilliseconds + "ms\r\n");
                txtResults.AppendText("Index found at " + index + "\r\n");
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            // Selects a target value from the middle of the array
            int target = arrayNum[arrayNum.Length / 2];

            // Creates a stopwatch to measure binary search time
            Stopwatch swBinary = new Stopwatch();

            for (int run = 0; run < repeatCount; run++)
            {
                swBinary.Start();

                // Performs binary search
                int index = BinarySearch(arrayNum, target);

                swBinary.Stop();

                // Displays the elapsed time and index
                txtResults.AppendText("Binary Search Time: " + swBinary.Elapsed.TotalMilliseconds + "ms\r\n");
                txtResults.AppendText("Index found at " + index + "\r\n");
            }
        }

        private int LinearSearch(int[] data, int target) // Linear search: O(n) time, O(1) space
        {
            // Loops through every element in the array
            for (int i = 0; i < data.Length; i++)
            {
                // Checks if the current element matches the target
                if (data[i] == target)
                {
                    // Returns the index where the target was found
                    return i;
                }
            }

            // Returns -1 if the target is not found in array
            return -1;
        }

        private int BinarySearch(int[] data, int target) // Binary search: O(log n) time, O(1) space
        {
            // Sets the left boundary of the search range
            int leftSide = 0;

            // Sets the right boundary of the search range
            int rightSide = data.Length - 1;

            // Continues searching while the range is valid
            while (leftSide <= rightSide)
            {
                // Calculates the middle index.
                int middle = (leftSide + rightSide) / 2;

                // Checks if the middle element is the target
                if (data[middle] == target)
                {
                    return middle;
                }

                // Moves the left boundary if the target is larger
                if (data[middle] < target)
                {
                    leftSide = middle + 1;
                }
                else
                {
                    // Moves the right boundary if the target is smaller
                    rightSide = middle - 1;
                }
            }

            // Returns -1 if the target is not found in array
            return -1;
        }

        private void MergeSort(int[] data, int leftSide, int rightSide) // Merge sort: O(n log n) time, O(n) space
        {
            // Ensures the segment contains more than one element
            if (leftSide < rightSide)
            {
                // Finds the midpoint of the current segment
                int middle = (leftSide + rightSide) / 2;

                // Sorts the left half
                MergeSort(data, leftSide, middle);

                // Sorts the right half
                MergeSort(data, middle + 1, rightSide);

                // Merges the two sorted halves
                Merge(data, leftSide, middle, rightSide);
            }
        }

        private void Merge(int[] data, int leftSide, int middle, int rightSide)
        {
            // Calculates the size of the left temporary array
            int leftSize = middle - leftSide + 1;

            // Calculates the size of the right temporary array
            int rightSize = rightSide - middle;

            // Creates a temporary array for the left half
            int[] leftArray = new int[leftSize];

            // Creates a temporary array for the right half
            int[] rightArray = new int[rightSize];

            // Copies the left half into the temporary left array
            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = data[leftSide + i];
            }

            // Copies the right half into the temporary right array
            for (int j = 0; j < rightSize; j++)
            {
                rightArray[j] = data[middle + 1 + j];
            }

            // Index for leftArray
            int a = 0;

            // Index for rightArray
            int b = 0;

            // Index for merged output in the original array
            int k = leftSide;

            // Merges elements while both arrays still have items
            while (a < leftSize && b < rightSize)
            {
                // Places the smaller value into the main array
                if (leftArray[a] <= rightArray[b])
                {
                    data[k] = leftArray[a];
                    a++;
                }
                else
                {
                    data[k] = rightArray[b];
                    b++;
                }

                // Moves to the next position in the main array
                k++;
            }

            // Copies any remaining elements from the left array
            while (a < leftSize)
            {
                data[k] = leftArray[a];
                a++;
                k++;
            }

            // Copies any remaining elements from the right array
            while (b < rightSize)
            {
                data[k] = rightArray[b];
                b++;
                k++;
            }
        }
    }
}
