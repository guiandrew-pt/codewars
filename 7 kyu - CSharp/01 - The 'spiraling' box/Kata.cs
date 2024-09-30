public class SpiralingBox
{
    public static int[,] CreateBox(int m, int n)
    {
        // Initialize a 2D array (n x m)
        int[,] box = new int[n, m];

        // Define boundaries for each layer
        int layerTop = 0;
        int layerBottom = n - 1;
        int layerLeft = 0;
        int layerRight = m - 1;

        // Layer value starts at 1
        int layerValue = 1;

        // Loop through layers until we fill the box
        while (layerTop <= layerBottom && layerLeft <= layerRight)
        {
            // Fill top row of the current layer
            for (int i = layerLeft; i <= layerRight; i++)
            {
                box[layerTop, i] = layerValue;
            }

            // Fill right column of the current layer
            for (int i = layerTop + 1; i <= layerBottom; i++)
            {
                box[i, layerRight] = layerValue;
            }

            // Fill bottom row of the current layer
            for (int i = layerRight - 1; i >= layerLeft; i--)
            {
                box[layerBottom, i] = layerValue;
            }

            // Fill left column of the current layer
            for (int i = layerBottom - 1; i > layerTop; i--)
            {
                box[i, layerLeft] = layerValue;
            }

            // Move to the next inner layer
            layerTop++;
            layerBottom--;
            layerLeft++;
            layerRight--;
            layerValue++; // Increase the layer value for the next inner layer
        }

        return box;
    }
}