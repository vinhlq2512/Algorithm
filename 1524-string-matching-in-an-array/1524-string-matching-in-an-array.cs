public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> res = new HashSet<string>();
        
        foreach (string word in words)
        {
            foreach (string other in words)
            {
                if (word.Length < other.Length && other.Contains(word))
                {
                    res.Add(word); 
                }
            }
        }
        
        return new List<string>(res); 
    }
}