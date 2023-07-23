module rec Fable.CosmJS.Math.Decimal
// ts2fable 0.9.0

open System
open Fable.CosmJS.Math
open Fable.Core
open Fable.Core.JS

type Uint32 = Integers.Uint32
type Uint53 = Integers.Uint53
type Uint64 = Integers.Uint64

[<AllowNullLiteral>]
type IExports =
    abstract maxFractionalDigits: obj

    /// A type for arbitrary precision, non-negative decimals.
    ///
    /// Instances of this class are immutable.
    abstract Decimal: DecimalStatic

/// A type for arbitrary precision, non-negative decimals.
///
/// Instances of this class are immutable.
[<AllowNullLiteral>]
type Decimal =
    abstract atomics: string
    abstract fractionalDigits: float
    /// Returns the greatest decimal <= this which has no fractional part (rounding down)
    abstract floor: unit -> Decimal
    /// Returns the smallest decimal >= this which has no fractional part (rounding up)
    abstract ceil: unit -> Decimal
    abstract toString: unit -> string

    /// Returns an approximation as a float type. Only use this if no
    /// exact calculation is required.
    abstract toFloatApproximation: unit -> float

    /// a.plus(b) returns a+b.
    ///
    /// Both values need to have the same fractional digits.
    abstract plus: b: Decimal -> Decimal

    /// a.minus(b) returns a-b.
    ///
    /// Both values need to have the same fractional digits.
    /// The resulting difference needs to be non-negative.
    abstract minus: b: Decimal -> Decimal

    /// a.multiply(b) returns a*b.
    ///
    /// We only allow multiplication by unsigned integers to avoid rounding errors.
    abstract multiply: b: U3<Uint32, Uint53, Uint64> -> Decimal

    abstract equals: b: Decimal -> bool
    abstract isLessThan: b: Decimal -> bool
    abstract isLessThanOrEqual: b: Decimal -> bool
    abstract isGreaterThan: b: Decimal -> bool
    abstract isGreaterThanOrEqual: b: Decimal -> bool

/// A type for arbitrary precision, non-negative decimals.
///
/// Instances of this class are immutable.
[<AllowNullLiteral>]
type DecimalStatic =
    abstract fromUserInput: input: string * fractionalDigits: float -> Decimal
    abstract fromAtomics: atomics: string * fractionalDigits: float -> Decimal

    /// Creates a Decimal with value 0.0 and the given number of fractial digits.
    ///
    /// Fractional digits are not relevant for the value but needed to be able
    /// to perform arithmetic operations with other decimals.
    abstract zero: fractionalDigits: float -> Decimal

    /// Creates a Decimal with value 1.0 and the given number of fractial digits.
    ///
    /// Fractional digits are not relevant for the value but needed to be able
    /// to perform arithmetic operations with other decimals.
    abstract one: fractionalDigits: float -> Decimal

    abstract compare: a: Decimal * b: Decimal -> float
