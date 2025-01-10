class Solution:
    def wordSubsets(self, words1: List[str], words2: List[str]) -> List[str]:

        def count_word(word):
            count = [0] * 26
            for letter in word:
                count[ord(letter) - ord('a')] += 1
            return count

        max_count_word2 = [0] * 26
        for word in words2:
            word_count = count_word(word)
            for i in range(26):
                max_count_word2[i] = max(max_count_word2[i], word_count[i])

        ans = []

        for word in words1:
            count_word1 = count_word(word)
            for i in range(26):
                if count_word1[i] < max_count_word2[i]:
                    break
            else:
                ans.append(word)

        return ans