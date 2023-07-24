// ts2fable 0.9.0
module rec Fable.CosmJS.Stream.Concat

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Fable.CosmJS

type Array<'T> = System.Collections.Generic.IList<'T>

type Stream<'T> = XStream.Stream<'T>

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// An implementation of concat that buffers all source stream events
    /// 
    /// Marble diagram:
    /// 
    /// <code lang="text">
    /// --1--2---3---4-|
    /// -a--b-c--d-|
    /// --------X---------Y---------Z-
    ///           concat
    /// --1--2---3---4-abcdXY-------Z-
    /// </code>
    /// 
    /// This is inspired by RxJS's concat as documented at <see href="http://rxmarbles.com/#concat" /> and behaves
    /// differently than xstream's concat as discussed in <see href="https://github.com/staltz/xstream/issues/170." />
    /// </summary>
    abstract concat: [<ParamArray>] streams: Array<Stream<'T>> -> Stream<'T>