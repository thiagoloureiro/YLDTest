# Code Challenge

We'd like you to complete a short programming exercise in C#. It shouldn't take longer than an hour to complete. Hopefully you will find the challenge fun!

We are interested in seeing your ability to solve an algorithmic problem.

It may be tempting to Google the answer for it if you're getting stuck. Please don't. We know there are solutions out there on the internet. Keep calm, you may find it helps to work through the data structures and how they flow through the execution of the algorithm in a simple example case.

If we like your submission and ask you in for a face-to-face interview, there will be another short pair programming exercise.

It will be obvious if you have looked up the answer as we will ask you to extend or modify your solution in someway.

You will get the opportunity to demonstrate your skills on a different, gentler problem. (We recognise that problem-solving under the pressure of a face-to-face interview can be significantly more challenging.)

Please submit your solution and any notes as a tarball or zip file and name the file with your full name. Do not publish your solution

**Ideally**, you should implement the project using .NET Core so that we can easily assess it on any machine. However, you won't be penalised for using .NET Framework; the important thing is that your solution supports [the .NET Standard](https://github.com/dotnet/standard).

Good luck!

## Instructions

Lazy evaluation is an evaluation strategy which delays the evaluation of an expression until its value is needed.

The challenge is for you to implement an `Evaluator<T>` class. Its requirements and the specification of its interface follows.

### `public Evaluator<T>()`

A parameterless constructor that can be used for initialisation. The generic `T` parameter expresses the type on which the evaluator will operate and ultimately return.

### `public void add(Func<T, T[], T> func, params T[] additionalArgs)`

Associates a `func`, and additional arguments for said `func` with an `Evaluator<T>` instance. Note that `func` should:

* accept an accumalated value of type `T`
* accept `additionalArgs` via a second parameter of type `T[]`
* return a result of type `T`

### `public T Evaluate(T seed)`

Invokes the `Evaluator<T>` instance's functions, in the order in which they were added, and returns the result. This requires an initial seed value.

### Example

```csharp
Evaluator<int> evaluator = new Evaluator<T>();

evaluator.Add((val, additionalVals) => val / 2);
evaluator.Add((val, additionalVals) => val + additionalVals[0], 5);
evaluator.Add((val, additionalVals) => val + 1 + additionalVals[0], 20);
evaluator.Add((val, additionalVals) => val - additionalVals[0] - additionalVals[1], 5, 3);

Console.WriteLine(evaluator.Evaluate(8)); // 22
```

## Submission

TODO
