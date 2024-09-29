/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
// var backspaceCompare = function (s, t) {
//   var backSpaceS = [];
//   var backSpaceT = [];
//   var resS = '';
//   var resT = '';
//   var maxP = Math.max(s.length, t.length);
//   for (var i = maxP - 1; i >= 0; i--) {
//     if (s[i] === '#') {
//       backSpaceS.push(s[i]);
//     } else {
//       if (s[i] != null) {
//         if (backSpaceS.length > 0) {
//           backSpaceS.pop();
//         } else {
//           resS += s[i];
//         }
//       }
//     }

//     if (t[i] === '#') {
//       backSpaceT.push(t[i]);
//     } else {
//       if (t[i] != null) {
//         if (backSpaceT.length > 0) {
//           backSpaceT.pop();
//         } else {
//           resT += t[i];
//         }
//       }
//     }
//   }
//   return resS == resT;
// };

var backspaceCompare2 = (s, t) => {
  var p1 = s.length - 1;
  var p2 = t.length - 1;
  while (p1 >= 0 || p2 >= 0) {
    if (s[p1] === '#' || t[p2] === '#') {
      if (s[p1] === '#') {
        let backCount = 2;
        while (backCount > 0) {
          p1--;
          backCount--;
          if (s[p1] === '#') {
            backCount += 2;
          }
        }
      }
      if (t[p2] === '#') {
        let backCount = 2;
        while (backCount > 0) {
          p2--;
          backCount--;
          if (t[p2] === '#') {
            backCount += 2;
          }
        }
      }
    } else {
      if (s[p1] != t[p2]) {
        return false;
      } else {
        p1--;
        p2--;
      }
    }
  }
  return true;
};
// var s = 'ab##',
//   t = 'c#d#';

var s = 'abc#d';
t = 'abzz##d';
backspaceCompare2(s, t);
