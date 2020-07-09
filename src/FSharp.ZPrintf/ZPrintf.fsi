namespace FSharp

open System.IO
open Printf
// open Cysharp.Text

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module ZPrintf =

    // type Utf16ValueStringBuilderFormat<'T, 'Result> = Format<'T, Utf16ValueStringBuilder, unit, 'Result>
    // type Utf8ValueStringBuilderFormat<'T, 'Result> = Format<'T, Utf8ValueStringBuilder, unit, 'Result>
    // type Utf16ValueStringBuilderFormat<'T> = Utf16ValueStringBuilderFormat<'T, unit>
    // type Utf8ValueStringBuilderFormat<'T> = Utf8ValueStringBuilderFormat<'T, unit>

    // [<CompiledName("PrintFormatToStringBuilder")>]
    // val bprintf : builder:Utf16ValueStringBuilder -> format:Utf16ValueStringBuilderFormat<'T> -> 'T

    [<CompiledName("PrintFormatToTextWriter")>]
    val fprintf : textWriter:TextWriter -> format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormatLineToTextWriter")>]
    val fprintfn : textWriter:TextWriter -> format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormatToError")>]
    val eprintf : format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormatLineToError")>]
    val eprintfn : format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormat")>]
    val printf : format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormatLine")>]
    val printfn : format:TextWriterFormat<'T> -> 'T

    [<CompiledName("PrintFormatToStringThen")>]
    val sprintf : format:StringFormat<'T> -> 'T

    // [<CompiledName("PrintFormatToStringBuilderThen")>]
    // val kbprintf : continuation:(unit -> 'Result) -> builder:Utf16ValueStringBuilder -> format:Utf16ValueStringBuilderFormat<'T,'Result> -> 'T

    [<CompiledName("PrintFormatToTextWriterThen")>]
    val kfprintf : continuation:(unit -> 'Result) -> textWriter:TextWriter -> format:TextWriterFormat<'T,'Result> -> 'T

    [<CompiledName("PrintFormatThen")>]
    val kprintf  : continuation:(string -> 'Result) -> format:StringFormat<'T,'Result> -> 'T

    [<CompiledName("PrintFormatToStringThen")>]
    val ksprintf : continuation:(string -> 'Result) -> format:StringFormat<'T,'Result> -> 'T

    [<CompiledName("PrintFormatToStringThenFail")>]
    val failwithf: format:StringFormat<'T,'Result> -> 'T

    // [<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
    // module Utf8 =

    //     [<CompiledName("PrintFormatToStringBuilder")>]
    //     val bprintf : builder:Utf8ValueStringBuilder -> format:Utf8ValueStringBuilderFormat<'T> -> 'T

    //     [<CompiledName("PrintFormatToStringBuilderThen")>]
    //     val kbprintf : continuation:(unit -> 'Result) -> builder:Utf8ValueStringBuilder -> format:Utf8ValueStringBuilderFormat<'T,'Result> -> 'T
