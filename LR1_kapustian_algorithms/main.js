let ax, ay, az, bx, by, bz, cx, cy, cz;

do {
   ax = Number(prompt('Введіть координату х першого вектора'))
} while (isNaN(ax))
do {
   ay = Number(prompt('Введіть координату y першого вектора'))
} while (isNaN(ay))
do {
   az = Number(prompt('Введіть координату z першого вектора'))
} while (isNaN(az))
do {
   bx = Number(prompt('Введіть координату х другого вектора'))
} while (isNaN(bx))
do {
   by = Number(prompt('Введіть координату y другого вектора'))
} while (isNaN(by))
do {
   bz = Number(prompt('Введіть координату z другого вектора'))
} while (isNaN(bz))
do {
   cx = Number(prompt('Введіть координату х третього вектора'))
} while (isNaN(cx))
do {
   cy = Number(prompt('Введіть координату y третього вектора'))
} while (isNaN(cy))
do {
   cz = Number(prompt('Введіть координату z третього вектора'))
} while (isNaN(cz))

//правило трикутника

let result = (ax * by * cz) + (cx * ay * bz) + (az * bx * cy) - (cx * by * az) - (ax * bz * cy) - (bx * ay * cz);
document.writeln('Скалярний добуток векторів дорівнює ', result)


