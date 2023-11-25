
def strStr(haystack, needle):
    j=0
    for i in range(0,len(haystack)):
        if needle[j]==haystack[i]:
           if j<len(needle)-1:
            j = j+1
           else:
              break
        #elif j>0 and j != len(needle):
           # j=0

    if j==len(needle)-1:
        return j
    else:
        return -1

haystack = "leetcode"
needle = "leeto"

print(strStr(haystack,needle))
