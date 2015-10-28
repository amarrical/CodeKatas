We're doing Fizz Buzz!

Requirements:
Java or C#
TDD
Console application
Must accept a minimum and maximum number to display.
Must accept a "mutator" (divisor to replace and replacement).
Must allow compound replacements in numerical order of divisor.

The actual application that runs does not need to allow user input, 
	but the main program must accept these changes.
	

example main:
public static main(){
	mutator foo1 = new mutator(3, "Fizz");
	mutator foo2 = new mutator(5, "Buzz");
	int min = 1;
	int max = 16;
	
	printer printer = new printer(min, max);
	printer.addMutator(foo1);
	printer.addMutator(foo2);
	printer.print();	
}


example (3: fizz), (5: buzz) 1, 16
	
1
2
fizz
4
buzz
fizz
7
8
fizz
buzz
11
fizz
13
14
fizzbuzz
16