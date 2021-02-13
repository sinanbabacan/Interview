using System;
using System.Collections.Generic;

namespace Interview.TreeTraversals
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node_58 = new TreeNode(58);

            TreeNode node_66 = new TreeNode(66);

            TreeNode node_22 = new TreeNode(22);

            TreeNode node_44 = new TreeNode(44);

            TreeNode node_84 = new TreeNode(84);

            TreeNode node_89 = new TreeNode(89);

            TreeNode node_36 = new TreeNode(36, node_22, node_44);

            TreeNode node_59 = new TreeNode(59, node_58, node_66);

            TreeNode node_79 = new TreeNode(79);

            TreeNode node_86 = new TreeNode(86, node_84, node_89);

            TreeNode node_53 = new TreeNode(53, node_36, node_59);

            TreeNode node_81 = new TreeNode(81, node_79, node_86);

            TreeNode node_74 = new TreeNode(74, node_53, node_81);

            // IList<int> list = PreorderTraversal(node_74);
            //  IList<int> list = InOrderTraversal(node_74);
            //  IList<int> list = PostorderTraversal(node_74);

            IList<int> list = BreadthFirstSearch(node_74);

        }


        public static IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();

            if (root != null)
            {
                list.Add(root.val);

                list.AddRange(PreorderTraversal(root.left));

                list.AddRange(PreorderTraversal(root.right));
            }

            return list;
        }

        public static IList<int> InOrderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();

            if (root != null)
            {
                list.AddRange(InOrderTraversal(root.left));

                list.Add(root.val);

                list.AddRange(InOrderTraversal(root.right));
            }

            return list;
        }

        public static IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();

            if (root != null)
            {
                list.AddRange(PostorderTraversal(root.left));
                list.AddRange(PostorderTraversal(root.right));
                list.Add(root.val);
            }

            return list;

        }

        public static IList<int> BreadthFirstSearch(TreeNode root)
        {
            List<int> list = new List<int>();

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();

                list.Add(node.val);

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }

            return list;
        }
    }
}
