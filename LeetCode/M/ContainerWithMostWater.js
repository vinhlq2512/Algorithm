/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function (height) {
  var left = 0;
  var right = height.length - 1;
  var maxArea = 0;
  while (left < right) {
    const heightMin = Math.min(height[left], height[right]);
    const width = right - left;
    const area = width * heightMin;
    maxArea = Math.max(maxArea, area);
    if (height[left] <= height[right]) {
      left++;
    } else {
      right--;
    }
  }
  return maxArea;
};

console.log(maxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
// idea:
// Area was impact by height or width min
// so only need to check when element have value min
