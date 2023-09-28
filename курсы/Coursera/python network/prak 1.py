import re

# Открываем файл для чтения
with open('your_file.txt', 'r') as file:
    # Используем регулярное выражение для поиска всех чисел
    numbers = re.findall(r'\d+', file.read())
    
    # Преобразуем найденные числа из строк в целые числа и суммируем их
    total = sum(int(num) for num in numbers)

print("Сумма чисел в файле:", total)
