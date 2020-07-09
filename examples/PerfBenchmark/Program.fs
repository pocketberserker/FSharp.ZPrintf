module Program

open System
open System.Reflection
open Cysharp.Text
open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Diagnosers
open BenchmarkDotNet.Jobs
open BenchmarkDotNet.Running

type BenchmarkConfig() as this =
    inherit ManualConfig()

    do
        this.Add(MemoryDiagnoser.Default);
        this.Add(Job.ShortRun.WithWarmupCount(1).WithIterationCount(1))

[<Config(typeof<BenchmarkConfig>)>]
type FormatBenchmark() =

    let x = Int32.Parse("100")
    let y = Int32.Parse("200")
    let z = Int32.Parse("300")
    let format = "x:{0} y:{1} z:{2}"
    let list = [0..10]

    [<Benchmark>]
    member _.StringPlus() =
        "x:" + string x + " y:" + string y + " z:" + string z

    [<Benchmark>]
    member _.StringConcat() =
        String.Concat("x:", x, " y:", y, " z:", z)

    [<Benchmark>]
    member _.ZStringConcat() =
        ZString.Concat("x:", x, " y:", y, " z:", z)

    [<Benchmark>]
    member _.StringFormat() =
        String.Format(format, x, y, z)

    [<Benchmark>]
    member _.ZStringFormat() =
        ZString.Format(format, x, y, z)

    [<Benchmark>]
    member _.Printf() =
        sprintf "x:%i y:%i z:%i" x y z

    [<Benchmark>]
    member _.ZPrintf() =
        FSharp.ZPrintf.sprintf "x:%i y:%i z:%i" x y z

    [<Benchmark>]
    member _.PrintfList() =
        sprintf "%A" list

    [<Benchmark>]
    member _.ZPrintfList() =
        FSharp.ZPrintf.sprintf "%A" list

[<EntryPoint>]
let main args =
    BenchmarkSwitcher.FromAssembly(Assembly.GetEntryAssembly()).Run(args)
    |> ignore
    0
