package main;

import java.util.Random;

/**
 * Created by caryd on 10/14/2015.
 */
public class Roll {
    private Cup cup;
    public Random randomGenerator = new Random();

    public Roll(Cup cup){
        this.cup = cup;
    }

    public Roll(){};

    public int roll(Cup cup){
        Integer total=0;
        for(Dice dice: cup.getDieList()){
            Integer dieRoll = 0;
            int sides = dice.getNumberOfSides();
            dieRoll = randomGenerator.nextInt(dice.getNumberOfSides());
            total += dieRoll;
        }
        return total;
    }
}
