/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var backspaceCompare = function (s, t) {
  var backSpaceS = [];
  var backSpaceT = [];
  var resS = '';
  var resT = '';
  var maxP = Math.max(s.length, t.length);
  for (var i = maxP - 1; i >= 0; i--) {
    if (s[i] === '#') {
      backSpaceS.push(s[i]);
    } else {
      if (s[i] != null) {
        if (backSpaceS.length > 0) {
          backSpaceS.pop();
        } else {
          resS += s[i];
        }
      }
    }

    if (t[i] === '#') {
      backSpaceT.push(t[i]);
    } else {
      if (t[i] != null) {
        if (backSpaceT.length > 0) {
          backSpaceT.pop();
        } else {
          resT += t[i];
        }
      }
    }
  }
  return resS == resT;
};

// var s = 'ab##',
//   t = 'c#d#';

var s = 'abc#d';
t = 'abzz##d';
backspaceCompare(s, t);
