/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
  var j = 0;
  var temp = 0;
  for (var index in nums) {
    if (nums[index] != 0) {
      temp = nums[index];
      nums[index] = nums[j];
      nums[j] = temp;
      j++;
    }
  }
};

var nums = [0, 1, 0, 3, 12];
moveZeroes(nums);
