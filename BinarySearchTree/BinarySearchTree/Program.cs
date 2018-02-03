using System;

namespace System.Windows.Forms
{
    public class MainClass
    {
        
        public static void Main(string[] args)
        {
            TreeNode myTreeNode = new TreeNode(9);
            IsValidBST(myTreeNode);
            //Console.WriteLine();
        }

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        private static long previous = long.MinValue;

        public static bool IsValidBST(TreeNode root)
        {
            if(root != null) 
            {
                if (!IsValidBST(root.left)) return false;
                if (root.val <= previous) return false;
                previous = root.val;
                return IsValidBST(root.right);
            }
            Console.WriteLine("TRUE");
            return true;
        }
    }
}

//public bool IsBinarySearchTree(BinaryTreeNode root)
//{
//    return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
//}

//public bool IsBinarySearchTree(BinaryTreeNode root, int lowerBound, int upperBound)
//{
//    if (root == null)
//    {
//        return true;
//    }

//    if (root.Value >= upperBound || root.Value <= lowerBound)
//    {
//        return false;
//    }

//    return IsBinarySearchTree(root.Left, lowerBound, root.Value)
//           && IsBinarySearchTree(root.Right, root.Value, upperBound);
//}
