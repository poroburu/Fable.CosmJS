// ts2fable 0.9.0
module rec Fable.CosmJS.ProtoSigning.Pubkey

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Pubkey = Fable.CosmJS.Amino.Pubkeys.Pubkey
type SinglePubkey = Fable.CosmJS.Amino.Pubkeys.SinglePubkey
type Any = Fable.CosmJS.CosmJSTypes.Google.Protobuf.Any.Any

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// Takes a pubkey in the Amino JSON object style (type/value wrapper)
    /// and convertes it into a protobuf <c>Any</c>.
    /// 
    /// This is the reverse operation to <c>decodePubkey</c>.
    /// </summary>
    abstract encodePubkey: pubkey: Pubkey -> Any
    /// <summary>
    /// Decodes a single pubkey (i.e. not a multisig pubkey) from <c>Any</c> into
    /// <c>SinglePubkey</c>.
    /// 
    /// In most cases you probably want to use <c>decodePubkey</c>.
    /// </summary>
    abstract anyToSinglePubkey: pubkey: Any -> SinglePubkey
    /// <summary>
    /// Decodes a pubkey from a protobuf <c>Any</c> into <c>Pubkey</c>.
    /// This supports single pubkeys such as Cosmos ed25519 and secp256k1 keys
    /// as well as multisig threshold pubkeys.
    /// </summary>
    abstract decodePubkey: pubkey: Any -> Pubkey