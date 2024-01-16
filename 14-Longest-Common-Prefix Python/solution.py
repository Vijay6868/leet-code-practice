def LongestCommonPrefix(wordList):
    wordList.sort()
    firstWord = wordList[0]
    lastWord = wordList[len(wordList)-1]
    index = 0
    prefix = ""
    while(firstWord[index]==lastWord[index]):
            prefix = prefix + firstWord[index]
            index = index +1
    return prefix

nums1 = ["flower","flow","flight"]
nums2 = ["dog","racecar","car"]

print(LongestCommonPrefix(nums1))
print(LongestCommonPrefix(nums2))

