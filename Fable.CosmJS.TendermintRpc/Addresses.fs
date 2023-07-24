// ts2fable 0.9.0
module rec Fable.CosmJS.TendermintRpc.Addresses

open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] IExports =
    abstract rawEd25519PubkeyToRawAddress: pubkeyData: Uint8Array -> Uint8Array
    abstract rawSecp256k1PubkeyToRawAddress: pubkeyData: Uint8Array -> Uint8Array
    /// Returns Tendermint address as bytes.
    /// 
    /// This is for addresses that are derived by the Tendermint keypair (typically Ed25519).
    /// Sometimes those addresses are bech32-encoded and contain the term "cons" in the presix
    /// ("cosmosvalcons1...").
    /// 
    /// For secp256k1 this assumes we already have a compressed pubkey, which is the default in Cosmos.
    abstract pubkeyToRawAddress: ``type``: IExportsPubkeyToRawAddress * data: Uint8Array -> Uint8Array
    /// Returns Tendermint address in uppercase hex format.
    /// 
    /// This is for addresses that are derived by the Tendermint keypair (typically Ed25519).
    /// Sometimes those addresses are bech32-encoded and contain the term "cons" in the presix
    /// ("cosmosvalcons1...").
    /// 
    /// For secp256k1 this assumes we already have a compressed pubkey, which is the default in Cosmos.
    abstract pubkeyToAddress: ``type``: IExportsPubkeyToRawAddress * data: Uint8Array -> string

type [<StringEnum>] [<RequireQualifiedAccess>] IExportsPubkeyToRawAddress =
    | Ed25519
    | Secp256k1