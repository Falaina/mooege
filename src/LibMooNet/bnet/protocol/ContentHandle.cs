// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol {
  
  namespace Proto {
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public static partial class ContentHandle {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_bnet_protocol_ContentHandle__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.ContentHandle, global::bnet.protocol.ContentHandle.Builder> internal__static_bnet_protocol_ContentHandle__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static ContentHandle() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            "ChlibmV0L2NvbnRlbnRfaGFuZGxlLnByb3RvEg1ibmV0LnByb3RvY29sIk8K" + 
            "DUNvbnRlbnRIYW5kbGUSDgoGcmVnaW9uGAEgAigHEg0KBXVzYWdlGAIgAigH" + 
            "EgwKBGhhc2gYAyACKAwSEQoJcHJvdG9fdXJsGAQgASgJ");
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_bnet_protocol_ContentHandle__Descriptor = Descriptor.MessageTypes[0];
          internal__static_bnet_protocol_ContentHandle__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.ContentHandle, global::bnet.protocol.ContentHandle.Builder>(internal__static_bnet_protocol_ContentHandle__Descriptor,
                  new string[] { "Region", "Usage", "Hash", "ProtoUrl", });
          return null;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            }, assigner);
      }
      #endregion
      
    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class ContentHandle : pb::GeneratedMessage<ContentHandle, ContentHandle.Builder> {
    private ContentHandle() { }
    private static readonly ContentHandle defaultInstance = new ContentHandle().MakeReadOnly();
    private static readonly string[] _contentHandleFieldNames = new string[] { "hash", "proto_url", "region", "usage" };
    private static readonly uint[] _contentHandleFieldTags = new uint[] { 26, 34, 13, 21 };
    public static ContentHandle DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override ContentHandle DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override ContentHandle ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.Proto.ContentHandle.internal__static_bnet_protocol_ContentHandle__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<ContentHandle, ContentHandle.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.Proto.ContentHandle.internal__static_bnet_protocol_ContentHandle__FieldAccessorTable; }
    }
    
    public const int RegionFieldNumber = 1;
    private bool hasRegion;
    private uint region_;
    public bool HasRegion {
      get { return hasRegion; }
    }
    public uint Region {
      get { return region_; }
    }
    
    public const int UsageFieldNumber = 2;
    private bool hasUsage;
    private uint usage_;
    public bool HasUsage {
      get { return hasUsage; }
    }
    public uint Usage {
      get { return usage_; }
    }
    
    public const int HashFieldNumber = 3;
    private bool hasHash;
    private pb::ByteString hash_ = pb::ByteString.Empty;
    public bool HasHash {
      get { return hasHash; }
    }
    public pb::ByteString Hash {
      get { return hash_; }
    }
    
    public const int ProtoUrlFieldNumber = 4;
    private bool hasProtoUrl;
    private string protoUrl_ = "";
    public bool HasProtoUrl {
      get { return hasProtoUrl; }
    }
    public string ProtoUrl {
      get { return protoUrl_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasRegion) return false;
        if (!hasUsage) return false;
        if (!hasHash) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _contentHandleFieldNames;
      if (hasRegion) {
        output.WriteFixed32(1, field_names[2], Region);
      }
      if (hasUsage) {
        output.WriteFixed32(2, field_names[3], Usage);
      }
      if (hasHash) {
        output.WriteBytes(3, field_names[0], Hash);
      }
      if (hasProtoUrl) {
        output.WriteString(4, field_names[1], ProtoUrl);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasRegion) {
          size += pb::CodedOutputStream.ComputeFixed32Size(1, Region);
        }
        if (hasUsage) {
          size += pb::CodedOutputStream.ComputeFixed32Size(2, Usage);
        }
        if (hasHash) {
          size += pb::CodedOutputStream.ComputeBytesSize(3, Hash);
        }
        if (hasProtoUrl) {
          size += pb::CodedOutputStream.ComputeStringSize(4, ProtoUrl);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static ContentHandle ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ContentHandle ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ContentHandle ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static ContentHandle ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static ContentHandle ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ContentHandle ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static ContentHandle ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static ContentHandle ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static ContentHandle ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static ContentHandle ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private ContentHandle MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(ContentHandle prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<ContentHandle, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(ContentHandle cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private ContentHandle result;
      
      private ContentHandle PrepareBuilder() {
        if (resultIsReadOnly) {
          ContentHandle original = result;
          result = new ContentHandle();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override ContentHandle MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.ContentHandle.Descriptor; }
      }
      
      public override ContentHandle DefaultInstanceForType {
        get { return global::bnet.protocol.ContentHandle.DefaultInstance; }
      }
      
      public override ContentHandle BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is ContentHandle) {
          return MergeFrom((ContentHandle) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(ContentHandle other) {
        if (other == global::bnet.protocol.ContentHandle.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasRegion) {
          Region = other.Region;
        }
        if (other.HasUsage) {
          Usage = other.Usage;
        }
        if (other.HasHash) {
          Hash = other.Hash;
        }
        if (other.HasProtoUrl) {
          ProtoUrl = other.ProtoUrl;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_contentHandleFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _contentHandleFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 13: {
              result.hasRegion = input.ReadFixed32(ref result.region_);
              break;
            }
            case 21: {
              result.hasUsage = input.ReadFixed32(ref result.usage_);
              break;
            }
            case 26: {
              result.hasHash = input.ReadBytes(ref result.hash_);
              break;
            }
            case 34: {
              result.hasProtoUrl = input.ReadString(ref result.protoUrl_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasRegion {
        get { return result.hasRegion; }
      }
      public uint Region {
        get { return result.Region; }
        set { SetRegion(value); }
      }
      public Builder SetRegion(uint value) {
        PrepareBuilder();
        result.hasRegion = true;
        result.region_ = value;
        return this;
      }
      public Builder ClearRegion() {
        PrepareBuilder();
        result.hasRegion = false;
        result.region_ = 0;
        return this;
      }
      
      public bool HasUsage {
        get { return result.hasUsage; }
      }
      public uint Usage {
        get { return result.Usage; }
        set { SetUsage(value); }
      }
      public Builder SetUsage(uint value) {
        PrepareBuilder();
        result.hasUsage = true;
        result.usage_ = value;
        return this;
      }
      public Builder ClearUsage() {
        PrepareBuilder();
        result.hasUsage = false;
        result.usage_ = 0;
        return this;
      }
      
      public bool HasHash {
        get { return result.hasHash; }
      }
      public pb::ByteString Hash {
        get { return result.Hash; }
        set { SetHash(value); }
      }
      public Builder SetHash(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasHash = true;
        result.hash_ = value;
        return this;
      }
      public Builder ClearHash() {
        PrepareBuilder();
        result.hasHash = false;
        result.hash_ = pb::ByteString.Empty;
        return this;
      }
      
      public bool HasProtoUrl {
        get { return result.hasProtoUrl; }
      }
      public string ProtoUrl {
        get { return result.ProtoUrl; }
        set { SetProtoUrl(value); }
      }
      public Builder SetProtoUrl(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasProtoUrl = true;
        result.protoUrl_ = value;
        return this;
      }
      public Builder ClearProtoUrl() {
        PrepareBuilder();
        result.hasProtoUrl = false;
        result.protoUrl_ = "";
        return this;
      }
    }
    static ContentHandle() {
      object.ReferenceEquals(global::bnet.protocol.Proto.ContentHandle.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
