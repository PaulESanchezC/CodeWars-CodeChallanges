function solution(string) {
  let words = "";
  for (var key in string)
    words +=
      string[key] == string[key].toUpperCase()
        ? " " + string[key]
        : string[key];

  return words.trim();
}
console.log(solution("CamelCasingTest"));
