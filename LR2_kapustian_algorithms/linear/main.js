const num = +prompt('Введіть шукане число')
const size = +prompt('Введіть довжину масиву')
let arr = []
document.writeln(`Шукане число ${num}</br> Масив</br>`)
for (let i = 0; i < size; i++) {
   do {
      arr[i] = +prompt(`Введіть ${i + 1} елемент`)
   } while (isNaN(arr[i]))
   document.writeln(`${arr[i]} `)
}
let iOfNum;
for (let i = 0; i < arr.length; i++) {
   if (arr[i] === num) {
      iOfNum = i
      break;
   }
}
if (iOfNum) {
   document.writeln(`</br> Індекс шуканого числа ${iOfNum}`)
} else {
   document.writeln(`</br> Число не знайдено`)
}