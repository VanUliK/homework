// Создать страницу, которая спрашивает имя у пользователя и выводит его с помощью функции.

function name() {
  let result = prompt("Как тебя зовут?", "");
  if (result === null) {
    alert("Ты не ввёл имя");
    return name();
  } else {
    alert(`Привет, ${result}`);
  }
  return result;
}

// if (result === null) {
//   alert("Ты не ввёл имя");
// } else {
//   alert(`Привет, ${result}`);
// }

// if (confirm("Вы уверены?")) {
//   alert("Мы рады, что Вы уверены!");
// } else {
//   alert("Жаль, что Вы не уверены...");
// }

// const result = prompt("Hello", "default_name");
// alert(result);

// if (confirm("Вы уверены?")) {
//   alert("Мы рады, что Вы уверены!");
// } else {
//   alert("Жаль, что Вы не уверены...");
// }

// const max = {
//   name: "Ivan",
//   age: 35,
//   profession: "bezdelnik",
//   city: "Kaliningrad",
// };

// const maxCity = {
//   City: 2,
//   Moscow: 3,
//   Piter: 12,
// };

// const years = Object.values(maxCity);
// function sum(arr) {
//   let sum = 0;

//   for (let i = 0; i < arr.length; i++) {
//     sum += arr[i];
//   }

//   return sum;
// }
// alert(`${sum(years)}`);

// const array = [];
// array.length = Math.floor(Math.random() * 10);

// for (let i = 0; i < array.length; i++) {
//   array[i] = Math.floor(Math.random() * 10);
// }
// const m = array.length - 1;
// alert(`${array[m]}`);
