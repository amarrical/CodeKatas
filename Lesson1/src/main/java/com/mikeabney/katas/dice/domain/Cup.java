package com.mikeabney.katas.dice.domain;

import java.util.HashSet;
import java.util.Set;

public class Cup {
    Set<Die> dice;

    public Cup() {
        dice = new HashSet<>();
    }

    public int roll() {
        int total = 0;
        for (Die die : dice) {
            total += die.roll();
        }
        return total;
    }

    public void addDie(Die die) {
        dice.add(die);
    }

    public void empty() {
        dice.clear();
    }

    public int size() {
        return dice.size();
    }
}
