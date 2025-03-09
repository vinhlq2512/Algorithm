class Solution:
    def isPalindrome(self, s: str) -> bool:
        res = False

        old_str = ''
        new_str = ''

        for char in s:
            if self.isValid(char):
                old_str += char.lower()
        for i in range(len(s) - 1, -1, -1):
            if self.isValid(s[i]):
                new_str += s[i].lower()
        return new_str == old_str

    def isValid(self, c: str) -> bool:
        if 48 <= ord(c) <= 57 or 65 <= ord(c) <= 90 or 97 <= ord(c) <= 122:
            return True
        return False