class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = set('aeiouAEIOU')
        indexs = []
        words = []
        s_list = list(s)

        for i, char in enumerate(s):
            if char in vowels:
                indexs.append(i)
                words.append(char)

        for i, char in enumerate(words):
           s_list[indexs[len(indexs) - i - 1]] = char

        return ''.join(s_list)