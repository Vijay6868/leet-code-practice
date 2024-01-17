
class Solution(object):
    def strStr(self, haystack, needle):
        nchar=needle[0]

        for i in range(0,len(haystack)):
            if haystack[i]==nchar:
                count=1

                for x in range(1,len(needle)):
                    if needle[x]==haystack[i+x]:
                        count+=1
                        
                if count==len(needle):
                    count=0
                    return i

