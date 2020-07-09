module Program

open System
open Cysharp.Text
open BenchmarkDotNet
open BenchmarkDotNet.Attributes

type Benchmarks() =

    let x = Int32.Parse("100")
    let y = Int32.Parse("200")
    let format = "x:{0}, y:{1}"

    [<Benchmark>]
    member _.StringFormat() =
        String.Format(format, x, y)

    [<Benchmark>]
    member _.ZStringFormat() =
        ZString.Format(format, x, y)

    [<Benchmark>]
    member _.Printf() =
        sprintf "x:%i, y:%i" x y

    [<Benchmark>]
    member _.ZPrintf() =
        FSharp.ZPrintf.sprintf "x:%i, y:%i" x y

[<EntryPoint>]
let main _ =
    let _summary = Running.BenchmarkRunner.Run<Benchmarks>()
    0
