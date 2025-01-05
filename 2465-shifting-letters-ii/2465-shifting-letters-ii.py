class Solution:
    def shiftingLetters(self, s: str, shifts: List[List[int]]) -> str:
        n = len(s)
        new_array = [0] * n  

        for start, end, direction in shifts:
            if direction == 1:  
                new_array[start] += 1  
                if end + 1 < n:
                    new_array[end + 1] -= 1
            else:
                new_array[start] -= 1
                if end + 1 < n:
                    new_array[end + 1] += 1

        result = list(s)
        number_of_shifts = 0

        for i in range(n):
            number_of_shifts = (number_of_shifts + new_array[i]) % 26
            if number_of_shifts < 0:
                number_of_shifts += 26

            shifted_char = chr((ord(s[i]) - ord("a") + number_of_shifts) % 26 + ord("a"))
            result[i] = shifted_char

        return "".join(result)