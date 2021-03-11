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
  }
}