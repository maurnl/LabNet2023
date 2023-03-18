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
        let status = "";
        if(number == this.#secretNumber) {
            status = "Ganaste!!";
            this.#gameOver = true;
            this.#playerWon = true;
        } else {
            if(number > this.#secretNumber) {
                status = "Muy alto!!";
            } else {
                status = "Muy bajo!!";
            }
            this.#score--;
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
