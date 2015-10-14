package com.jlivesay.lesson1.domain;

public class DiceGame {

	public static void main(String[] args) {
		Dice dice = new Dice();
		System.out.println("Rolling Dice");
		System.out.println();
		dice.roll();
		System.out.println("Die 1 hits: " + dice.getDie1());
		System.out.println("Die 2 hits: " + dice.getDie2());
		int dieTotal = dice.getDie1() + dice.getDie2();
		System.out.println("Total: " + dieTotal);
	}

}
