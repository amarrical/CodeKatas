package com.mikeabney.katas.fizzbuzzplus;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.IntStream;

public class AcceptanceExamples {
    Mutator mutator;

    @Before
    public void setUp() {
        mutator = new Mutator();
        mutator.addReplacement(3, "fizz");
        mutator.addReplacement(5, "buzz");
    }

    @Test
    public void standardFizzBuzzShouldWork() {
        List<String> fizzBuzz1to16 = Arrays.asList(new String[] {
                "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz",
                "11", "fizz", "13", "14", "fizzbuzz", "16"
        });
        Assert.assertEquals(fizzBuzz1to16, mutator.mutate(IntStream.rangeClosed(1, 16)));
    }

    @Test
    public void clearedMutatorShouldNotReplaceAnything() {
        List<String> plain1to16 = Arrays.asList(new String[] {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16"
        });
        mutator.clear();
        Assert.assertEquals(plain1to16, mutator.mutate(IntStream.rangeClosed(1, 16)));
    }

    @Test
    public void fizzBuzzPlusTazzFor4ShouldWork() {
        List<String> fizzBuzzTazz1to20 = Arrays.asList(new String[] {
                "1", "2", "fizz", "tazz", "buzz", "fizz", "7", "tazz", "fizz", "buzz",
                "11", "fizztazz", "13", "14", "fizzbuzz", "tazz", "17", "fizz", "19", "tazzbuzz"
        });
        mutator.addReplacement(4, "tazz");
        Assert.assertEquals(fizzBuzzTazz1to20, mutator.mutate(IntStream.rangeClosed(1, 20)));
    }

    @Test
    public void fizzTazzShouldWork() {
        List<String> fizzTazz1to20 = Arrays.asList(new String[] {
                "1", "2", "fizz", "tazz", "5", "fizz", "7", "tazz", "fizz", "10",
                "11", "fizztazz", "13", "14", "fizz", "tazz", "17", "fizz", "19", "tazz"
        });
        mutator.removeReplacement(5);
        mutator.addReplacement(4, "tazz");
        Assert.assertEquals(fizzTazz1to20, mutator.mutate(IntStream.rangeClosed(1, 20)));
    }

    @Test
    public void emptyRangeShouldGiveEmptyList() {
        List<String> empty = new ArrayList<>();
        Assert.assertEquals(empty, mutator.mutate(IntStream.range(1, 1)));
    }

    @Test
    public void negativeRangeShouldWork() {
        List<String> empty = Arrays.asList(new String[] {
                "-16", "fizzbuzz", "-14", "-13", "fizz", "-11", "buzz",
                "fizz", "-8", "-7", "fizz", "buzz", "-4", "fizz", "-2", "-1", "fizzbuzz"
        });
        Assert.assertEquals(empty, mutator.mutate(IntStream.range(-16, 1)));
    }

    @Test
    public void reverseRangeShouldGiveEmptyList() {
        List<String> empty = new ArrayList<>();
        Assert.assertEquals(empty, mutator.mutate(IntStream.range(5, -1)));
    }
}
