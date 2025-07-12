using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)] // Run test classes in parallel
[assembly: LevelOfParallelism(2)] // Number of threads to use
