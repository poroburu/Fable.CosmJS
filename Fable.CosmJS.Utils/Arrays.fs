// ts2fable 0.9.0
module rec Fable.CosmJS.Utils.Arrays

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type ArrayLike<'T> = System.Collections.Generic.IList<'T>


[<AllowNullLiteral>]
type IExports =
    /// <summary>
    /// Compares the content of two arrays-like objects for equality.
    ///
    /// Equality is defined as having equal length and element values, where element equality means <c>===</c> returning <c>true</c>.
    ///
    /// This allows you to compare the content of a Buffer, Uint8Array or number[], ignoring the specific type.
    /// As a consequence, this returns different results than Jasmine's <c>toEqual</c>, which ensures elements have the same type.
    /// </summary>
    abstract arrayContentEquals: a: ArrayLike<'T> * b: ArrayLike<'T> -> bool

    /// <summary>
    /// Checks if <c>a</c> starts with the contents of <c>b</c>.
    ///
    /// This requires equality of the element values, where element equality means <c>===</c> returning <c>true</c>.
    ///
    /// This allows you to compare the content of a Buffer, Uint8Array or number[], ignoring the specific type.
    /// As a consequence, this returns different results than Jasmine's <c>toEqual</c>, which ensures elements have the same type.
    /// </summary>
    abstract arrayContentStartsWith: a: ArrayLike<'T> * b: ArrayLike<'T> -> bool
