// ts2fable 0.9.0
module rec Fable.CosmJS.XStream

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Array<'T> = System.Collections.Generic.IList<'T>
type PromiseLike<'T> = Fable.Core.JS.Promise<'T>

[<Import("NO", "module")>]
let NO: NO = jsNative

[<Import("NO_IL", "module")>]
let NO_IL: InternalListener<obj option> = jsNative

[<Import("xs", "module")>]
let xs: obj = jsNative

[<AllowNullLiteral>]
type IExports =
    abstract Stream: StreamStatic
    abstract MemoryStream: MemoryStreamStatic

[<AllowNullLiteral>]
type InternalListener<'T> =
    abstract _n: ('T -> unit) with get, set
    abstract _e: (obj option -> unit) with get, set
    abstract _c: (unit -> unit) with get, set

[<AllowNullLiteral>]
type InternalProducer<'T> =
    abstract _start: listener: InternalListener<'T> -> unit
    abstract _stop: (unit -> unit) with get, set

[<AllowNullLiteral>]
type OutSender<'T> =
    abstract out: Stream<'T> with get, set

[<AllowNullLiteral>]
type Operator<'T, 'R> =
    inherit InternalProducer<'R>
    inherit InternalListener<'T>
    inherit OutSender<'R>
    abstract ``type``: string with get, set
    abstract ins: Stream<'T> with get, set
    abstract _start: out: Stream<'R> -> unit

[<AllowNullLiteral>]
type Aggregator<'T, 'U> =
    inherit InternalProducer<'U>
    inherit OutSender<'U>
    abstract ``type``: string with get, set
    abstract insArr: Array<Stream<'T>> with get, set
    abstract _start: out: Stream<'U> -> unit

[<AllowNullLiteral>]
type Producer<'T> =
    abstract start: (Listener<'T> -> unit) with get, set
    abstract stop: (unit -> unit) with get, set

[<AllowNullLiteral>]
type Listener<'T> =
    abstract next: ('T -> unit) with get, set
    abstract error: (obj option -> unit) with get, set
    abstract complete: (unit -> unit) with get, set

[<AllowNullLiteral>]
type Subscription =
    abstract unsubscribe: unit -> unit

[<AllowNullLiteral>]
type Observable<'T> =
    abstract subscribe: listener: Listener<'T> -> Subscription

[<AllowNullLiteral>]
type MergeSignature =
    [<Emit("$0($1...)")>]
    abstract Invoke: unit -> Stream<obj option>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> -> Stream<'T1>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> * s2: Stream<'T2> -> Stream<U2<'T1, 'T2>>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> -> Stream<U3<'T1, 'T2, 'T3>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> -> Stream<U4<'T1, 'T2, 'T3, 'T4>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> * s5: Stream<'T5> ->
            Stream<U5<'T1, 'T2, 'T3, 'T4, 'T5>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> * s5: Stream<'T5> * s6: Stream<'T6> ->
            Stream<U6<'T1, 'T2, 'T3, 'T4, 'T5, 'T6>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> ->
            Stream<U7<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> ->
            Stream<U8<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8>>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> *
        s9: Stream<'T9> ->
            Stream<obj>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> *
        s9: Stream<'T9> *
        s10: Stream<'T10> ->
            Stream<obj>

    [<Emit("$0($1...)")>]
    abstract Invoke: [<ParamArray>] stream: Array<Stream<'T>> -> Stream<'T>

[<AllowNullLiteral>]
type CombineSignature =
    [<Emit("$0($1...)")>]
    abstract Invoke: unit -> Stream<Array<obj option>>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> -> Stream<'T1>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> * s2: Stream<'T2> -> Stream<'T1 * 'T2>

    [<Emit("$0($1...)")>]
    abstract Invoke: s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> -> Stream<'T1 * 'T2 * 'T3>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> -> Stream<'T1 * 'T2 * 'T3 * 'T4>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> * s5: Stream<'T5> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> * s2: Stream<'T2> * s3: Stream<'T3> * s4: Stream<'T4> * s5: Stream<'T5> * s6: Stream<'T6> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> *
        s9: Stream<'T9> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9>

    [<Emit("$0($1...)")>]
    abstract Invoke:
        s1: Stream<'T1> *
        s2: Stream<'T2> *
        s3: Stream<'T3> *
        s4: Stream<'T4> *
        s5: Stream<'T5> *
        s6: Stream<'T6> *
        s7: Stream<'T7> *
        s8: Stream<'T8> *
        s9: Stream<'T9> *
        s10: Stream<'T10> ->
            Stream<'T1 * 'T2 * 'T3 * 'T4 * 'T5 * 'T6 * 'T7 * 'T8 * 'T9 * 'T10>

    [<Emit("$0($1...)")>]
    abstract Invoke: [<ParamArray>] stream: Array<Stream<'T>> -> Stream<Array<'T>>

    [<Emit("$0($1...)")>]
    abstract Invoke: [<ParamArray>] stream: Array<Stream<obj option>> -> Stream<Array<obj option>>

[<AllowNullLiteral>]
type Stream<'T> =
    inherit InternalListener<'T>
    abstract _prod: InternalProducer<'T> with get, set
    abstract _ils: Array<InternalListener<'T>> with get, set
    abstract _stopID: obj option with get, set
    abstract _dl: InternalListener<'T> with get, set
    abstract _d: bool with get, set
    abstract _target: Stream<'T> option with get, set
    abstract _err: obj option with get, set
    abstract _n: t: 'T -> unit
    abstract _e: err: obj option -> unit
    abstract _c: unit -> unit
    abstract _x: unit -> unit
    abstract _stopNow: unit -> unit
    abstract _add: il: InternalListener<'T> -> unit
    abstract _remove: il: InternalListener<'T> -> unit
    abstract _pruneCycles: unit -> unit
    abstract _hasNoSinks: x: InternalListener<obj option> * trace: Array<obj option> -> bool

    /// <summary>Adds a Listener to the Stream.</summary>
    /// <param name="listener" />
    abstract addListener: listener: obj -> unit

    /// <summary>Removes a Listener from the Stream, assuming the Listener was added to it.</summary>
    /// <param name="listener" />
    abstract removeListener: listener: obj -> unit

    /// <summary>
    /// Adds a Listener to the Stream returning a Subscription to remove that
    /// listener.
    /// </summary>
    /// <param name="listener" />
    /// <returns />
    abstract subscribe: listener: obj -> Subscription

    abstract _map: project: ('T -> 'U) -> U2<Stream<'U>, MemoryStream<'U>>

    /// <summary>
    /// Transforms each event from the input Stream through a <c>project</c> function,
    /// to get a Stream that emits those transformed events.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---3--5-----7------
    ///    map(i =&gt; i * 10)
    /// --10--30-50----70-----
    /// </code>
    /// </summary>
    /// <param name="project">
    /// A function of type <c>(t: T) =&gt; U</c> that takes event
    /// <c>t</c> of type <c>T</c> from the input Stream and produces an event of type <c>U</c>, to
    /// be emitted on the output Stream.
    /// </param>
    /// <returns />
    abstract map: project: ('T -> 'U) -> Stream<'U>

    /// <summary>
    /// It's like <c>map</c>, but transforms each input event to always the same
    /// constant value on the output Stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---3--5-----7-----
    ///       mapTo(10)
    /// --10--10-10----10----
    /// </code>
    /// </summary>
    /// <param name="projectedValue">
    /// A value to emit on the output Stream whenever the
    /// input Stream emits any value.
    /// </param>
    /// <returns />
    abstract mapTo: projectedValue: 'U -> Stream<'U>

    (*
    https://github.com/staltz/xstream/blob/fee5f0d1ea23becc5aa89064624b609a105104b3/tests/operator/filter.ts
    The filter function in the tests is essentially a method that returns a new stream with only the elements that satisfy a given predicate function. From these tests, it's clear that there is no need for a 'S :> 'T constraint.

    The method with this constraint:
    `abstract filter: passes: ('T -> bool) -> Stream<'S> when 'S :> 'T`
    can be removed.

    The correct definition should be:
    `abstract filter: passes: ('T -> bool) -> Stream<'T>`
    This function takes a predicate that is a function from 'T to bool. This function is applied to each element of the stream. If the function returns true for a given element, that element is included in the resulting stream. If the function returns false for a given element, that element is not included in the resulting stream.

    The filter function then returns a new stream that only includes the elements for which the predicate function returned true.

    The test with isDog function as a type guard shows that filter function can be used to narrow down types when it is used with a predicate that is a type guard. This feature will work in F# because F# supports type guards through active patterns. But type guards are not special functions in F#. Any function returning bool can be used as a type guard when used with filter function.

    *)

    //abstract filter: passes: ('T -> bool) -> Stream<'S> when 'S :> 'T
    abstract filter: passes: ('T -> bool) -> Stream<'T>

    /// <summary>
    /// Lets the first <c>amount</c> many events from the input stream pass to the
    /// output stream, then makes the output stream complete.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --a---b--c----d---e--
    ///    take(3)
    /// --a---b--c|
    /// </code>
    /// </summary>
    /// <param name="amount">
    /// How many events to allow from the input stream
    /// before completing the output stream.
    /// </param>
    /// <returns />
    abstract take: amount: float -> Stream<'T>

    /// <summary>
    /// Ignores the first <c>amount</c> many events from the input stream, and then
    /// after that starts forwarding events from the input stream to the output
    /// stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --a---b--c----d---e--
    ///       drop(3)
    /// --------------d---e--
    /// </code>
    /// </summary>
    /// <param name="amount">
    /// How many events to ignore from the input stream
    /// before forwarding all events from the input stream to the output stream.
    /// </param>
    /// <returns />
    abstract drop: amount: float -> Stream<'T>

    /// <summary>
    /// When the input stream completes, the output stream will emit the last event
    /// emitted by the input stream, and then will also complete.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --a---b--c--d----|
    ///       last()
    /// -----------------d|
    /// </code>
    /// </summary>
    /// <returns />
    abstract last: unit -> Stream<'T>

    /// <summary>
    /// Prepends the given <c>initial</c> value to the sequence of events emitted by the
    /// input stream. The returned stream is a MemoryStream, which means it is
    /// already <c>remember()</c>'d.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// ---1---2-----3---
    ///   startWith(0)
    /// 0--1---2-----3---
    /// </code>
    /// </summary>
    /// <param name="initial">The value or event to prepend.</param>
    /// <returns />
    abstract startWith: initial: 'T -> MemoryStream<'T>

    /// <summary>
    /// Uses another stream to determine when to complete the current stream.
    ///
    /// When the given <c>other</c> stream emits an event or completes, the output
    /// stream will complete. Before that happens, the output stream will behaves
    /// like the input stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// ---1---2-----3--4----5----6---
    ///   endWhen( --------a--b--| )
    /// ---1---2-----3--4--|
    /// </code>
    /// </summary>
    /// <param name="other">
    /// Some other stream that is used to know when should the output
    /// stream of this operator complete.
    /// </param>
    /// <returns />
    abstract endWhen: other: Stream<obj option> -> Stream<'T>

    /// <summary>
    /// "Folds" the stream onto itself.
    ///
    /// Combines events from the past throughout
    /// the entire execution of the input stream, allowing you to accumulate them
    /// together. It's essentially like <c>Array.prototype.reduce</c>. The returned
    /// stream is a MemoryStream, which means it is already <c>remember()</c>'d.
    ///
    /// The output stream starts by emitting the <c>seed</c> which you give as argument.
    /// Then, when an event happens on the input stream, it is combined with that
    /// seed value through the <c>accumulate</c> function, and the output value is
    /// emitted on the output stream. <c>fold</c> remembers that output value as <c>acc</c>
    /// ("accumulator"), and then when a new input event <c>t</c> happens, <c>acc</c> will be
    /// combined with that to produce the new <c>acc</c> and so forth.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// ------1-----1--2----1----1------
    ///   fold((acc, x) =&gt; acc + x, 3)
    /// 3-----4-----5--7----8----9------
    /// </code>
    /// </summary>
    /// <param name="accumulate">
    /// A function of type <c>(acc: R, t: T) =&gt; R</c> that
    /// takes the previous accumulated value <c>acc</c> and the incoming event from the
    /// input stream and produces the new accumulated value.
    /// </param>
    /// <param name="seed">The initial accumulated value, of type <c>R</c>.</param>
    /// <returns />
    abstract fold: accumulate: ('R -> 'T -> 'R) * seed: 'R -> MemoryStream<'R>

    /// <summary>
    /// Replaces an error with another stream.
    ///
    /// When (and if) an error happens on the input stream, instead of forwarding
    /// that error to the output stream, *replaceError* will call the <c>replace</c>
    /// function which returns the stream that the output stream will replicate.
    /// And, in case that new stream also emits an error, <c>replace</c> will be called
    /// again to get another stream to start replicating.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---2-----3--4-----X
    ///   replaceError( () =&gt; --10--| )
    /// --1---2-----3--4--------10--|
    /// </code>
    /// </summary>
    /// <param name="replace">
    /// A function of type <c>(err) =&gt; Stream</c> that takes
    /// the error that occurred on the input stream or on the previous replacement
    /// stream and returns a new stream. The output stream will behave like the
    /// stream that this function returns.
    /// </param>
    /// <returns />
    abstract replaceError: replace: (obj option -> Stream<'T>) -> Stream<'T>

    /// <summary>
    /// Flattens a "stream of streams", handling only one nested stream at a time
    /// (no concurrency).
    ///
    /// If the input stream is a stream that emits streams, then this operator will
    /// return an output stream which is a flat stream: emits regular events. The
    /// flattening happens without concurrency. It works like this: when the input
    /// stream emits a nested stream, *flatten* will start imitating that nested
    /// one. However, as soon as the next nested stream is emitted on the input
    /// stream, *flatten* will forget the previous nested one it was imitating, and
    /// will start imitating the new nested one.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --+--------+---------------
    ///   \        \
    ///    \       ----1----2---3--
    ///    --a--b----c----d--------
    ///           flatten
    /// -----a--b------1----2---3--
    /// </code>
    /// </summary>
    /// <returns />
    abstract flatten: this: Stream<U2<Stream<'R>, MemoryStream<'R>>> -> Stream<'R>

    /// <summary>
    /// Passes the input stream to a custom operator, to produce an output stream.
    ///
    /// *compose* is a handy way of using an existing function in a chained style.
    /// Instead of writing <c>outStream = f(inStream)</c> you can write
    /// <c>outStream = inStream.compose(f)</c>.
    /// </summary>
    /// <param name="operator">
    /// A function that takes a stream as input and
    /// returns a stream as well.
    /// </param>
    /// <returns />
    abstract compose: operator: (Stream<'T> -> 'U) -> 'U

    /// <summary>
    /// Returns an output stream that behaves like the input stream, but also
    /// remembers the most recent event that happens on the input stream, so that a
    /// newly added listener will immediately receive that memorised event.
    /// </summary>
    /// <returns />
    abstract remember: unit -> MemoryStream<'T>

    abstract debug: unit -> Stream<'T>
    abstract debug: labelOrSpy: string -> Stream<'T>
    abstract debug: labelOrSpy: ('T -> obj option) -> Stream<'T>

    /// <summary>
    /// *imitate* changes this current Stream to emit the same events that the
    /// <c>other</c> given Stream does. This method returns nothing.
    ///
    /// This method exists to allow one thing: **circular dependency of streams**.
    /// For instance, let's imagine that for some reason you need to create a
    /// circular dependency where stream <c>first$</c> depends on stream <c>second$</c>
    /// which in turn depends on <c>first$</c>:
    ///
    /// &lt;!-- skip-example --&gt;
    /// <code lang="js">
    /// import delay from 'xstream/extra/delay'
    ///
    /// var first$ = second$.map(x =&gt; x * 10).take(3);
    /// var second$ = first$.map(x =&gt; x + 1).startWith(1).compose(delay(100));
    /// </code>
    ///
    /// However, that is invalid JavaScript, because <c>second$</c> is undefined
    /// on the first line. This is how *imitate* can help solve it:
    ///
    /// <code lang="js">
    /// import delay from 'xstream/extra/delay'
    ///
    /// var secondProxy$ = xs.create();
    /// var first$ = secondProxy$.map(x =&gt; x * 10).take(3);
    /// var second$ = first$.map(x =&gt; x + 1).startWith(1).compose(delay(100));
    /// secondProxy$.imitate(second$);
    /// </code>
    ///
    /// We create <c>secondProxy$</c> before the others, so it can be used in the
    /// declaration of <c>first$</c>. Then, after both <c>first$</c> and <c>second$</c> are
    /// defined, we hook <c>secondProxy$</c> with <c>second$</c> with <c>imitate()</c> to tell
    /// that they are "the same". <c>imitate</c> will not trigger the start of any
    /// stream, it just binds <c>secondProxy$</c> and <c>second$</c> together.
    ///
    /// The following is an example where <c>imitate()</c> is important in Cycle.js
    /// applications. A parent component contains some child components. A child
    /// has an action stream which is given to the parent to define its state:
    ///
    /// &lt;!-- skip-example --&gt;
    /// <code lang="js">
    /// const childActionProxy$ = xs.create();
    /// const parent = Parent({...sources, childAction$: childActionProxy$});
    /// const childAction$ = parent.state$.map(s =&gt; s.child.action$).flatten();
    /// childActionProxy$.imitate(childAction$);
    /// </code>
    ///
    /// Note, though, that **<c>imitate()</c> does not support MemoryStreams**. If we
    /// would attempt to imitate a MemoryStream in a circular dependency, we would
    /// either get a race condition (where the symptom would be "nothing happens")
    /// or an infinite cyclic emission of values. It's useful to think about
    /// MemoryStreams as cells in a spreadsheet. It doesn't make any sense to
    /// define a spreadsheet cell <c>A1</c> with a formula that depends on <c>B1</c> and
    /// cell <c>B1</c> defined with a formula that depends on <c>A1</c>.
    ///
    /// If you find yourself wanting to use <c>imitate()</c> with a
    /// MemoryStream, you should rework your code around <c>imitate()</c> to use a
    /// Stream instead. Look for the stream in the circular dependency that
    /// represents an event stream, and that would be a candidate for creating a
    /// proxy Stream which then imitates the target Stream.
    /// </summary>
    /// <param name="target">
    /// The other stream to imitate on the current one. Must
    /// not be a MemoryStream.
    /// </param>
    abstract imitate: target: Stream<'T> -> unit

    /// <summary>
    /// Forces the Stream to emit the given value to its listeners.
    ///
    /// As the name indicates, if you use this, you are most likely doing something
    /// The Wrong Way. Please try to understand the reactive way before using this
    /// method. Use it only when you know what you are doing.
    /// </summary>
    /// <param name="value">
    /// The "next" value you want to broadcast to all listeners of
    /// this Stream.
    /// </param>
    abstract shamefullySendNext: value: 'T -> unit

    /// <summary>
    /// Forces the Stream to emit the given error to its listeners.
    ///
    /// As the name indicates, if you use this, you are most likely doing something
    /// The Wrong Way. Please try to understand the reactive way before using this
    /// method. Use it only when you know what you are doing.
    /// </summary>
    /// <param name="error">
    /// The error you want to broadcast to all the listeners of
    /// this Stream.
    /// </param>
    abstract shamefullySendError: error: obj option -> unit

    /// Forces the Stream to emit the "completed" event to its listeners.
    ///
    /// As the name indicates, if you use this, you are most likely doing something
    /// The Wrong Way. Please try to understand the reactive way before using this
    /// method. Use it only when you know what you are doing.
    abstract shamefullySendComplete: unit -> unit

    /// <summary>
    /// Adds a "debug" listener to the stream. There can only be one debug
    /// listener, that's why this is 'setDebugListener'. To remove the debug
    /// listener, just call setDebugListener(null).
    ///
    /// A debug listener is like any other listener. The only difference is that a
    /// debug listener is "stealthy": its presence/absence does not trigger the
    /// start/stop of the stream (or the producer inside the stream). This is
    /// useful so you can inspect what is going on without changing the behavior
    /// of the program. If you have an idle stream and you add a normal listener to
    /// it, the stream will start executing. But if you set a debug listener on an
    /// idle stream, it won't start executing (not until the first normal listener
    /// is added).
    ///
    /// As the name indicates, we don't recommend using this method to build app
    /// logic. In fact, in most cases the debug operator works just fine. Only use
    /// this one if you know what you're doing.
    /// </summary>
    /// <param name="listener" />
    abstract setDebugListener: listener: obj option -> unit

[<AllowNullLiteral>]
type StreamStatic =
    [<EmitConstructor>]
    abstract Create: ?producer: InternalProducer<'T> -> Stream<'T>

    /// <summary>Creates a new Stream given a Producer.</summary>
    /// <param name="producer">
    /// An optional Producer that dictates how to
    /// start, generate events, and stop the Stream.
    /// </param>
    /// <returns />
    abstract create: ?producer: Producer<'T> -> Stream<'T>

    /// <summary>Creates a new MemoryStream given a Producer.</summary>
    /// <param name="producer">
    /// An optional Producer that dictates how to
    /// start, generate events, and stop the Stream.
    /// </param>
    /// <returns />
    abstract createWithMemory: ?producer: Producer<'T> -> MemoryStream<'T>

    /// <summary>
    /// Creates a Stream that does nothing when started. It never emits any event.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    ///          never
    /// -----------------------
    /// </code>
    /// </summary>
    /// <returns />
    abstract never: unit -> Stream<'T>

    /// <summary>
    /// Creates a Stream that immediately emits the "complete" notification when
    /// started, and that's it.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// empty
    /// -|
    /// </code>
    /// </summary>
    /// <returns />
    abstract empty: unit -> Stream<'T>

    /// <summary>
    /// Creates a Stream that immediately emits an "error" notification with the
    /// value you passed as the <c>error</c> argument when the stream starts, and that's
    /// it.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// throw(X)
    /// -X
    /// </code>
    /// </summary>
    /// <param name="error">The error event to emit on the created stream.</param>
    /// <returns />
    abstract throw: error: obj option -> Stream<obj option>

    /// <summary>Creates a stream from an Array, Promise, or an Observable.</summary>
    /// <param name="input">The input to make a stream from.</param>
    /// <returns />
    abstract from: input: U4<PromiseLike<'T>, Stream<'T>, Array<'T>, Observable<'T>> -> Stream<'T>

    /// <summary>
    /// Creates a Stream that immediately emits the arguments that you give to
    /// *of*, then completes.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// of(1,2,3)
    /// 123|
    /// </code>
    /// </summary>
    /// <param name="a">The first value you want to emit as an event on the stream.</param>
    /// <param name="b">
    /// The second value you want to emit as an event on the stream. One
    /// or more of these values may be given as arguments.
    /// </param>
    /// <returns />
    abstract ``of``: [<ParamArray>] items: Array<'T> -> Stream<'T>

    /// <summary>
    /// Converts an array to a stream. The returned stream will emit synchronously
    /// all the items in the array, and then complete.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// fromArray([1,2,3])
    /// 123|
    /// </code>
    /// </summary>
    /// <param name="array">The array to be converted as a stream.</param>
    /// <returns />
    abstract fromArray: array: Array<'T> -> Stream<'T>

    /// <summary>
    /// Converts a promise to a stream. The returned stream will emit the resolved
    /// value of the promise, and then complete. However, if the promise is
    /// rejected, the stream will emit the corresponding error.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// fromPromise( ----42 )
    /// -----------------42|
    /// </code>
    /// </summary>
    /// <param name="promise">The promise to be converted as a stream.</param>
    /// <returns />
    abstract fromPromise: promise: PromiseLike<'T> -> Stream<'T>

    /// <summary>Converts an Observable into a Stream.</summary>
    /// <param name="observable">The observable to be converted as a stream.</param>
    /// <returns />
    abstract fromObservable: obs: {| subscribe: obj option |} -> Stream<'T>

    /// <summary>
    /// Creates a stream that periodically emits incremental numbers, every
    /// <c>period</c> milliseconds.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    ///     periodic(1000)
    /// ---0---1---2---3---4---...
    /// </code>
    /// </summary>
    /// <param name="period">
    /// The interval in milliseconds to use as a rate of
    /// emission.
    /// </param>
    /// <returns />
    abstract periodic: period: float -> Stream<float>

    /// <summary>
    /// Blends multiple streams together, emitting events from all of them
    /// concurrently.
    ///
    /// *merge* takes multiple streams as arguments, and creates a stream that
    /// behaves like each of the argument streams, in parallel.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1----2-----3--------4---
    /// ----a-----b----c---d------
    ///            merge
    /// --1-a--2--b--3-c---d--4---
    /// </code>
    /// </summary>
    /// <param name="stream1">A stream to merge together with other streams.</param>
    /// <param name="stream2">
    /// A stream to merge together with other streams. Two
    /// or more streams may be given as arguments.
    /// </param>
    /// <returns />
    abstract merge: MergeSignature with get, set

    /// <summary>
    /// Combines multiple input streams together to return a stream whose events
    /// are arrays that collect the latest events from each input stream.
    ///
    /// *combine* internally remembers the most recent event from each of the input
    /// streams. When any of the input streams emits an event, that event together
    /// with all the other saved events are combined into an array. That array will
    /// be emitted on the output stream. It's essentially a way of joining together
    /// the events from multiple streams.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1----2-----3--------4---
    /// ----a-----b-----c--d------
    ///          combine
    /// ----1a-2a-2b-3b-3c-3d-4d--
    /// </code>
    /// </summary>
    /// <param name="stream1">A stream to combine together with other streams.</param>
    /// <param name="stream2">
    /// A stream to combine together with other streams.
    /// Multiple streams, not just two, may be given as arguments.
    /// </param>
    /// <returns />
    abstract combine: CombineSignature with get, set

[<AllowNullLiteral>]
type MemoryStream<'T> =
    inherit Stream<'T>
    abstract _n: x: 'T -> unit
    abstract _add: il: InternalListener<'T> -> unit
    abstract _stopNow: unit -> unit
    abstract _x: unit -> unit

    /// <summary>
    /// Transforms each event from the input Stream through a <c>project</c> function,
    /// to get a Stream that emits those transformed events.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---3--5-----7------
    ///    map(i =&gt; i * 10)
    /// --10--30-50----70-----
    /// </code>
    /// </summary>
    abstract map: project: ('T -> 'U) -> MemoryStream<'U>

    /// <summary>
    /// It's like <c>map</c>, but transforms each input event to always the same
    /// constant value on the output Stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---3--5-----7-----
    ///       mapTo(10)
    /// --10--10-10----10----
    /// </code>
    /// </summary>
    abstract mapTo: projectedValue: 'U -> MemoryStream<'U>

    /// <summary>
    /// Lets the first <c>amount</c> many events from the input stream pass to the
    /// output stream, then makes the output stream complete.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --a---b--c----d---e--
    ///    take(3)
    /// --a---b--c|
    /// </code>
    /// </summary>
    abstract take: amount: float -> MemoryStream<'T>

    /// <summary>
    /// Uses another stream to determine when to complete the current stream.
    ///
    /// When the given <c>other</c> stream emits an event or completes, the output
    /// stream will complete. Before that happens, the output stream will behaves
    /// like the input stream.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// ---1---2-----3--4----5----6---
    ///   endWhen( --------a--b--| )
    /// ---1---2-----3--4--|
    /// </code>
    /// </summary>
    abstract endWhen: other: Stream<obj option> -> MemoryStream<'T>

    /// <summary>
    /// Replaces an error with another stream.
    ///
    /// When (and if) an error happens on the input stream, instead of forwarding
    /// that error to the output stream, *replaceError* will call the <c>replace</c>
    /// function which returns the stream that the output stream will replicate.
    /// And, in case that new stream also emits an error, <c>replace</c> will be called
    /// again to get another stream to start replicating.
    ///
    /// Marble diagram:
    ///
    /// <code lang="text">
    /// --1---2-----3--4-----X
    ///   replaceError( () =&gt; --10--| )
    /// --1---2-----3--4--------10--|
    /// </code>
    /// </summary>
    abstract replaceError: replace: (obj option -> Stream<'T>) -> MemoryStream<'T>

    /// Returns an output stream that behaves like the input stream, but also
    /// remembers the most recent event that happens on the input stream, so that a
    /// newly added listener will immediately receive that memorised event.
    abstract remember: unit -> MemoryStream<'T>

    abstract debug: unit -> MemoryStream<'T>
    abstract debug: labelOrSpy: string -> MemoryStream<'T>
    abstract debug: labelOrSpy: ('T -> obj option) -> MemoryStream<'T>

[<AllowNullLiteral>]
type MemoryStreamStatic =
    [<EmitConstructor>]
    abstract Create: producer: InternalProducer<'T> -> MemoryStream<'T>

type xs<'T> = Stream<'T>

[<AllowNullLiteral>]
type NO =
    interface
    end
