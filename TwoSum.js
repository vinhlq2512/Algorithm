//https://leetcode.com/problems/two-sum/description/

var twoSum = function (nums, target) {
  const res = {};
  for (var i = 0; i < nums.length; i++) {
    var resAbtract = target - nums[i];

    if (res[resAbtract] != null) {
      return [res[resAbtract], i];
    }
    res[nums[i]] = i;
  }
};
