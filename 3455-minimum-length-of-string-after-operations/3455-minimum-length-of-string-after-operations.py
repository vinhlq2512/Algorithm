class Solution:
    def minimumLength(self, s: str) -> int:
        total_length = 0
        freq_char = [0] * 26;
        for i in range(len(s)):
            freq_char[ord(s[i]) - ord('a')] += 1;

        for i in range(26):
           if freq_char[i] > 0:
               if freq_char[i] % 2 == 1:
                   total_length += 1
               else:
                   total_length += 2

        return total_length