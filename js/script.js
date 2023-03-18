import { GameLogic } from "./GameLogic.js"
import { GameState } from "./GameStates.js"

let gameLogic = new GameLogic();

document.addEventListener("DOMContentLoaded", () => {
    document.getElementById("guessBtn").addEventListener("click", handleInputNumber);
    document.getElementById("reiniciar").addEventListener("click", handleRestartGame);
    updateScore();
});

function handleInputNumber() {
    const input = document.getElementById("number").value;
    const error = document.getElementById("error");
    
    error.textContent = "";
    error.style.display = "none";
    if(!inputIsOnlyNumbers(input)) {
        error.textContent = "Porfavor, ingrese solo numeros!";
        error.style.display = "block";
        return;
    }

    let state = gameLogic.guessNumber(parseInt(input));
    handleGameState(state);
    updateScore();
}

function handleGameState(gameState) {
    const contenedor = document.getElementById("contenedor");
    const estado = document.getElementById("estado");
    const botonReiniciar = document.getElementById("reiniciar");
    const botonIntentar = document.getElementById("guessBtn");
    let numIngresado = document.getElementById("number").value;
    switch(gameState) {
        case GameState.YouWon:
            contenedor.style.backgroundColor = "lightgreen";
            estado.textContent = "GANASTE!!";
            botonReiniciar.style.display = "inline-block";
            botonIntentar.disabled = true;
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
            botonReiniciar.style.display = "inline-block";
            botonIntentar.disabled = true;
            break;
    }
}

function updateScore() {
    document.getElementById("score").textContent = gameLogic.getScore();
}

function inputIsOnlyNumbers(input) {
    return /^\d+$/.test(input);
}

function handleRestartGame() {
    gameLogic = new GameLogic();
    document.getElementById("guessBtn").disabled = false;
    document.getElementById("reiniciar").style.display = "none";
    estado.textContent = "Ingresa un numero...";
    updateScore();
}