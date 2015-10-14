package main;

/**
 * Created by caryd on 10/14/2015.
 */
public class Dice {
    private Integer numberOfSides;
    private Integer weight;

    public void setNumberOfSide(Integer sideCount){
        numberOfSides = sideCount;
    }

    public Integer getNumberOfSides(){
        if(numberOfSides>0){
            return numberOfSides;
        }
        return 0;
    }

}
