
def strStr(haystack, needle):
    j=0
    index=0
    for i in range(0,len(haystack)):
        if needle[j]==haystack[i]:
        
           if j<len(needle)-1:
            j = j+1
           else:
              break
        if j==1:
            index=i
            
               
        #elif j>0 and j != len(needle):
           # j=0
    print(j)
    if j==len(needle)-1:
        return index
    elif j!=len(needle)-1:
        return -1

haystack = "leetcode"
needle = "leeto"
print(len(needle))
print(strStr(haystack,needle))
