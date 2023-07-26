// ts2fable 0.9.0
module rec Fable.CosmJS.CosmJSTypes.Google.Protobuf.Any


#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module _m0 = Fable.CosmJS.CosmJSTypes.Google.Protobuf.ProtobufRW

type Record<'K, 'V> = Fable.CosmJS.Record.Record<'K, 'V>

[<Erase>]
type KeyOf<'T> = Key of string

[<Import("protobufPackage", "module")>]
let protobufPackage: obj = jsNative

/// <summary>
/// <c>Any</c> contains an arbitrary serialized protocol buffer message along with a
/// URL that describes the type of the serialized message.
///
/// Protobuf library provides support to pack/unpack Any values in the form
/// of utility functions or additional generated methods of the Any type.
///
/// Example 1: Pack and unpack a message in C++.
///
///     Foo foo = ...;
///     Any any;
///     any.PackFrom(foo);
///     ...
///     if (any.UnpackTo(&amp;foo)) {
///       ...
///     }
///
/// Example 2: Pack and unpack a message in Java.
///
///     Foo foo = ...;
///     Any any = Any.pack(foo);
///     ...
///     if (any.is(Foo.class)) {
///       foo = any.unpack(Foo.class);
///     }
///
///  Example 3: Pack and unpack a message in Python.
///
///     foo = Foo(...)
///     any = Any()
///     any.Pack(foo)
///     ...
///     if any.Is(Foo.DESCRIPTOR):
///       any.Unpack(foo)
///       ...
///
///  Example 4: Pack and unpack a message in Go
///
///      foo := &amp;pb.Foo{...}
///      any, err := ptypes.MarshalAny(foo)
///      ...
///      foo := &amp;pb.Foo{}
///      if err := ptypes.UnmarshalAny(any, foo); err != nil {
///        ...
///      }
///
/// The pack methods provided by protobuf library will by default use
/// 'type.googleapis.com/full.type.name' as the type URL and the unpack
/// methods only use the fully qualified type name after the last '/'
/// in the type URL, for example "foo.bar.com/x/y.z" will yield type
/// name "y.z".
///
///
/// JSON
/// ====
/// The JSON representation of an <c>Any</c> value uses the regular
/// representation of the deserialized, embedded message, with an
/// additional field <c>@type</c> which contains the type URL. Example:
///
///     package google.profile;
///     message Person {
///       string first_name = 1;
///       string last_name = 2;
///     }
///
///     {
///       "@type": "type.googleapis.com/google.profile.Person",
///       "firstName": &lt;string&gt;,
///       "lastName": &lt;string&gt;
///     }
///
/// If the embedded message type is well-known and has a custom JSON
/// representation, that representation will be embedded adding a field
/// <c>value</c> which holds the custom JSON in addition to the <c>@type</c>
/// field. Example (for message [google.protobuf.Duration][]):
///
///     {
///       "@type": "type.googleapis.com/google.protobuf.Duration",
///       "value": "1.212s"
///     }
/// </summary>
[<Import("Any", "module")>]
let Any: Any<'I> = jsNative

/// <summary>
/// <c>Any</c> contains an arbitrary serialized protocol buffer message along with a
/// URL that describes the type of the serialized message.
///
/// Protobuf library provides support to pack/unpack Any values in the form
/// of utility functions or additional generated methods of the Any type.
///
/// Example 1: Pack and unpack a message in C++.
///
///     Foo foo = ...;
///     Any any;
///     any.PackFrom(foo);
///     ...
///     if (any.UnpackTo(&amp;foo)) {
///       ...
///     }
///
/// Example 2: Pack and unpack a message in Java.
///
///     Foo foo = ...;
///     Any any = Any.pack(foo);
///     ...
///     if (any.is(Foo.class)) {
///       foo = any.unpack(Foo.class);
///     }
///
///  Example 3: Pack and unpack a message in Python.
///
///     foo = Foo(...)
///     any = Any()
///     any.Pack(foo)
///     ...
///     if any.Is(Foo.DESCRIPTOR):
///       any.Unpack(foo)
///       ...
///
///  Example 4: Pack and unpack a message in Go
///
///      foo := &amp;pb.Foo{...}
///      any, err := ptypes.MarshalAny(foo)
///      ...
///      foo := &amp;pb.Foo{}
///      if err := ptypes.UnmarshalAny(any, foo); err != nil {
///        ...
///      }
///
/// The pack methods provided by protobuf library will by default use
/// 'type.googleapis.com/full.type.name' as the type URL and the unpack
/// methods only use the fully qualified type name after the last '/'
/// in the type URL, for example "foo.bar.com/x/y.z" will yield type
/// name "y.z".
///
///
/// JSON
/// ====
/// The JSON representation of an <c>Any</c> value uses the regular
/// representation of the deserialized, embedded message, with an
/// additional field <c>@type</c> which contains the type URL. Example:
///
///     package google.profile;
///     message Person {
///       string first_name = 1;
///       string last_name = 2;
///     }
///
///     {
///       "@type": "type.googleapis.com/google.profile.Person",
///       "firstName": &lt;string&gt;,
///       "lastName": &lt;string&gt;
///     }
///
/// If the embedded message type is well-known and has a custom JSON
/// representation, that representation will be embedded adding a field
/// <c>value</c> which holds the custom JSON in addition to the <c>@type</c>
/// field. Example (for message [google.protobuf.Duration][]):
///
///     {
///       "@type": "type.googleapis.com/google.protobuf.Duration",
///       "value": "1.212s"
///     }
/// </summary>
[<AllowNullLiteral>]
type Any =
    /// <summary>
    /// A URL/resource name that uniquely identifies the type of the serialized
    /// protocol buffer message. This string must contain at least
    /// one "/" character. The last segment of the URL's path must represent
    /// the fully qualified name of the type (as in
    /// <c>path/google.protobuf.Duration</c>). The name should be in a canonical form
    /// (e.g., leading "." is not accepted).
    ///
    /// In practice, teams usually precompile into the binary all types that they
    /// expect it to use in the context of Any. However, for URLs which use the
    /// scheme <c>http</c>, <c>https</c>, or no scheme, one can optionally set up a type
    /// server that maps type URLs to message definitions as follows:
    ///
    /// * If no scheme is provided, <c>https</c> is assumed.
    /// * An HTTP GET on the URL must yield a [google.protobuf.Type][]
    ///   value in binary format, or produce an error.
    /// * Applications are allowed to cache lookup results based on the
    ///   URL, or have them precompiled into a binary to avoid any
    ///   lookup. Therefore, binary compatibility needs to be preserved
    ///   on changes to types. (Use versioned type names to manage
    ///   breaking changes.)
    ///
    /// Note: this functionality is not currently available in the official
    /// protobuf release, and it is not used for type URLs beginning with
    /// type.googleapis.com.
    ///
    /// Schemes other than <c>http</c>, <c>https</c> (or the empty scheme) might be
    /// used with implementation specific semantics.
    /// </summary>
    abstract typeUrl: string with get, set

    /// Must be a valid serialized protocol buffer of the above specified type.
    abstract value: Uint8Array with get, set

[<AllowNullLiteral>]
type Any<'I> =
    abstract encode: message: Any * ?writer: _m0.Writer -> _m0.Writer
    abstract decode: input: U2<_m0.Reader, Uint8Array> * ?length: float -> Any
    abstract fromJSON: object: obj option -> Any
    abstract toJSON: message: Any -> obj
    abstract fromPartial: object: 'I -> Any when 'I :> Record<Exclude<KeyOf<'I>, KeyOf<Any>>, obj>
