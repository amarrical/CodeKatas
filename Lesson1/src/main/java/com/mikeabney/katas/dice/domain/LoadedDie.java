package com.mikeabney.katas.dice.domain;

import java.util.Random;

public class LoadedDie extends Die {
    private Random loadGenerator;
    private int loadedValue;

    public LoadedDie(int sides, int loadedValue) {
        super(sides);
        if (loadedValue < 1 || loadedValue > sides) {
            throw new IllegalArgumentException(
                    String.format("Attempt to load %i-sided die with value (%i) that doesn't match a side!",
                    sides, loadedValue));
        }
        loadGenerator = new Random(System.currentTimeMillis());
        this.loadedValue = loadedValue;
    }

    @Override
    public int roll() {
        if (loadGenerator.nextBoolean()) {
            return loadedValue;
        }
        return super.roll();
    }
}
