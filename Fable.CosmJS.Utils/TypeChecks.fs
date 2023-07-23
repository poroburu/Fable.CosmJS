// ts2fable 0.9.0
module rec Fable.CosmJS.Utils.TypeChecks


#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


[<AllowNullLiteral>]
type IExports =
    abstract sleep: ms: float -> Promise<unit>

    /// <summary>
    /// Checks if data is a non-null object (i.e. matches the TypeScript object type).
    ///
    /// Note: this returns true for arrays, which are objects in JavaScript
    /// even though array and object are different types in JSON.
    /// </summary>
    /// <seealso href="https://www.typescriptlang.org/docs/handbook/basic-types.html#object" />
    abstract isNonNullObject: data: obj -> bool

    /// Checks if data is an Uint8Array. Note: Buffer is treated as not a Uint8Array
    abstract isUint8Array: data: obj -> bool

    /// <summary>
    /// Checks if input is not undefined in a TypeScript-friendly way.
    ///
    /// This is convenient to use in e.g. <c>Array.filter</c> as it will convert
    /// the type of a <c>Array&lt;Foo | undefined&gt;</c> to <c>Array&lt;Foo&gt;</c>.
    /// </summary>
    abstract isDefined: value: 'X option -> bool
