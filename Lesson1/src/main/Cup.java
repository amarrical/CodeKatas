package main;

/**
 * Created by caryd on 10/14/2015.
 */
public class Cup {
    private Dice dice;
    private Dice[] dieList;
    private Integer numberOfDiceInCup = 0;

    public void setDieList(Dice dice){
        Integer dieCount = 0;
        if (dieList.length > 0) {
            dieCount = dieList.length +1;
        }
        dieList[dieCount]=dice;
    }

    public Dice[] getDieList(){
        return dieList;
    }

    public void setNumberOfDiceInCup(int number){
        numberOfDiceInCup = number;
    }

    public int getNumberOfDiceInCup(){
        return numberOfDiceInCup;
    }
}
