// ts2fable 0.9.0
module rec Fable.CosmJS.ProtoSigning.Wallet

open System
open Fable.Core
open Fable.Core.JS

type Record<'K, 'V> = Fable.CosmJS.Record.Record<'K, 'V>

/// A fixed salt is chosen to archive a deterministic password to key derivation.
/// This reduces the scope of a potential rainbow attack to all CosmJS users.
/// Must be 16 bytes due to implementation limitations.
let [<Import("cosmjsSalt","module")>] cosmjsSalt: Uint8Array = jsNative
let [<Import("supportedAlgorithms","module")>] supportedAlgorithms: {| xchacha20poly1305Ietf: string |} = jsNative

type [<AllowNullLiteral>] IExports =
    abstract executeKdf: password: string * configuration: KdfConfiguration -> Promise<Uint8Array>
    abstract encrypt: plaintext: Uint8Array * encryptionKey: Uint8Array * config: EncryptionConfiguration -> Promise<Uint8Array>
    abstract decrypt: ciphertext: Uint8Array * encryptionKey: Uint8Array * config: EncryptionConfiguration -> Promise<Uint8Array>

type [<AllowNullLiteral>] KdfConfiguration =
    /// An algorithm identifier, such as "argon2id" or "scrypt".
    abstract algorithm: string
    /// A map of algorithm-specific parameters
    abstract ``params``: Record<string, obj>

/// Configuration how to encrypt data or how data was encrypted.
/// This is stored as part of the wallet serialization and must only contain JSON types.
type [<AllowNullLiteral>] EncryptionConfiguration =
    /// An algorithm identifier, such as "xchacha20poly1305-ietf".
    abstract algorithm: string
    /// A map of algorithm-specific parameters
    abstract ``params``: Record<string, obj> option