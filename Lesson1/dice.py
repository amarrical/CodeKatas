import random

class Menu:
    def __init__ (self):
        self.cup = Cup()
        self.options = {
            1 : self.roll,
            2 : self.addDie,
            3 : self.cup.empty,
        }
        self.dieOptions = {
            1 : self.regularDie,
            2 : self.loadedDie
        }
        self.repl()
        
    def repl(self):
        print("1 : self.roll\n")
        print("2 : self.addDie\n")
        print("3 : self.cup.empty")
        opt = input("Option:")
        try: 
            self.options[opt]()
        except:
            self.repl()
    
    def roll(self):
        print("Dice:", len(self.cup.dice))
        print("Total:", self.cup.roll())
        self.repl()
        
    def addDie(self):
        print("double bleh")
        self.dieOptions[input()]()
        
    def regularDie(self):
        self.cup.addDie(Die(input("Number of sides:")))
        self.repl()
        
    def loadedDie(self):
        self.cup.addDie(Die(input("Number of sides:"), input("Weighted side:")))
        self.repl()
        
        
class Cup(object):
    def __init__ (self):
        self.dice = []
    def addDie(self, die):
        self.dice.append(die)
    def roll(self):
        sum = 0
        for die in self.dice:
            sum += die.roll()
        return sum
    def empty(self):
        self.dice = []

class Die(object):
    def __init__ (self, sides):
        self.sides = sides
    def roll(self):
        return random.randint(1,self.sides)
 
class LoadedDie(Die):
    def __init__ (self, sides, weight):
        self.sides = sides
        self.weight = weight
    def roll(self):
        if random.randint(0, 1):
            return self.weight
        else:    
            temp = random.randint(1,self.sides-1)
            if temp >= self.weight:
                return temp+1
            else:
                return temp
                
menu = Menu()
menu.repl()
