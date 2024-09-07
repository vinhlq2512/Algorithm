// Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"

function LongestWord(sen) {
  var longest = 0;
  var res = '';

  var splited = sen.split(' ');
  const regex = /^[a-zA-Z0-9]+$/;
  splited.forEach((e) => {
    if (regex.test(e) && e.length > longest) {
      longest = e.length;
      res = e;
    }
  });
  return res;
}

console.log(LongestWord('I love dogs'));
