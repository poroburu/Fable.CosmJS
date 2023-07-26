// ts2fable 0.9.0
module rec  Fable.CosmJS._types.long.Long

open System
open Fable.Core
open Fable.Core.JS

let [<Import("Long","module")>] Long: Long.LongConstructor = jsNative

type Long =
    Long.Long

module Long =

    type [<AllowNullLiteral>] IExports =
        abstract LongConstructor: LongConstructorStatic

    type [<AllowNullLiteral>] LongConstructor =
        abstract prototype: Long with get, set
        /// Maximum unsigned value.
        abstract MAX_UNSIGNED_VALUE: Long with get, set
        /// Maximum signed value.
        abstract MAX_VALUE: Long with get, set
        /// Minimum signed value.
        abstract MIN_VALUE: Long with get, set
        /// Signed negative one.
        abstract NEG_ONE: Long with get, set
        /// Signed one.
        abstract ONE: Long with get, set
        /// Unsigned one.
        abstract UONE: Long with get, set
        /// Unsigned zero.
        abstract UZERO: Long with get, set
        /// Signed zero
        abstract ZERO: Long with get, set
        /// Returns a Long representing the 64 bit integer that comes by concatenating the given low and high bits. Each is assumed to use 32 bits.
        abstract fromBits: lowBits: float * highBits: float * ?unsigned: bool -> Long
        /// Returns a Long representing the given 32 bit integer value.
        abstract fromInt: value: float * ?unsigned: bool -> Long
        /// Returns a Long representing the given value, provided that it is a finite number. Otherwise, zero is returned.
        abstract fromNumber: value: float * ?unsigned: bool -> Long
        /// Returns a Long representation of the given string, written using the specified radix.
        abstract fromString: str: string * ?unsigned: U2<bool, float> * ?radix: float -> Long
        /// Creates a Long from its byte representation.
        abstract fromBytes: bytes: ResizeArray<float> * ?unsigned: bool * ?le: bool -> Long
        /// Creates a Long from its little endian byte representation.
        abstract fromBytesLE: bytes: ResizeArray<float> * ?unsigned: bool -> Long
        /// Creates a Long from its little endian byte representation.
        abstract fromBytesBE: bytes: ResizeArray<float> * ?unsigned: bool -> Long
        /// Tests if the specified object is a Long.
        abstract isLong: obj: obj option -> bool
        /// Converts the specified value to a Long.
        abstract fromValue: ``val``: U4<Long, float, string, {| low: float; high: float; unsigned: bool |}> * ?unsigned: bool -> Long

    type [<AllowNullLiteral>] LongConstructorStatic =
        /// Constructs a 64 bit two's-complement integer, given its low and high 32 bit values as signed integers. See the from* functions below for more convenient ways of constructing Longs.
        [<EmitConstructor>] abstract Create: low: float * ?high: float * ?unsigned: bool -> LongConstructor

    type [<AllowNullLiteral>] Long =
        /// The high 32 bits as a signed value.
        abstract high: float with get, set
        /// The low 32 bits as a signed value.
        abstract low: float with get, set
        /// Whether unsigned or not.
        abstract unsigned: bool with get, set
        /// Returns the sum of this and the specified Long.
        abstract add: addend: U3<float, Long, string> -> Long
        /// Returns the bitwise AND of this Long and the specified.
        abstract ``and``: other: U3<Long, float, string> -> Long
        /// Compares this Long's value with the specified's.
        abstract compare: other: U3<Long, float, string> -> float
        /// Compares this Long's value with the specified's.
        abstract comp: other: U3<Long, float, string> -> float
        /// Returns this Long divided by the specified.
        abstract divide: divisor: U3<Long, float, string> -> Long
        /// Returns this Long divided by the specified.
        abstract div: divisor: U3<Long, float, string> -> Long
        /// Tests if this Long's value equals the specified's.
        abstract equals: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value equals the specified's.
        abstract eq: other: U3<Long, float, string> -> bool
        /// Gets the high 32 bits as a signed integer.
        abstract getHighBits: unit -> float
        /// Gets the high 32 bits as an unsigned integer.
        abstract getHighBitsUnsigned: unit -> float
        /// Gets the low 32 bits as a signed integer.
        abstract getLowBits: unit -> float
        /// Gets the low 32 bits as an unsigned integer.
        abstract getLowBitsUnsigned: unit -> float
        /// Gets the number of bits needed to represent the absolute value of this Long.
        abstract getNumBitsAbs: unit -> float
        /// Tests if this Long's value is greater than the specified's.
        abstract greaterThan: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is greater than the specified's.
        abstract gt: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is greater than or equal the specified's.
        abstract greaterThanOrEqual: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is greater than or equal the specified's.
        abstract gte: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is even.
        abstract isEven: unit -> bool
        /// Tests if this Long's value is negative.
        abstract isNegative: unit -> bool
        /// Tests if this Long's value is odd.
        abstract isOdd: unit -> bool
        /// Tests if this Long's value is positive.
        abstract isPositive: unit -> bool
        /// Tests if this Long's value equals zero.
        abstract isZero: unit -> bool
        /// Tests if this Long's value is less than the specified's.
        abstract lessThan: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is less than the specified's.
        abstract lt: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is less than or equal the specified's.
        abstract lessThanOrEqual: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value is less than or equal the specified's.
        abstract lte: other: U3<Long, float, string> -> bool
        /// Returns this Long modulo the specified.
        abstract modulo: other: U3<Long, float, string> -> Long
        /// Returns this Long modulo the specified.
        abstract ``mod``: other: U3<Long, float, string> -> Long
        /// Returns the product of this and the specified Long.
        abstract multiply: multiplier: U3<Long, float, string> -> Long
        /// Returns the product of this and the specified Long.
        abstract mul: multiplier: U3<Long, float, string> -> Long
        /// Negates this Long's value.
        abstract negate: unit -> Long
        /// Negates this Long's value.
        abstract neg: unit -> Long
        /// Returns the bitwise NOT of this Long.
        abstract not: unit -> Long
        /// Tests if this Long's value differs from the specified's.
        abstract notEquals: other: U3<Long, float, string> -> bool
        /// Tests if this Long's value differs from the specified's.
        abstract neq: other: U3<Long, float, string> -> bool
        /// Returns the bitwise OR of this Long and the specified.
        abstract ``or``: other: U3<Long, float, string> -> Long
        /// Returns this Long with bits shifted to the left by the given amount.
        abstract shiftLeft: numBits: U2<float, Long> -> Long
        /// Returns this Long with bits shifted to the left by the given amount.
        abstract shl: numBits: U2<float, Long> -> Long
        /// Returns this Long with bits arithmetically shifted to the right by the given amount.
        abstract shiftRight: numBits: U2<float, Long> -> Long
        /// Returns this Long with bits arithmetically shifted to the right by the given amount.
        abstract shr: numBits: U2<float, Long> -> Long
        /// Returns this Long with bits logically shifted to the right by the given amount.
        abstract shiftRightUnsigned: numBits: U2<float, Long> -> Long
        /// Returns this Long with bits logically shifted to the right by the given amount.
        abstract shru: numBits: U2<float, Long> -> Long
        /// Returns the difference of this and the specified Long.
        abstract subtract: subtrahend: U3<float, Long, string> -> Long
        /// Returns the difference of this and the specified Long.
        abstract sub: subtrahend: U3<float, Long, string> -> Long
        /// Converts the Long to a 32 bit integer, assuming it is a 32 bit integer.
        abstract toInt: unit -> float
        /// Converts the Long to a the nearest floating-point representation of this value (double, 53 bit mantissa).
        abstract toNumber: unit -> float
        /// Converts this Long to its byte representation.
        abstract toBytes: ?le: bool -> ResizeArray<float>
        /// Converts this Long to its little endian byte representation.
        abstract toBytesLE: unit -> ResizeArray<float>
        /// Converts this Long to its big endian byte representation.
        abstract toBytesBE: unit -> ResizeArray<float>
        /// Converts this Long to signed.
        abstract toSigned: unit -> Long
        /// Converts the Long to a string written in the specified radix.
        abstract toString: ?radix: float -> string
        /// Converts this Long to unsigned.
        abstract toUnsigned: unit -> Long
        /// Returns the bitwise XOR of this Long and the given one.
        abstract xor: other: U3<Long, float, string> -> Long