function getRandomColor() {
    // РАНДОМНЫЙ ЦВЕТ
    const letters = '0123456789ABCDEF'; //СПИСОК СИМВОЛОВ ДЛЯ СОЗДАНИИЕ РАНДОМА
    let color = '#';
    for (let i = 0; i < 6; i++) { // 6 рандомных букы
        color += letters[Math.floor(Math.random() * 16)]; //Рандомное буква
    }
    return color;
}

function updateDisplay() {
    const now = new Date(); // текущая дата
    const hours = now.getHours().toString().padStart(2, '0'); // получаю час
    const minutes = now.getMinutes().toString().padStart(2, '0'); // получаю минуту
    const seconds = now.getSeconds().toString().padStart(2, '0'); // получаю секунду
    const formattedTime = `${hours}:${minutes}:${seconds}`; // текст в виде таймера 

    document.body.style.backgroundColor = getRandomColor(); // получаю рандомный цвет и присываю его в задний фон style css
    document.body.style.color = getRandomColor(); // получаю рандомный цвет и присываю его в текст текста style css
    document.getElementById('timeDisplay').textContent = formattedTime; //присваю измененый текст в timeDisplay.
}

setInterval(updateDisplay, 1000);