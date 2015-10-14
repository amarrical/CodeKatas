package com.mikeabney.katas.dice;

public class Main {
    public static void main(String... args) {
        Menu menu = new Menu();
        Engine engine = new Engine();
        EventLoop eventLoop = new EventLoop(menu, engine);
        eventLoop.start();
    }
}
