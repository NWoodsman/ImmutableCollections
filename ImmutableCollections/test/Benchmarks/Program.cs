using BenchmarkDotNet;
using BenchmarkDotNet.Running;
using Benchmarks;

BenchmarkRunner.Run<Benchmarks.Vector.BenchmarkMergeVector>();