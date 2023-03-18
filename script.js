import { GameLogic } from "./GameLogic.js"

let gameLogic = new GameLogic();

document.addEventListener("DOMContentLoaded", () => {
    document.getElementById("guessBtn").addEventListener("click", handleInputNumber);
    updateScore();
});

function handleInputNumber(event) {
    let input = document.getElementById("number").value;
    if(inputIsOnlyNumbers(input)) {
        alert("Porfavor, ingrese solo numeros!");
        return;
    }
    alert("Bien!")
    updateScore();
}

function updateScore() {
    document.getElementById("score").textContent = gameLogic.getScore();
}

function inputIsOnlyNumbers(input) {
    return !/^\d+$/.test(input);
}
