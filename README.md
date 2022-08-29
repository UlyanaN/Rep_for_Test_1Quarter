# Rep_for_Test_1Quarter
### Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["2"]
["Russia", "Denmark", "Kazan"] -> []

### **Описание решения**

Сначала программа запрашивает у пользователя длину массива. Считывается количество элементов массива.
Далее пользователь вводит каждый элемент врученую. Значениям присваивается строковый тип данных. 
Все элементы сохраняются в массиве данных с помощью метода *CreateArray*.
Далее следует метод *LengthOfArrayForThree*. Метод получает на вход массив и проверяет длину каждого элемента. Если длина элемента меньше или равна 3, то значение элемента помещается в новый массив. 
Чтобы убрать из полученного массива пустые значения, используется метод *ChangeArray*.
Для печати массива используется метод *PrintArray*.
Затем поочередно вызываются методы для обработки введенных пользователем данных. 
Сначала выводится исходный массив, введенный пользователем, затем выводится новый массив.
