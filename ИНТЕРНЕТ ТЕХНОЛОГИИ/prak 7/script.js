function checkEvenness() {
    const number = parseInt(prompt('Введите число:'));
    if (isNaN(number)) {
        alert('Это не число!');
        return;
    }

    if (number % 2 === 0) {
        document.body.style.backgroundColor = 'green'; // Цвет для четного числа
        window.open('', '', 'width=200, height=100').document.body.innerHTML = 'Число четное';
    } else {
        document.body.style.backgroundColor = 'red'; // Цвет для нечетного числа
        window.open('', '', 'width=200, height=100').document.body.innerHTML = 'Число нечетное';
    }
}