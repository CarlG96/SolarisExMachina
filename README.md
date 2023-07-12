# SolarisExMachina

## What is Solaris Ex Machina

Solaris Ex Machina is a monster battler RPG set in a solarpunk world in which you must travel the world defeating other mechs to take their energy cores. The primary purpose of this game is to improve my C# skills and object-oriented abilities in general.


# C# concepts to master 

## Functional C# 
### Use linq with chaining like Functional Programming in C# (What are we already doing? A few words about enumerables)

```C#
var input = new[]
{
	75,
	22,
	36
};

var output = input.Select(x => DoSomethingOne(x))
	 .Select(x => DoSomethingTwo(x))
	 .Select(x => DoSomethingThree(x))
	 .ToArray();
```

### Use select Statement with iterator to replace foreach loops
```C#
var formattedFilms = films.Select((x, i) => $"{i} - {x.Title}");
```

### Use Enumerable.Range to create a grid like below
```C#
var coords = Enumerable.Range(1, 5)
	.SelectMany(x => Enumerable.Range(1, 5)
		.Select(y => (X: x, Y: y))
);
```

### Use Linqs Sum method 

### Use Linqs Aggregate method

### Use Enumerable.Repeat

### Use Tuples for small, thrown together collections of data

### Use type switching pattern matching to detect the type of something on the mechs

```C#
public decimal CalculateNewBalance(StandardBankAccount sba)
 {
   switch (sba)
   {
      case PremiumBankAccount pba when pba.Balance > 10000:
        return pba.Balance * (pba.InterestRate + pba.BonusInterestRate);
      case MillionairesBankAccount mba:
        return (mba.Balance * mba.InterestRate) +
                 (mba.OverflowBalance & mba.InterestRate);
      case MonopolyPlayersBankAccount mba:
        return (mba.Balance * mba.InterestRate) + PassingGoBonus;
      default:
        return sba.Balance * sba.InterestRate;
   }
 }

 // C#8
 public decimal CalculateNewBalance(StandardBankAccount sba) =>
   sba switch
   {
     PremiumBankAccount { Balance: > 10000 } pba => pba.Balance *
                     (pba.InterestRate + pba.BonusInterestRate),
     MillionairesBankAccount mba => (mba.Balance * mba.InterestRate) +
                 (mba.OverflowBalance & mba.InterestRate);
     MonopolyPlayersBankAccount mba =>
                (mba.Balance * mba.InterestRate) + PassingGoBonus;
     _ => sba.Balance * sba.InterestRate
   };
 }

// Different type of pattern matching
 public enum SPS
{
	Scissor,
	Paper,
	Stone
}

public enum GameResult
{
	Win,
	Lose,
	Draw
}

var calculateMatchResult = (SPS myMove, SPS theirMove) =>
	(myMove, theirMove) switch
	{
		_ when myMove == theirMove => GameResult.Draw,
		( SPS.Scissor, SPS.Paper) => GameResult.Win,
		( SPS.Paper, SPS.Stone ) => GameResult.Win,
		(SPS.Stone, SPS.Scissor) => GameResult.Win,
		_ => GameResult.Lose
	};
```

### Use destructuring in pattern matching in C#


## OOP C#
- Use async/ await methods




















## Key aspects
- Customise your mechs
- Traverse the grid based world map
- Fight other mechs and find energy cores to continue to survive
- Don't let your energy reach zero
- Solarpunk

### Weapons

- Guns
- Missiles
- Laser
- Plasma
- Blunt
- Sharp
- Unarmed
- Electro
- Flame

### Movement (bottom)

- Treads
- Legs
- Spider
- Hover
- Roll
- Wheels


### Armour

- Light Plating
- Medium Plating
- Heavy Plating


### Shields


### Core

- Robust
- Volatile
- Overclock

