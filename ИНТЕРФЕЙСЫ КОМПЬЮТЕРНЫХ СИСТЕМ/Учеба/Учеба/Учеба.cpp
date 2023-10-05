#include <iostream>

int main() {
    int num1, chet = 0;
    int* massive = nullptr; // Инициализируем указатель как nullptr

    while (true) {
        std::cin >> num1;
        if (num1 == -1) break;

        // Увеличиваем размер массива на 1 и копируем новое значение
        int* temp = new int[chet + 1];
        for (int i = 0; i < chet; i++) {
            temp[i] = massive[i];
        }
        temp[chet] = num1;
        chet++;

        // Удаляем старый массив и обновляем указатель
        delete[] massive;
        massive = temp;
    }

    // Сортировка пузырьком
    for (int i = 0; i < chet - 1; i++) {
        for (int j = 0; j < chet - i - 1; j++) {
            if (massive[j] > massive[j + 1]) {
                // Обмен элементов
                int temp = massive[j];
                massive[j] = massive[j + 1];
                massive[j + 1] = temp;
            }
        }
    }

    for (int i = 0; i < chet; i++) {
        std::cout << massive[i] << " ";
    }

    // Освобождение выделенной памяти
    delete[] massive;

    return 0;
}
