import { GameState } from "./GameStates.js"

export class GameLogic {
    // top bound number
    static MAX_NUMBER = 20;
    #gameOver;
    #playerWon;
    #score;
    #secretNumber;
    #currentHighscore = Number.MIN_VALUE;

    constructor() {
        this.#gameOver = false;
        this.#playerWon = false;
        this.#score = 20;
        this.#secretNumber = Math.floor(Math.random() * GameLogic.MAX_NUMBER);
    }

    guessNumber(number) {
        let status;
        if(number == this.#secretNumber) {
            status = GameState.YouWon;
            this.#gameOver = true;
            this.#playerWon = true;
            this.#setHighScore();
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

    #setHighScore() {
        if(this.#score > this.#currentHighscore) {
            this.#currentHighscore = this.#score;
        }
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

    getHighScore() {
        return this.#currentHighscore;
    }
}
