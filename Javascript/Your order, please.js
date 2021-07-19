function order(words) {
  let wordArray = [];
  let response = [];
  let index = 0;
  wordArray = words.split(" ");
  for (var i = 0; i < wordArray.length; i++) {
    index = containsNumber(wordArray[i]);
    response[index] = wordArray[i];
  }
  return response.slice(1, response.length).join(" ");
}

function containsNumber(word) {
  for (var i = 0; i < word.length; i++) {
    if (!isNaN(word[i])) return word[i];
  }
  return 0;
}

console.log(order("empty input should return empty string"));
