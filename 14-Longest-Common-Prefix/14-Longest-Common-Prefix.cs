using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string[] nums1 = {"flower","flow","flight"};
       string[] nums2 = {"dog","racecar","car"};
    }
     public string LongestCommonPrefix(string[] strs) {
        //Console.WritLine(strs.Length);
        firstWord = strs[0];
        lastWord = strs[strs.Length-1]
        int index = 0;
        string commonPrefix = "";
        while(firstWord[index]==LastWord[index]){
            commonPrefix = commonPrefix + firstword[index]
            index++;
        }
        return commonPrefix;
        
    }
}