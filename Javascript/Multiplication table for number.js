function multiTable(number) {
  let response = "";
  for (let i = 1; i <= 10; i++) {
    response +=
      i < 10
        ? `${i} * ${number} = ${i * number} \n`
        : `${i} * ${number} = ${i * number}`;
  }
  return response;
}

console.log(multiTable(5));
