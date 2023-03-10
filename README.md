# FinalTest_N.Borovik

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.

Описание решения:

1. Вводится произвольный массив строк.

2. Вводится метод ToStringWithMax3Chars для фильтрации строк в массиве, принимающий на вход массив и выдающий на выходе итоговый массив с 
отфильтрованный элементами.
2.1. Так как длина итогового массива неизвестна, вводится временный массив строк той же длиной, что и исходный, и вводится счетчик count для 
подсчета длины итогового массива.
2.2. В рамках цикла по всем элементам исходного массива: с помощью системного метода String.ToCharArray разбиваем каждый элемент исходного массива 
на массив символов и проверяем его длину. Если <= 3 (согласно условиям задачи), то текущий элемент исходного массива записывается во временный массив.
2.3. Таким образом получаем временный массив с отфильтрованными элементами, а также количество отфильтрованных элементов (count). 
Если это кол-во меньше длины исходного массива, то во временном массиве есть пустые ненужные позиции.
2.4. Создаем итоговый массив длиной count и цикломпо длине итогового массива переписываем в него элементы временного массива.
2.5. Возвращаем итоговый массив.

3. За рамками метода создаем новый массив с применением описанного метода.

4. Выводим итоговый метод на экран с помощью системного метода String.Join.
