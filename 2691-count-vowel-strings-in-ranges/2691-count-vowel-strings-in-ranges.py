class Solution:
    def vowelStrings(self, words: List[str], queries: List[List[int]]) -> List[int]:
        def is_vowel(ch):
            return ch in {'a', 'e', 'i', 'o', 'u'}
    
        def is_vowel_string(word):
            return is_vowel(word[0]) and is_vowel(word[-1])
        
        n = len(words)
        prefix_sum = [0] * n
        prefix_sum[0] = 1 if is_vowel_string(words[0]) else 0
        
        for i in range(1, n):
            prefix_sum[i] = prefix_sum[i - 1] + (1 if is_vowel_string(words[i]) else 0)
        
        result = []
        for li, ri in queries:
            if li == 0:
                result.append(prefix_sum[ri])
            else:
                result.append(prefix_sum[ri] - prefix_sum[li - 1])
        
        return result