// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.pbkdf2

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// Returns the Node.js crypto module when available and <c>undefined</c>
    /// otherwise.
    /// 
    /// Detects an unimplemented fallback module from Webpack 5 and returns
    /// <c>undefined</c> in that case.
    /// </summary>
    abstract getNodeCrypto: unit -> Promise<obj option option>
    abstract getSubtle: unit -> Promise<obj option option>
    abstract pbkdf2Sha512Subtle: subtle: obj option * secret: Uint8Array * salt: Uint8Array * iterations: float * keylen: float -> Promise<Uint8Array>
    /// <summary>
    /// Implements pbkdf2-sha512 using the Node.js crypro module (<c>import "crypto"</c>).
    /// This does not use subtle from <see href="https://developer.mozilla.org/en-US/docs/Web/API/Crypto">Crypto</see>.
    /// </summary>
    abstract pbkdf2Sha512NodeCrypto: nodeCrypto: obj option * secret: Uint8Array * salt: Uint8Array * iterations: float * keylen: float -> Promise<Uint8Array>
    abstract pbkdf2Sha512Noble: secret: Uint8Array * salt: Uint8Array * iterations: float * keylen: float -> Promise<Uint8Array>
    /// A pbkdf2 implementation for BIP39. This is not exported at package level and thus a private API.
    abstract pbkdf2Sha512: secret: Uint8Array * salt: Uint8Array * iterations: float * keylen: float -> Promise<Uint8Array>