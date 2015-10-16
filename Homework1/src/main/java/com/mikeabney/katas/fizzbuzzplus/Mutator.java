package com.mikeabney.katas.fizzbuzzplus;

import java.util.List;
import java.util.NavigableSet;
import java.util.TreeMap;
import java.util.stream.Collectors;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class Mutator {
    private final TreeMap<Integer, String> replacementMap;

    public Mutator() {
        this.replacementMap = new TreeMap<>();
    }

    public void addReplacement(Integer number, String replacement) {
        replacementMap.put(number, replacement);
    }

    public void removeReplacement(Integer number) {
        replacementMap.remove(number);
    }

    public void clear() {
        replacementMap.clear();
    }

    public List<String> mutate(IntStream range) {
        return range.mapToObj(number -> Mutator.this.mutate(number))
                .collect(Collectors.toList());
    }

    private String mutate(Integer number) {
        NavigableSet<Integer> keySet = replacementMap.navigableKeySet();

        Stream<Integer> divisibleKeyStream = keySet.stream()
                .filter(key -> number % key == 0);

        Stream<String> replacementStream = divisibleKeyStream
                .map(key -> Mutator.this.replacementMap.get(key));

        String replacement = replacementStream.collect(Collectors.joining());

        return replacement.isEmpty() ? number.toString() : replacement;
    }
}
