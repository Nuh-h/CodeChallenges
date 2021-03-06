//Solution in JAVA 11 for "Word to initial number" Kata (Kyu 6) from https://www.codewars.com/kata/5bb148b840196d1be50000b1 

import java.util.*;
class Converter{
  public static long convert(String word){
    //Originally thought (for C#) to collect the occurrence rate of each distinct letter
    //assign 1 to the first char, 0 to the non-first most occurring, then 2, 3... etc.
    //usihg finally Linq to make the replacements of the word to digit
    //However (with no option for C#), I discovered that the pattern is simply to 
    // map first char to 1, next distinct char to 0, then next distinct to 2, 3, 4... etc.
    System.out.println(word);
    Map<Character, Integer> dict = new HashMap<Character, Integer>();
    Set<Character> set = new HashSet<Character>();
    int setCount = 0;
    String wordNew = word.toLowerCase();
    for(int i=0;i<word.length();i++){
      Character char_at_i = wordNew.charAt(i);
      set.add(char_at_i);
      int newSetCount = set.size();
      if(newSetCount>setCount){
        if(newSetCount==1){
          dict.put(char_at_i,1);
        }else if(newSetCount==2){
          dict.put(char_at_i,0);
        }else{
          dict.put(char_at_i,newSetCount-1);
        }
      }
      setCount=newSetCount;
    }
    String number = "";
    for(int k=0; k<wordNew.length(); k++){
      number+=dict.get(wordNew.charAt(k));
    }
    return number.length()>0? Long.parseLong(number,10):0L;
  }
} 
