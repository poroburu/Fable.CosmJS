// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.bip39

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type ArrayLike<'T> = System.Collections.Generic.IList<'T>


[<AllowNullLiteral>]
type IExports =
    abstract toRealUint8Array: data: ArrayLike<float> -> Uint8Array
    abstract entropyToMnemonic: entropy: Uint8Array -> string
    abstract mnemonicToEntropy: mnemonic: string -> Uint8Array
    abstract EnglishMnemonic: EnglishMnemonicStatic
    abstract Bip39: Bip39Static

[<AllowNullLiteral>]
type EnglishMnemonic =
    abstract toString: unit -> string

[<AllowNullLiteral>]
type EnglishMnemonicStatic =
    abstract wordlist: ResizeArray<string>

    [<EmitConstructor>]
    abstract Create: mnemonic: string -> EnglishMnemonic

[<AllowNullLiteral>]
type Bip39 =
    interface
    end

[<AllowNullLiteral>]
type Bip39Static =
    [<EmitConstructor>]
    abstract Create: unit -> Bip39

    /// <summary>
    /// Encodes raw entropy of length 16, 20, 24, 28 or 32 bytes as an English mnemonic between 12 and 24 words.
    ///
    /// | Entropy            | Words |
    /// |--------------------|-------|
    /// | 128 bit (16 bytes) |    12 |
    /// | 160 bit (20 bytes) |    15 |
    /// | 192 bit (24 bytes) |    18 |
    /// | 224 bit (28 bytes) |    21 |
    /// | 256 bit (32 bytes) |    24 |
    /// </summary>
    /// <seealso href="https://github.com/bitcoin/bips/blob/master/bip-0039.mediawiki#generating-the-mnemonic" />
    /// <param name="entropy">The entropy to be encoded. This must be cryptographically secure.</param>
    abstract encode: entropy: Uint8Array -> EnglishMnemonic

    abstract decode: mnemonic: EnglishMnemonic -> Uint8Array
    abstract mnemonicToSeed: mnemonic: EnglishMnemonic * ?password: string -> Promise<Uint8Array>
