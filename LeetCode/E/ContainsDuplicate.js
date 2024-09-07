/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
  const res = {};
  return nums.some((element) => {
    if (res[element]) {
      return true;
    } else {
      res[element] = true;
    }
    return false;
  });
};

var containsDuplicate2 = function (nums) {
  var set = new Set(nums);
  return set.size !== nums.length;
};

var nums = [1, 2, 3, 1];

console.log(containsDuplicate2(nums));
