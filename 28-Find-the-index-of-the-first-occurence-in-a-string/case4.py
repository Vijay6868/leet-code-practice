def strStr1(haystack, needle):
   nchar=needle[0]

   for i in range(0,len(haystack)):
            if haystack[i] == nchar:
                count=1
                idx=i+1
                for x in range(1,len(needle)):
                    #print(needle[x]+" nx "+haystack[idx]+" hx")
                    if needle[x]==haystack[idx]:
                        count+=1
                    idx+=1
                #print("value of count "+ str(count) )       
                if count==len(needle):
                    #count=0
                    #print("value of i : "+str(i))
                     
                     return i
                else:
                     return-1
            elif i==len(haystack)-1:
                 return -1
haystack="aaa"
needle= "bab"         
print(strStr1(haystack,needle))
#print(len(needle))