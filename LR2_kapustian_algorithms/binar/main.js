const num = +prompt('Введіть шукане число')
const size = +prompt('Введіть довжину відсортованого масиву')
let arr = []
document.writeln(`Шукане число ${num}</br> Масив</br>`)
for (let i = 0; i < size; i++) {
   do {
      arr[i] = +prompt(`Введіть ${i + 1} елемент`)
   } while (isNaN(arr[i]))
   document.writeln(`${arr[i]} `)
}
let first = 0;   
let last = arr.length - 1; 
let position = -1;
let found = false;
let middle;

while (found === false && first <= last) {
   middle = Math.floor((first + last) / 2);
   if (arr[middle] === num) {
      found = true;
      position = middle;
   } else if (arr[middle] > num) { 
      last = middle - 1;
   } else { 
      first = middle + 1;
   }
}
if (position !== -1) {
   document.writeln(`</br> Індекс шуканого числа ${position}`)
} else {
   document.writeln(`</br> Число не знайдено`)
}