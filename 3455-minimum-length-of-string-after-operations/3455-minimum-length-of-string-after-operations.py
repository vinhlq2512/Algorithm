class Solution:
    def minimumLength(self, s: str) -> int:
        res = len(s)
        freq_char = [0] * 26;
        for i in range(len(s)):
            freq_char[ord(s[i]) - ord('a')] += 1;

        print(freq_char)
        for i in range(26):
           if freq_char[i] > 0:
               if freq_char[i] % 2 == 1:
                   while freq_char[i] != 1:
                       freq_char[i] -= 2
                       res -= 2
               else:
                   while freq_char[i] != 2:
                       freq_char[i] -= 2
                       res -= 2

        return res