using System;

namespace Interview.SortedArrayToBST
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
            int[] list = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            TreeNode treeNode = SortedArrayToBST(list);


        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public static TreeNode SortedArrayToBST(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;

            TreeNode left = SortedArrayToBST(nums, start, mid - 1);

            TreeNode right = SortedArrayToBST(nums, mid + 1, end);

            return new TreeNode(nums[mid], left, right);
        }
    }
}
