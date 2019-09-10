// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LambdaMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RedNimbus.Messages {

  /// <summary>Holder for reflection information generated from LambdaMessage.proto</summary>
  public static partial class LambdaMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for LambdaMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LambdaMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNMYW1iZGFNZXNzYWdlLnByb3RvEhJSZWROaW1idXMuTWVzc2FnZXMilgIK",
            "DUxhbWJkYU1lc3NhZ2USDAoETmFtZRgBIAEoCRI+CgdUcmlnZ2VyGAIgASgO",
            "Mi0uUmVkTmltYnVzLk1lc3NhZ2VzLkxhbWJkYU1lc3NhZ2UuVHJpZ2dlclR5",
            "cGUSPgoHUnVudGltZRgDIAEoDjItLlJlZE5pbWJ1cy5NZXNzYWdlcy5MYW1i",
            "ZGFNZXNzYWdlLlJ1bnRpbWVUeXBlEg8KB093bmVySWQYBCABKAkSDwoHSW1h",
            "Z2VJZBgFIAEoCRIMCgRHdWlkGAYgASgJIiAKC1RyaWdnZXJUeXBlEgcKA0dF",
            "VBAAEggKBFBPU1QQASIlCgtSdW50aW1lVHlwZRIKCgZDU0hBUlAQABIKCgZQ",
            "WVRIT04QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RedNimbus.Messages.LambdaMessage), global::RedNimbus.Messages.LambdaMessage.Parser, new[]{ "Name", "Trigger", "Runtime", "OwnerId", "ImageId", "Guid" }, null, new[]{ typeof(global::RedNimbus.Messages.LambdaMessage.Types.TriggerType), typeof(global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LambdaMessage : pb::IMessage<LambdaMessage> {
    private static readonly pb::MessageParser<LambdaMessage> _parser = new pb::MessageParser<LambdaMessage>(() => new LambdaMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LambdaMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RedNimbus.Messages.LambdaMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LambdaMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LambdaMessage(LambdaMessage other) : this() {
      name_ = other.name_;
      trigger_ = other.trigger_;
      runtime_ = other.runtime_;
      ownerId_ = other.ownerId_;
      imageId_ = other.imageId_;
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LambdaMessage Clone() {
      return new LambdaMessage(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Trigger" field.</summary>
    public const int TriggerFieldNumber = 2;
    private global::RedNimbus.Messages.LambdaMessage.Types.TriggerType trigger_ = global::RedNimbus.Messages.LambdaMessage.Types.TriggerType.Get;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RedNimbus.Messages.LambdaMessage.Types.TriggerType Trigger {
      get { return trigger_; }
      set {
        trigger_ = value;
      }
    }

    /// <summary>Field number for the "Runtime" field.</summary>
    public const int RuntimeFieldNumber = 3;
    private global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType runtime_ = global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType.Csharp;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType Runtime {
      get { return runtime_; }
      set {
        runtime_ = value;
      }
    }

    /// <summary>Field number for the "OwnerId" field.</summary>
    public const int OwnerIdFieldNumber = 4;
    private string ownerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OwnerId {
      get { return ownerId_; }
      set {
        ownerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ImageId" field.</summary>
    public const int ImageIdFieldNumber = 5;
    private string imageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageId {
      get { return imageId_; }
      set {
        imageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Guid" field.</summary>
    public const int GuidFieldNumber = 6;
    private string guid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Guid {
      get { return guid_; }
      set {
        guid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LambdaMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LambdaMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Trigger != other.Trigger) return false;
      if (Runtime != other.Runtime) return false;
      if (OwnerId != other.OwnerId) return false;
      if (ImageId != other.ImageId) return false;
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Trigger != global::RedNimbus.Messages.LambdaMessage.Types.TriggerType.Get) hash ^= Trigger.GetHashCode();
      if (Runtime != global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType.Csharp) hash ^= Runtime.GetHashCode();
      if (OwnerId.Length != 0) hash ^= OwnerId.GetHashCode();
      if (ImageId.Length != 0) hash ^= ImageId.GetHashCode();
      if (Guid.Length != 0) hash ^= Guid.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Trigger != global::RedNimbus.Messages.LambdaMessage.Types.TriggerType.Get) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Trigger);
      }
      if (Runtime != global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType.Csharp) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Runtime);
      }
      if (OwnerId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(OwnerId);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ImageId);
      }
      if (Guid.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Guid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Trigger != global::RedNimbus.Messages.LambdaMessage.Types.TriggerType.Get) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Trigger);
      }
      if (Runtime != global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType.Csharp) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Runtime);
      }
      if (OwnerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerId);
      }
      if (ImageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageId);
      }
      if (Guid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Guid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LambdaMessage other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Trigger != global::RedNimbus.Messages.LambdaMessage.Types.TriggerType.Get) {
        Trigger = other.Trigger;
      }
      if (other.Runtime != global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType.Csharp) {
        Runtime = other.Runtime;
      }
      if (other.OwnerId.Length != 0) {
        OwnerId = other.OwnerId;
      }
      if (other.ImageId.Length != 0) {
        ImageId = other.ImageId;
      }
      if (other.Guid.Length != 0) {
        Guid = other.Guid;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Trigger = (global::RedNimbus.Messages.LambdaMessage.Types.TriggerType) input.ReadEnum();
            break;
          }
          case 24: {
            Runtime = (global::RedNimbus.Messages.LambdaMessage.Types.RuntimeType) input.ReadEnum();
            break;
          }
          case 34: {
            OwnerId = input.ReadString();
            break;
          }
          case 42: {
            ImageId = input.ReadString();
            break;
          }
          case 50: {
            Guid = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LambdaMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum TriggerType {
        [pbr::OriginalName("GET")] Get = 0,
        [pbr::OriginalName("POST")] Post = 1,
      }

      public enum RuntimeType {
        [pbr::OriginalName("CSHARP")] Csharp = 0,
        [pbr::OriginalName("PYTHON")] Python = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
