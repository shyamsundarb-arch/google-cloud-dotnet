// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/finding.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/finding.proto</summary>
  public static partial class FindingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/finding.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FindingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvZmluZGluZy5wcm90",
            "bxIeZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYxGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9y",
            "LnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGjNnb29nbGUvY2xv",
            "dWQvc2VjdXJpdHljZW50ZXIvdjEvc2VjdXJpdHlfbWFya3MucHJvdG8aHGdv",
            "b2dsZS9wcm90b2J1Zi9zdHJ1Y3QucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8ipAUKB0ZpbmRpbmcSDAoEbmFtZRgBIAEoCRIOCgZw",
            "YXJlbnQYAiABKAkSFQoNcmVzb3VyY2VfbmFtZRgDIAEoCRI8CgVzdGF0ZRgE",
            "IAEoDjItLmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MS5GaW5kaW5n",
            "LlN0YXRlEhAKCGNhdGVnb3J5GAUgASgJEhQKDGV4dGVybmFsX3VyaRgGIAEo",
            "CRJYChFzb3VyY2VfcHJvcGVydGllcxgHIAMoCzI9Lmdvb2dsZS5jbG91ZC5z",
            "ZWN1cml0eWNlbnRlci52MS5GaW5kaW5nLlNvdXJjZVByb3BlcnRpZXNFbnRy",
            "eRJKCg5zZWN1cml0eV9tYXJrcxgIIAEoCzItLmdvb2dsZS5jbG91ZC5zZWN1",
            "cml0eWNlbnRlci52MS5TZWN1cml0eU1hcmtzQgPgQQMSLgoKZXZlbnRfdGlt",
            "ZRgJIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASLwoLY3JlYXRl",
            "X3RpbWUYCiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wGk8KFVNv",
            "dXJjZVByb3BlcnRpZXNFbnRyeRILCgNrZXkYASABKAkSJQoFdmFsdWUYAiAB",
            "KAsyFi5nb29nbGUucHJvdG9idWYuVmFsdWU6AjgBIjgKBVN0YXRlEhUKEVNU",
            "QVRFX1VOU1BFQ0lGSUVEEAASCgoGQUNUSVZFEAESDAoISU5BQ1RJVkUQAjps",
            "6kFpCiVzZWN1cml0eWNlbnRlci5nb29nbGVhcGlzLmNvbS9GaW5kaW5nEkBv",
            "cmdhbml6YXRpb25zL3tvcmdhbml6YXRpb259L3NvdXJjZXMve3NvdXJjZX0v",
            "ZmluZGluZ3Mve2ZpbmRpbmd9QtoBCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3Vy",
            "aXR5Y2VudGVyLnYxUAFaTGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjE7c2VjdXJpdHljZW50",
            "ZXKqAh5Hb29nbGUuQ2xvdWQuU2VjdXJpdHlDZW50ZXIuVjHKAh5Hb29nbGVc",
            "Q2xvdWRcU2VjdXJpdHlDZW50ZXJcVjHqAiFHb29nbGU6OkNsb3VkOjpTZWN1",
            "cml0eUNlbnRlcjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.SecurityCenter.V1.SecurityMarksReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.Finding), global::Google.Cloud.SecurityCenter.V1.Finding.Parser, new[]{ "Name", "Parent", "ResourceName", "State", "Category", "ExternalUri", "SourceProperties", "SecurityMarks", "EventTime", "CreateTime" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.V1.Finding.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Security Command Center finding.
  ///
  /// A finding is a record of assessment data like security, risk, health, or
  /// privacy, that is ingested into Security Command Center for presentation,
  /// notification, analysis, policy testing, and enforcement. For example, a
  /// cross-site scripting (XSS) vulnerability in an App Engine application is a
  /// finding.
  /// </summary>
  public sealed partial class Finding : pb::IMessage<Finding> {
    private static readonly pb::MessageParser<Finding> _parser = new pb::MessageParser<Finding>(() => new Finding());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Finding> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.FindingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Finding() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Finding(Finding other) : this() {
      name_ = other.name_;
      parent_ = other.parent_;
      resourceName_ = other.resourceName_;
      state_ = other.state_;
      category_ = other.category_;
      externalUri_ = other.externalUri_;
      sourceProperties_ = other.sourceProperties_.Clone();
      securityMarks_ = other.securityMarks_ != null ? other.securityMarks_.Clone() : null;
      eventTime_ = other.eventTime_ != null ? other.eventTime_.Clone() : null;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Finding Clone() {
      return new Finding(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of this finding. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Example:
    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 2;
    private string parent_ = "";
    /// <summary>
    /// The relative resource name of the source the finding belongs to. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// This field is immutable after creation time.
    /// For example:
    /// "organizations/{organization_id}/sources/{source_id}"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 3;
    private string resourceName_ = "";
    /// <summary>
    /// For findings on Google Cloud resources, the full resource
    /// name of the Google Cloud resource this finding is for. See:
    /// https://cloud.google.com/apis/design/resource_names#full_resource_name
    /// When the finding is for a non-Google Cloud resource, the resourceName can
    /// be a customer or partner defined string. This field is immutable after
    /// creation time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Cloud.SecurityCenter.V1.Finding.Types.State state_ = global::Google.Cloud.SecurityCenter.V1.Finding.Types.State.Unspecified;
    /// <summary>
    /// The state of the finding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1.Finding.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 5;
    private string category_ = "";
    /// <summary>
    /// The additional taxonomy group within findings from a given source.
    /// This field is immutable after creation time.
    /// Example: "XSS_FLASH_INJECTION"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Category {
      get { return category_; }
      set {
        category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "external_uri" field.</summary>
    public const int ExternalUriFieldNumber = 6;
    private string externalUri_ = "";
    /// <summary>
    /// The URI that, if available, points to a web page outside of Security
    /// Command Center where additional information about the finding can be found.
    /// This field is guaranteed to be either empty or a well formed URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExternalUri {
      get { return externalUri_; }
      set {
        externalUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_properties" field.</summary>
    public const int SourcePropertiesFieldNumber = 7;
    private static readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>.Codec _map_sourceProperties_codec
        = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Protobuf.WellKnownTypes.Value.Parser), 58);
    private readonly pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value> sourceProperties_ = new pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value>();
    /// <summary>
    /// Source specific properties. These properties are managed by the source
    /// that writes the finding. The key names in the source_properties map must be
    /// between 1 and 255 characters, and must start with a letter and contain
    /// alphanumeric characters or underscores only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Google.Protobuf.WellKnownTypes.Value> SourceProperties {
      get { return sourceProperties_; }
    }

    /// <summary>Field number for the "security_marks" field.</summary>
    public const int SecurityMarksFieldNumber = 8;
    private global::Google.Cloud.SecurityCenter.V1.SecurityMarks securityMarks_;
    /// <summary>
    /// Output only. User specified security marks. These marks are entirely
    /// managed by the user and come from the SecurityMarks resource that belongs
    /// to the finding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.SecurityCenter.V1.SecurityMarks SecurityMarks {
      get { return securityMarks_; }
      set {
        securityMarks_ = value;
      }
    }

    /// <summary>Field number for the "event_time" field.</summary>
    public const int EventTimeFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp eventTime_;
    /// <summary>
    /// The time at which the event took place. For example, if the finding
    /// represents an open firewall it would capture the time the detector believes
    /// the firewall became open. The accuracy is determined by the detector.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EventTime {
      get { return eventTime_; }
      set {
        eventTime_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// The time at which the finding was created in Security Command Center.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Finding);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Finding other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Parent != other.Parent) return false;
      if (ResourceName != other.ResourceName) return false;
      if (State != other.State) return false;
      if (Category != other.Category) return false;
      if (ExternalUri != other.ExternalUri) return false;
      if (!SourceProperties.Equals(other.SourceProperties)) return false;
      if (!object.Equals(SecurityMarks, other.SecurityMarks)) return false;
      if (!object.Equals(EventTime, other.EventTime)) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (State != global::Google.Cloud.SecurityCenter.V1.Finding.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (Category.Length != 0) hash ^= Category.GetHashCode();
      if (ExternalUri.Length != 0) hash ^= ExternalUri.GetHashCode();
      hash ^= SourceProperties.GetHashCode();
      if (securityMarks_ != null) hash ^= SecurityMarks.GetHashCode();
      if (eventTime_ != null) hash ^= EventTime.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Parent);
      }
      if (ResourceName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ResourceName);
      }
      if (State != global::Google.Cloud.SecurityCenter.V1.Finding.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (Category.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Category);
      }
      if (ExternalUri.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ExternalUri);
      }
      sourceProperties_.WriteTo(output, _map_sourceProperties_codec);
      if (securityMarks_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SecurityMarks);
      }
      if (eventTime_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(EventTime);
      }
      if (createTime_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CreateTime);
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
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (State != global::Google.Cloud.SecurityCenter.V1.Finding.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Category.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
      }
      if (ExternalUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExternalUri);
      }
      size += sourceProperties_.CalculateSize(_map_sourceProperties_codec);
      if (securityMarks_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecurityMarks);
      }
      if (eventTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EventTime);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Finding other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.State != global::Google.Cloud.SecurityCenter.V1.Finding.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.Category.Length != 0) {
        Category = other.Category;
      }
      if (other.ExternalUri.Length != 0) {
        ExternalUri = other.ExternalUri;
      }
      sourceProperties_.Add(other.sourceProperties_);
      if (other.securityMarks_ != null) {
        if (securityMarks_ == null) {
          SecurityMarks = new global::Google.Cloud.SecurityCenter.V1.SecurityMarks();
        }
        SecurityMarks.MergeFrom(other.SecurityMarks);
      }
      if (other.eventTime_ != null) {
        if (eventTime_ == null) {
          EventTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EventTime.MergeFrom(other.EventTime);
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
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
          case 18: {
            Parent = input.ReadString();
            break;
          }
          case 26: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            State = (global::Google.Cloud.SecurityCenter.V1.Finding.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            Category = input.ReadString();
            break;
          }
          case 50: {
            ExternalUri = input.ReadString();
            break;
          }
          case 58: {
            sourceProperties_.AddEntriesFrom(input, _map_sourceProperties_codec);
            break;
          }
          case 66: {
            if (securityMarks_ == null) {
              SecurityMarks = new global::Google.Cloud.SecurityCenter.V1.SecurityMarks();
            }
            input.ReadMessage(SecurityMarks);
            break;
          }
          case 74: {
            if (eventTime_ == null) {
              EventTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EventTime);
            break;
          }
          case 82: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Finding message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The state of the finding.
      /// </summary>
      public enum State {
        /// <summary>
        /// Unspecified state.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The finding requires attention and has not been addressed yet.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 1,
        /// <summary>
        /// The finding has been fixed, triaged as a non-issue or otherwise addressed
        /// and is no longer active.
        /// </summary>
        [pbr::OriginalName("INACTIVE")] Inactive = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
