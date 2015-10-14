package com.mikeabney.katas.dice;

import com.mikeabney.katas.dice.command.Command;

public class EventLoop {
    private final Menu menu;
    private final Engine engine;

    public EventLoop(Menu menu, Engine engine) {
        this.menu = menu;
        this.engine = engine;
    }

    public void start() {
        System.out.println(menu.printHello());
        Command command = null;
        do {
            System.out.println(menu.printCommandList());
            String input = System.console().readLine();
            String[] inputElements = input.split("\\s");
            try {
                command = menu.getCommandForEntry(inputElements[0]);
                switch (command) {
                    case ROLL :
                        System.out.println("Result: " + engine.roll());
                        String dieOrDice = cupSize == 1 ? "die" : "dice";
                        System.out.println(String.format("Result of rolling %d %s: %d", cupSize, dieOrDice, engine.roll()));
                        break;
                    case DIE :
                        if (inputElements.length > 2) {
                            engine.addLoadedDie(Integer.valueOf(inputElements[1]),
                                    Integer.valueOf(inputElements[2]));
                        } else {
                            engine.addDie(Integer.valueOf(inputElements[1]));
                        }
                        break;
                    case EMPTY:
                        engine.emptyCup();
                        break;
                }
            }
            catch (IllegalArgumentException ex) {
                System.out.println(ex.getMessage());
            }
            catch (IndexOutOfBoundsException ex) {
                System.out.println("Wrong number of arguments.");
            }
            System.out.println("\n\n");
        } while (command != Command.EXIT);
    }
}
