var lengthOfLongestSubstring = function (s) {
  if (s.length <= 1) {
    return s.length;
  }
  var max = 1;
  var len = s.length - 1;
  for (var i = 0; i <= len; i++) {
    var seenChar = {};
    seenChar[s[i]] = true;
    var currentLength = 1;
    for (var j = i + 1; j <= len; j++) {
      if (!seenChar[s[j]]) {
        seenChar[s[j]] = true;
        currentLength++;
        max = Math.max(currentLength, max);
      } else {
        break;
      }
    }
  }
  return max;
};