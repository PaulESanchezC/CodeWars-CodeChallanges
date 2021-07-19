function solution(str) {
  let splitedStrings = [];
  let j;
  let u = "_";
  for (let i = 0; i < str.length; i += 2) {
    j = i + 1;
    splitedStrings[i == 0 ? i : i / 2] =
      str[i] + (j >= str.length ? u : str[j]);
  }
  return splitedStrings;
}

console.log(solution("abcdefg"));

function solution(str) {
  arr = [];
  for (var i = 0; i < str.length; i += 2) {
    second = str[i + 1] || "_";
    arr.push(str[i] + second);
  }
  return arr;
}
