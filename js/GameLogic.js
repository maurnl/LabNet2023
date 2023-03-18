import { GameState } from "./GameStates.js"

export class GameLogic {
    #gameOver;
    #playerWon;
    #score;
    #secretNumber;

    constructor() {
        this.#gameOver = false;
        this.#playerWon = false;
        this.#score = 20;
        this.#secretNumber = Math.floor(Math.random() * 100);
    }

    guessNumber(number) {
        let status;
        if(number == this.#secretNumber) {
            status = GameState.YouWon;
            this.#gameOver = true;
            this.#playerWon = true;
        } else {
            if(number > this.#secretNumber) {
                status = GameState.TooHigh;
            } else {
                status = GameState.TooLow;
            }
            this.#score--;
        }

        if(0 >= this.#score) {
            status = GameState.YouLose;
        }
        return status;
    }

    getScore() {
        return this.#score;
    }

    getGameOver() {
        return this.#gameOver;
    }

    getPlayerWon() { 
        return this.#playerWon;
    }
}
