// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: v2ray.com/core/common/net/network.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace V2Ray.Core.Common.Net {

  /// <summary>Holder for reflection information generated from v2ray.com/core/common/net/network.proto</summary>
  public static partial class NetworkReflection {

    #region Descriptor
    /// <summary>File descriptor for v2ray.com/core/common/net/network.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NetworkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid2MnJheS5jb20vY29yZS9jb21tb24vbmV0L25ldHdvcmsucHJvdG8SFXYy",
            "cmF5LmNvcmUuY29tbW9uLm5ldCI+CgtOZXR3b3JrTGlzdBIvCgduZXR3b3Jr",
            "GAEgAygOMh4udjJyYXkuY29yZS5jb21tb24ubmV0Lk5ldHdvcmsqOAoHTmV0",
            "d29yaxILCgdVbmtub3duEAASDgoGUmF3VENQEAEaAggBEgcKA1RDUBACEgcK",
            "A1VEUBADQjoKGWNvbS52MnJheS5jb3JlLmNvbW1vbi5uZXRQAVoDbmV0qgIV",
            "VjJSYXkuQ29yZS5Db21tb24uTmV0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::V2Ray.Core.Common.Net.Network), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::V2Ray.Core.Common.Net.NetworkList), global::V2Ray.Core.Common.Net.NetworkList.Parser, new[]{ "Network" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Network {
    [pbr::OriginalName("Unknown")] Unknown = 0,
    [pbr::OriginalName("RawTCP")] RawTcp = 1,
    [pbr::OriginalName("TCP")] Tcp = 2,
    [pbr::OriginalName("UDP")] Udp = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// NetworkList is a list of Networks.
  /// </summary>
  public sealed partial class NetworkList : pb::IMessage<NetworkList> {
    private static readonly pb::MessageParser<NetworkList> _parser = new pb::MessageParser<NetworkList>(() => new NetworkList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NetworkList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V2Ray.Core.Common.Net.NetworkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkList(NetworkList other) : this() {
      network_ = other.network_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NetworkList Clone() {
      return new NetworkList(this);
    }

    /// <summary>Field number for the "network" field.</summary>
    public const int NetworkFieldNumber = 1;
    private static readonly pb::FieldCodec<global::V2Ray.Core.Common.Net.Network> _repeated_network_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::V2Ray.Core.Common.Net.Network) x);
    private readonly pbc::RepeatedField<global::V2Ray.Core.Common.Net.Network> network_ = new pbc::RepeatedField<global::V2Ray.Core.Common.Net.Network>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::V2Ray.Core.Common.Net.Network> Network {
      get { return network_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NetworkList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NetworkList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!network_.Equals(other.network_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= network_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      network_.WriteTo(output, _repeated_network_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += network_.CalculateSize(_repeated_network_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NetworkList other) {
      if (other == null) {
        return;
      }
      network_.Add(other.network_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            network_.AddEntriesFrom(input, _repeated_network_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
