/**
 * @param {number[]} heights
 * @return {number}
 */
var trap = function (heights) {
  var total = 0;
  var len = heights.length;
  var arr = [];
  var maxR = 0;
  var maxL = 0;

  for (var i = len - 1; i >= 0; i--) {
    if (heights[i] > maxR) {
      maxR = heights[i];
    }
    arr[i] = maxR;
  }

  for (var i = 0; i < len; i++) {
    if (heights[i] > maxL) {
      maxL = heights[i];
    }
    total += Math.min(maxL, arr[i]) - heights[i];
  }
  return total;
};

var height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
console.log(trap(height));
