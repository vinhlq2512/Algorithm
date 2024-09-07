//https://leetcode.com/problems/maximum-subarray/description/

/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function (nums) {
  let res = nums[0];
  let total = 0;

  for (let n of nums) {
    if (total < 0) {
      total = 0;
    }

    total += n;

    res = res > total ? res : total;
  }

  return res;
};

var nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

var res = maxSubArray(nums);
console.log(res);
