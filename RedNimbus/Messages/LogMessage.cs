// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LogMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RedNimbus.Messages {

  /// <summary>Holder for reflection information generated from LogMessage.proto</summary>
  public static partial class LogMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for LogMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBMb2dNZXNzYWdlLnByb3RvEhJSZWROaW1idXMuTWVzc2FnZXMiuwEKCkxv",
            "Z01lc3NhZ2USDgoGT3JpZ2luGAEgASgJEgwKBERhdGUYAiABKAkSDAoEVGlt",
            "ZRgDIAEoCRIPCgdQYXlsb2FkGAQgASgJEjQKBFR5cGUYBSABKA4yJi5SZWRO",
            "aW1idXMuTWVzc2FnZXMuTG9nTWVzc2FnZS5Mb2dUeXBlIjoKB0xvZ1R5cGUS",
            "CAoESW5mbxAAEg0KCUV4Y2VwdGlvbhABEgsKB1dhcm5pbmcQAhIJCgVFcnJv",
            "chADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RedNimbus.Messages.LogMessage), global::RedNimbus.Messages.LogMessage.Parser, new[]{ "Origin", "Date", "Time", "Payload", "Type" }, null, new[]{ typeof(global::RedNimbus.Messages.LogMessage.Types.LogType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LogMessage : pb::IMessage<LogMessage> {
    private static readonly pb::MessageParser<LogMessage> _parser = new pb::MessageParser<LogMessage>(() => new LogMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RedNimbus.Messages.LogMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogMessage(LogMessage other) : this() {
      origin_ = other.origin_;
      date_ = other.date_;
      time_ = other.time_;
      payload_ = other.payload_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogMessage Clone() {
      return new LogMessage(this);
    }

    /// <summary>Field number for the "Origin" field.</summary>
    public const int OriginFieldNumber = 1;
    private string origin_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Origin {
      get { return origin_; }
      set {
        origin_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Date" field.</summary>
    public const int DateFieldNumber = 2;
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 3;
    private string time_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Time {
      get { return time_; }
      set {
        time_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Payload" field.</summary>
    public const int PayloadFieldNumber = 4;
    private string payload_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Type" field.</summary>
    public const int TypeFieldNumber = 5;
    private global::RedNimbus.Messages.LogMessage.Types.LogType type_ = global::RedNimbus.Messages.LogMessage.Types.LogType.Info;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RedNimbus.Messages.LogMessage.Types.LogType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Origin != other.Origin) return false;
      if (Date != other.Date) return false;
      if (Time != other.Time) return false;
      if (Payload != other.Payload) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Origin.Length != 0) hash ^= Origin.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (Time.Length != 0) hash ^= Time.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      if (Type != global::RedNimbus.Messages.LogMessage.Types.LogType.Info) hash ^= Type.GetHashCode();
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
      if (Origin.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Origin);
      }
      if (Date.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Date);
      }
      if (Time.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Time);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Payload);
      }
      if (Type != global::RedNimbus.Messages.LogMessage.Types.LogType.Info) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Origin.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Origin);
      }
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      if (Time.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Time);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Payload);
      }
      if (Type != global::RedNimbus.Messages.LogMessage.Types.LogType.Info) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogMessage other) {
      if (other == null) {
        return;
      }
      if (other.Origin.Length != 0) {
        Origin = other.Origin;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      if (other.Time.Length != 0) {
        Time = other.Time;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
      if (other.Type != global::RedNimbus.Messages.LogMessage.Types.LogType.Info) {
        Type = other.Type;
      }
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
          case 10: {
            Origin = input.ReadString();
            break;
          }
          case 18: {
            Date = input.ReadString();
            break;
          }
          case 26: {
            Time = input.ReadString();
            break;
          }
          case 34: {
            Payload = input.ReadString();
            break;
          }
          case 40: {
            Type = (global::RedNimbus.Messages.LogMessage.Types.LogType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LogMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum LogType {
        [pbr::OriginalName("Info")] Info = 0,
        [pbr::OriginalName("Exception")] Exception = 1,
        [pbr::OriginalName("Warning")] Warning = 2,
        [pbr::OriginalName("Error")] Error = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
