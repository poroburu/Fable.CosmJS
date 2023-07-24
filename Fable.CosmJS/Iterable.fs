module Fable.CosmJS.Iterable


(*
In F#, the closest concept to a TypeScript Iterable is a sequence, which is represented by the seq<'T> type.

A seq<'T> in F# is a logical series of elements of type 'T that can be enumerated over, much like an Iterable<T> in TypeScript.

But it's worth noting that there are important differences between Iterable in TypeScript and seq in F#:

F# sequences are lazily evaluated, meaning that elements are only computed as they are enumerated, which allows you to create and work with infinite sequences.
In TypeScript, an Iterable has a Symbol.iterator function that returns an iterator, which is used to iterate over the collection. In F#, a sequence does not expose a similar function; instead, you can use functions like Seq.iter to iterate over a sequence.
While the semantics and usage are not exactly the same, seq<'T> is generally the closest type to Iterable<T> in F#.

Here's how you could define the IterableIterator interface in F#:

```fsharp
open System

type IteratorYieldResult<'TYield> =
    abstract member done: bool with get, set
    abstract member value: 'TYield with get, set

type IteratorReturnResult<'TReturn> =
    abstract member done: bool with get, set
    abstract member value: 'TReturn with get, set

type IteratorResult<'T, 'TReturn> =
    | IteratorYieldResult of IteratorYieldResult<'T>
    | IteratorReturnResult of IteratorReturnResult<'TReturn>

type Iterable<'T> =
    abstract member iterator: unit -> seq<'T>
    
type Iterator<'T, 'TReturn, 'TNext> =
    abstract member next: unit -> IteratorResult<'T, 'TReturn>
    abstract member return: unit -> Option<IteratorResult<'T, 'TReturn>>
    abstract member throw: Exception -> Option<IteratorResult<'T, 'TReturn>>

type IterableIterator<'T> =
    inherit Iterable<'T>
    abstract member iterator: unit -> IterableIterator<'T>
```
Please note that this is a conceptual translation and may not fully encompass the TypeScript definition or functionality. There are differences in exception handling and in the handling of done in IteratorYieldResult and IteratorReturnResult. In the F# implementation, sequences will handle exceptions during enumeration and the concept of done is managed by the seq type itself.
*)
type Iterable<'T> =
    abstract member iterator: unit -> seq<'T>