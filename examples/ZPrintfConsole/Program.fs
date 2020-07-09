module Program

type Record = {
  Test: string
}

[<EntryPoint>]
let main argv =

    FSharp.ZPrintf.printfn "Hello %s!" "ZPrintf"

    {
      Test = "example record"
    }
    |> FSharp.ZPrintf.printfn "%A"

    0
