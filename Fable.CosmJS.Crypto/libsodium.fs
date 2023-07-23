// ts2fable 0.9.0
module rec Fable.CosmJS.Crypto.libsodium

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

/// <summary>Nonce length in bytes for all flavours of XChaCha20.</summary>
/// <seealso href="https://libsodium.gitbook.io/doc/advanced/stream_ciphers/xchacha20#notes" />
[<Import("xchacha20NonceLength", "module")>]
let xchacha20NonceLength: obj = jsNative

[<AllowNullLiteral>]
type IExports =
    abstract isArgon2idOptions: thing: obj -> bool
    abstract Argon2id: Argon2idStatic
    abstract Ed25519Keypair: Ed25519KeypairStatic
    abstract Ed25519: Ed25519Static
    abstract Xchacha20poly1305Ietf: Xchacha20poly1305IetfStatic

[<AllowNullLiteral>]
type Argon2idOptions =
    /// Output length in bytes
    abstract outputLength: float

    /// <summary>An integer between 1 and 4294967295 representing the computational difficulty.</summary>
    /// <seealso href="https://libsodium.gitbook.io/doc/password_hashing/default_phf#key-derivation" />
    abstract opsLimit: float

    /// <summary>
    /// Memory limit measured in KiB (like argon2 command line tool)
    ///
    /// Note: only approximately 16 MiB of memory are available using the non-sumo version of libsodium.js
    /// </summary>
    /// <seealso href="https://libsodium.gitbook.io/doc/password_hashing/default_phf#key-derivation" />
    abstract memLimitKib: float

[<AllowNullLiteral>]
type Argon2id =
    interface
    end

[<AllowNullLiteral>]
type Argon2idStatic =
    [<EmitConstructor>]
    abstract Create: unit -> Argon2id

    abstract execute: password: string * salt: Uint8Array * options: Argon2idOptions -> Promise<Uint8Array>

[<AllowNullLiteral>]
type Ed25519Keypair =
    abstract privkey: Uint8Array
    abstract pubkey: Uint8Array
    abstract toLibsodiumPrivkey: unit -> Uint8Array

[<AllowNullLiteral>]
type Ed25519KeypairStatic =
    abstract fromLibsodiumPrivkey: libsodiumPrivkey: Uint8Array -> Ed25519Keypair

    [<EmitConstructor>]
    abstract Create: privkey: Uint8Array * pubkey: Uint8Array -> Ed25519Keypair

[<AllowNullLiteral>]
type Ed25519 =
    interface
    end

[<AllowNullLiteral>]
type Ed25519Static =
    [<EmitConstructor>]
    abstract Create: unit -> Ed25519

    /// <summary>
    /// Generates a keypair deterministically from a given 32 bytes seed.
    ///
    /// This seed equals the Ed25519 private key.
    /// For implementation details see crypto_sign_seed_keypair in
    /// <see href="https://download.libsodium.org/doc/public-key_cryptography/public-key_signatures.html" />
    /// and diagram on <see href="https://blog.mozilla.org/warner/2011/11/29/ed25519-keys/" />
    /// </summary>
    abstract makeKeypair: seed: Uint8Array -> Promise<Ed25519Keypair>

    abstract createSignature: message: Uint8Array * keyPair: Ed25519Keypair -> Promise<Uint8Array>
    abstract verifySignature: signature: Uint8Array * message: Uint8Array * pubkey: Uint8Array -> Promise<bool>

[<AllowNullLiteral>]
type Xchacha20poly1305Ietf =
    interface
    end

[<AllowNullLiteral>]
type Xchacha20poly1305IetfStatic =
    [<EmitConstructor>]
    abstract Create: unit -> Xchacha20poly1305Ietf

    abstract encrypt: message: Uint8Array * key: Uint8Array * nonce: Uint8Array -> Promise<Uint8Array>
    abstract decrypt: ciphertext: Uint8Array * key: Uint8Array * nonce: Uint8Array -> Promise<Uint8Array>
