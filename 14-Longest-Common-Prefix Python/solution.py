def LongestCommonPrefix(str):
    str.sort()
    firstWord = str[0]
    lastWord = str[len(str)-1]
    index = 0
    prefix = ""
    
    while(index<len(firstWord) and index<len(lastWord)):
            if firstWord[index]==lastWord[index]:
                  prefix = prefix + firstWord[index]
                  index = index +1
            else:
                  break
    
    return prefix

nums1 = ["flower","flow","flight"]
nums2 = ["dog","racecar","car"]

print(LongestCommonPrefix(nums1))
print(LongestCommonPrefix(nums2))

