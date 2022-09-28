/*У нас есть график, где даны отрезок 1 - (х1; x2) и отрезок 2 (х3, x4)
​Необходимо составить код, который находит их пересечение.
Пересечением двух отрезка 1 и 2 могут быть - отрезок, точка или ничего
С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, 
общую точку или «не пересекаются».*/



int[] creatArray(int x, int y){// функц. для заполнения масива по точкам
    int[] arr = new int[Math.Abs(x-y)+1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (x<y) { // заполняем масив от меньшего значения к большему
            arr[i] = x;
            x++;
        }
        else arr[i] = y;
             y++;
        }
    return arr;
}
void lookArr(int[] arr){ // ввывести массив в консоль
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");
    }
}

void compareArr(int[] arr1, int[] arr2){ // веселье, сравниваю 2 массива если есть совпадения выводм в консоль
    int cunt = 0;
    if (arr1.Length > arr2.Length) {// первый for для более длинного мас. чтобы пройти все элементы
        for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j]){
                Console.Write("точка пересеченя "+arr1[i]+" ");
                cunt++;
            }
        }
    }
    } else {
        for (int i = 0; i < arr2.Length; i++)
    {
        for (int j = 0; j < arr1.Length; j++)
        {
            if (arr2[i] == arr1[j]){
                Console.Write("точка пересеченя "+arr2[i]+" ");
                cunt++;
            }
        }
    }
    }
    if (cunt == 0) Console.WriteLine("нет пересечений");
    
}



int x1 = new Random().Next(-100,100);
Console.WriteLine("x1 = "+x1);
int x2 = new Random().Next(-100,100);
Console.WriteLine("x2 = "+x2);
int x3 = new Random().Next(-100,100);
int x4 = new Random().Next(-100,100);

int[] array1 = creatArray(x1,x2); // заполняем массивы (получаем наши отрезки)
int[] array2 = creatArray(x3,x4);
lookArr(array1);
Console.WriteLine("");

Console.WriteLine("x3 = "+x3);
Console.WriteLine("x4 = "+x4);
lookArr(array2);

compareArr(array1,array2); // сравниваем 2 массива на пересечение