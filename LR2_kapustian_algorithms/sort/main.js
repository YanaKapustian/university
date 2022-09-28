const size = +prompt('Введіть довжину масиву')
let array = []
document.writeln(`Масив</br>`)
for (let i = 0; i < size; i++) {
   do {
      array[i] = +prompt(`Введіть ${i + 1} елемент`)
   } while (isNaN(array[i]))
   document.writeln(`${array[i]} `)
}
document.writeln(` </br>Проміжні результати сортування вибором`)
function sortSelection(array) {
   let arr = [...array]
   for (let i = 0; i < arr.length - 1; i++) {
     let min = i;
     for (let j = i + 1; j < arr.length; j++) {
       if (arr[j] < arr[min]) {
         min = j;
       }
     }
     [arr[i], arr[min]] = [arr[min], arr[i]];
     document.writeln(`</br>`)
     arr.forEach(el => document.writeln(`${el} `))
   }
   return arr;
}

document.writeln(`</br> Результат ${sortSelection(array)}`)

document.writeln(` </br>Проміжні результати сортування вставками`)
function sortInsertion(array) {
   let arr = [...array]
   for (let i = 1, l = arr.length; i < l; i++) {
      let current = arr[i];
      let j = i;
      while (j > 0 && arr[j - 1] > current) {
          arr[j] = arr[j - 1];
          j--;
      }
      arr[j] = current;
      document.writeln(`</br>`)
      arr.forEach(el => document.writeln(`${el} `))
  }
  return arr
}

document.writeln(`</br> Результат ${sortInsertion(array)}`)