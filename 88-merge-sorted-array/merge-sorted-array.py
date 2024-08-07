

def merge(nums1, m, nums2, n):
  
    for i in range(0,m):
       
        nums1[m+i] = nums2[i]
    
    nums1.sort()
    print(nums1)

nums1 = [1,2,3,0,0,0]
nums2 = [2,5,6]


merge(nums1,3,nums2,3)