let numbers = [];
function descendingOrder(n) {
  if (n > 1) {
    for (let i = 0; i < n.toString().length; i++) {
      numbers[i] = n.toString()[i];
    }
    return parseInt(numbers.sort().reverse().join(""));
  } else return n;
}
console.log(descendingOrder(1));
