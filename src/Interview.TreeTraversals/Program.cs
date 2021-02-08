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


            IList<int> lists = PreorderTraversal(node_74);

        }


        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            List<int> list = new List<int>() { root.val };

            list.AddRange(PreorderTraversal(root.left));

            list.AddRange(PreorderTraversal(root.right));

            return list;
        }
    }
}
