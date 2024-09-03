function rotate(nums, k) {
  var length = nums.length;
  k = k % length;
  var newArr = [...nums.slice(length - k, length)];

  res = [...newArr, ...nums];
  for (var i = 0; i < length; i++) {
    nums[i] = res[i];
  }
}
var nums = [1, 2, 3],
  k = 4;
console.log(rotate(nums, k));
