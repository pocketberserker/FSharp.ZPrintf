module FSharp.ZPrintf.Tests.ZPrintfTest

open Xunit

[<Fact>]
let ``int test`` () =
    Assert.Equal(sprintf "%i" 1, FSharp.ZPrintf.sprintf "%i" 1)

[<Fact>]
let ``string test`` () =
    Assert.Equal(sprintf "%s" "test", FSharp.ZPrintf.sprintf "%s" "test")

type TestRecord = {
  Test: string
}

[<Fact>]
let ``object test`` () =
    Assert.Equal(sprintf "%A" 1, FSharp.ZPrintf.sprintf "%A" 1)
    Assert.Equal(sprintf "%A" "record", FSharp.ZPrintf.sprintf "%A" "record")
    Assert.Equal(sprintf "%A" [0..10], FSharp.ZPrintf.sprintf "%A" [0..10])
    let record = {
      Test = "test"
    }
    Assert.Equal(sprintf "%A" record, FSharp.ZPrintf.sprintf "%A" record)

let test fmt arg (expected:string) =
    let actual = sprintf fmt arg
    Assert.Equal(expected, actual)

[<Fact>]
let ``format and precision specifiers``() =
    test "%10s"  "abc" "       abc"
    test "%-10s" "abc" "abc       "
    test "%10d"  123   "       123"
    test "%-10d" 123   "123       "
    test "%10c"  'a'   "         a"
    test "%-10c" 'a'   "a         "
