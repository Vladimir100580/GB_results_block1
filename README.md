# Алгоритм программы
### которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
1. Задаем или вводим массив_1.
2. Выводим массив_1 на экран.
3. Реализуем метод arrayFormation:
    - находим количество(n) элементов(строк) в массиве_1, имеющих длинну меньше 4.
    - создаем пустой массив_2 полученной длины(n)
    - Пробегаем по всем элементам массива_1 и, если длина текущего элемента меньше 4, то добавляем в массив_2 рассматриваемый элемент массива_1, увеличивая индекс массива (скажем, в переменной m) каждый раз на 1, после присваивания.
4. Выводим массив_2 на экран.