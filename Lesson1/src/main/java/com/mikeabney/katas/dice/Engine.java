package com.mikeabney.katas.dice;

import com.mikeabney.katas.dice.domain.Cup;
import com.mikeabney.katas.dice.domain.Die;
import com.mikeabney.katas.dice.domain.LoadedDie;

public class Engine {
    private Cup cup;

    public Engine() {
        cup = new Cup();
    }

    public void emptyCup() {
        cup.empty();
    }

    public void addDie(int numberOfSides) {
        Die die = new Die(numberOfSides);
        cup.addDie(die);
    }

    public void addLoadedDie(int numberOfSides, int loadedValue) {
        LoadedDie die = new LoadedDie(numberOfSides, loadedValue);
        cup.addDie(die);
    }

    public int roll() {
        return cup.roll();
    }
}
