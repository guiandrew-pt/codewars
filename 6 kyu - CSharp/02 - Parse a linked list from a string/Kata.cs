using System;

public static class Kata
{
    public static Node Parse(string nodes)
    {
        // Handle edge case: if the input is "null", return null.
        if (nodes == "null")
        {
            return null;
        }

        // Split the input string by " -> " to get individual node values.
        string[] values = nodes.Split(" -> ");

        // Initialize the head of the linked list.
        Node head = null;
        Node current = null;

        // Iterate over each value except the last one (which is "null").
        for (int i = 0; i < values.Length - 1; i++)  // -1 because we skip "null"
        {
            int nodeValue = int.Parse(values[i]);  // Convert the string to an integer

            // Create a new node with the value.
            Node newNode = new Node(nodeValue);

            // If it's the first node, set it as the head.
            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                // Link the current node to the new node.
                current.Next = newNode;
                // Move to the new node.
                current = newNode;
            }
        }

        return head;  // Return the head of the linked list
    }
}
