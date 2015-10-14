package com.mikeabney.katas.dice;

import com.mikeabney.katas.dice.command.Command;

public class Menu {
    private static final String mainMenuText = "Available commands:\n" +
            "\troll = Roll the cup of dice.\n" +
            "\tdie [sides] {loaded value} = Add a die, optionally with a loaded value.\n" +
            "\tempty = Empty the cup.\n" +
            "\texit = Guess.\n" +
            "Commands may be abbreviated to the smallest number of unique letters. Extra arguments are ignored.";
    private static final String helloText = "--- Welcome to the Dice Cup application! ---";

    public String printHello() {
       return helloText;
    }

    public String printCommandList() {
        return mainMenuText;
    }

    public Command getCommandForEntry(String entry) {
        switch (entry) {
            case "r" :
            case "ro" :
            case "rol" :
            case "roll" :
                return Command.ROLL;
            case "d" :
            case "di" :
            case "die" :
                return Command.DIE;
            case "em" :
            case "emp" :
            case "empt" :
            case "empty" :
                return Command.EMPTY;
            case "ex" :
            case "exi" :
            case "exit" :
                return Command.EXIT;
            default :
                throw new IllegalArgumentException("Command ambiguous or not found.");
        }
    }
}
