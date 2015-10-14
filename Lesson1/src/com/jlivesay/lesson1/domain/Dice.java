package com.jlivesay.lesson1.domain;

public class Dice {

	private int die1 = 0;
	public int getDie1() {
		return die1;
	}



	public void setDie1(int die1) {
		this.die1 = die1;
	}



	public int getDie2() {
		return die2;
	}



	public void setDie2(int die2) {
		this.die2 = die2;
	}



	private int die2 = 0;
	
	
	
	public void roll() {
		this.setDie1(1 + (int)(6 * Math.random()));
		this.setDie2(1 + (int)(6 * Math.random()));
	}
	
	

}
