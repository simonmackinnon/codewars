public class Parentheses
{
    public static bool ValidParentheses(string input)
    {     
        //keep track of pairs of brackets, they should balance out by the end
        // and never be negative
        int currBalance = 0;     
        
        foreach (char c in input) 
        {
          if (c == '(') currBalance++;
          else if (c == ')') currBalance--;
          
          //we have more closing than open brackets
          if (currBalance < 0) return false;
        }  
        
        //there's an impalance of pairs
        if (currBalance != 0) return false;

        return true;
    }
}