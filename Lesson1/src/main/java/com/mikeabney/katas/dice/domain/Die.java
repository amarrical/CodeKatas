package com.mikeabney.katas.dice.domain;

import java.util.Random;

public class Die {
    private Random generator;
    private int sides;

    public Die(int sides) {
        if (sides < 1) {
            throw new IllegalArgumentException(String.format("Attempt to create a die with negative sides [%i].", sides));
        }
        this.sides = sides;
        generator = new Random(System.currentTimeMillis());
    }

    public int roll() {
        return generator.nextInt(sides) + 1;
    }
}
