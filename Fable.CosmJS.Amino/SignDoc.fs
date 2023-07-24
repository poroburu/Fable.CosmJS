// ts2fable 0.9.0
module rec Fable.CosmJS.Amino.SignDoc

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

type Coin = Fable.CosmJS.Amino.Coins.Coin

type [<AllowNullLiteral>] IExports =
    /// Returns a JSON string with objects sorted by key
    abstract sortedJsonStringify: obj: obj option -> string
    abstract makeSignDoc: msgs: ResizeArray<AminoMsg> * fee: StdFee * chainId: string * memo: string option * accountNumber: U2<float, string> * sequence: U2<float, string> -> StdSignDoc
    /// <summary>
    /// Takes a valid JSON document and performs the following escapings in string values:
    /// 
    /// <c>&amp;</c> -&gt; <c>\u0026</c>
    /// <c>&lt;</c> -&gt; <c>\u003c</c>
    /// <c>&gt;</c> -&gt; <c>\u003e</c>
    /// 
    /// Since those characters do not occur in other places of the JSON document, only
    /// string values are affected.
    /// 
    /// If the input is invalid JSON, the behaviour is undefined.
    /// </summary>
    abstract escapeCharacters: input: string -> string
    abstract serializeSignDoc: signDoc: StdSignDoc -> Uint8Array

type [<AllowNullLiteral>] AminoMsg =
    abstract ``type``: string
    abstract value: obj option

type [<AllowNullLiteral>] StdFee =
    abstract amount: ResizeArray<Coin>
    abstract gas: string
    /// The granter address that is used for paying with feegrants
    abstract granter: string option
    /// The fee payer address. The payer must have signed the transaction.
    abstract payer: string option

/// <summary>The document to be signed</summary>
/// <seealso href="https://docs.cosmos.network/master/modules/auth/03_types.html#stdsigndoc" />
type [<AllowNullLiteral>] StdSignDoc =
    abstract chain_id: string
    abstract account_number: string
    abstract sequence: string
    abstract fee: StdFee
    abstract msgs: ResizeArray<AminoMsg>
    abstract memo: string