class 88mergeSortedArray{
    	public static void main(String [] args)
	{

	}
        public static void merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = 0; i<=nums1.length; i++){
            if(nums1[i]==0){
                for(int j = 0; j<=nums2.length; j++){
                    nums1[i]= nums2[j];
                    i++;
                }
            }
            break;
        }
    }
}