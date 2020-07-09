module Program

open Cysharp.Text
open FSharp.ZPrintf

type Record = {
  Test: string
}

[<EntryPoint>]
let main argv =

    printfn "Hello %s!" "ZPrintf"

    {
      Test = "example record"
    }
    |> printfn "%A"

    use sb = ZString.CreateStringBuilder()
    bprintf sb "%s%i" "foo" 42
    sb.ToString()
    |> printfn "%s"

    0
