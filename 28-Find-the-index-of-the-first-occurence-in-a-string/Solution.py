
def strStr(haystack, needle):
    j=0
    for i in range(0,len(haystack)-1):
        if needle[j]==haystack[i]:
           j= j+1

    if j==len(needle):
        return j
    else:
        return -1

haystack = "leetcode"
needle = "leeto"

print(strStr(haystack,needle))
