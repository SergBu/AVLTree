// See https://www.nookery.ru/avltree/?ysclid=lxeq2bg7yh174243234 for more information
// https://simpledevcode.wordpress.com/2014/09/16/avl-tree-in-c/


using AVLTree;

Console.WriteLine("first tree");

AVLTree<int> Oak = new AVLTree<int>();
              //                             10                              10                                             
Oak.Add(10);  //                            /   \                           /   \
Oak.Add(3);   //                           /     \                         /     \
Oak.Add(2);   //                          3      12      ====>            3       15
Oak.Add(4);   //                         / \     / \                     / \      / \
Oak.Add(12);  //                        2   4  null 15                  2   4    12  25
Oak.Add(15);  //                                      \              
Oak.Add(11);  //                                       25
Oak.Add(25);  //

Oak.Remove(11);

foreach (var item in Oak)
{
    Console.WriteLine(item);
}

Console.WriteLine("second tree");

AVL tree = new AVL();
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(2);
tree.Delete(7);
tree.DisplayTree();