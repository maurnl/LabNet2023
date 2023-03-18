import { GameLogic } from "./GameLogic.js"
import { GameState } from "./GameStates.js"

let gameLogic = new GameLogic();

document.addEventListener("DOMContentLoaded", () => {
    document.getElementById("guessBtn").addEventListener("click", handleInputNumber);
    updateScore();
});

function handleInputNumber() {
    let input = document.getElementById("number").value;

    if(inputIsOnlyNumbers(input)) {
        alert("Porfavor, ingrese solo numeros!");
        return;
    }

    let state = gameLogic.guessNumber(parseInt(input));
    handleGameState(state);
    updateScore();
}

function handleGameState(gameState) {
    let contenedor = document.getElementById("contenedor");
    let estado = document.getElementById("estado");
    let numIngresado = document.getElementById("number").value;
    switch(gameState) {
        case GameState.YouWon:
            contenedor.style.backgroundColor = "lightgreen";
            estado.textContent = "GANASTE!!";
            break;
        case GameState.TooHigh:
            contenedor.style.backgroundColor = "lightyellow";
            estado.textContent = `${numIngresado} es muy alto!! Intenta un valor mas bajo...`;
            break;
        case GameState.TooLow:
            contenedor.style.backgroundColor = "lightblue";
            estado.textContent = `${numIngresado} es muy bajo!! Intenta un valor mas alto...`;
            break;
        case GameState.YouLose:
            contenedor.style.backgroundColor = "lightred";
            estado.textContent = "Perdiste!! Reinicia para volver a intentar!!";
            break;
    }
}

function updateScore() {
    document.getElementById("score").textContent = gameLogic.getScore();
}

function inputIsOnlyNumbers(input) {
    return !/^\d+$/.test(input);
}
