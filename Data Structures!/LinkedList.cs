public class Program {
  public class DoublyLinkedList {
    public Node Head;
    public Node Tail;

    // * SetHead Method implementation below
    // Time Complexity: O(1)
    // Space Complexity: O(1)
    public void SetHead(Node node) {
      // edge case check
      if(Head == null) {
        Head = node;
        Tail = node;
        return;
      }
      // invoke insert head before method here to set head if it already exists prior to setting a new value
      InsertBefore(Head, node);
    }

    public void InsertBefore(Node node, Node nodeToInsert) {
      if(nodeToInsert == Head && nodeToInsert == Tail) return;
      Remove(nodeToInsert);
      nodeToInsert.Prev = node.Prev;
      nodeToInsert.Next = node;
      if(node.Prev == null) {
        Head = nodeToInsert;
      } else {
        node.Prev.Next = nodeToInsert;
      }
      node.Prev = nodeToInsert;
    }

    // Node constructor
    public class Node {
      public int Value;
      public Node Prev;
      public Node Next;

      public Node(int value) {
        this.Value = value;
      }
    }
  }
}