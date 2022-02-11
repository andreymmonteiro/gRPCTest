// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Login.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gRPCTest.Protos {

  /// <summary>Holder for reflection information generated from Protos/Login.proto</summary>
  public static partial class LoginReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Login.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvTG9naW4ucHJvdG8iOQoTR2V0VXNlckxvZ2luUmVxdWVzdBIQ",
            "Cgh1c2VyTmFtZRgBIAEoCRIQCghwYXNzd29yZBgCIAEoCSKLAQoPVXNlckxv",
            "Z2luUHJvRHRvEgoKAmlkGAEgASgJEhIKCmNyZWF0ZURhdGUYAiABKAkSEgoK",
            "dXBkYXRlRGF0ZRgDIAEoCRIMCgRuYW1lGAQgASgJEhAKCGRvY3VtZW50GAUg",
            "ASgJEgsKA2FnZRgGIAEoBRIXCg9jb21wYW55T3JQZXJzb24YByABKAkyOwoF",
            "TG9naW4SMgoIR2V0TG9naW4SFC5HZXRVc2VyTG9naW5SZXF1ZXN0GhAuVXNl",
            "ckxvZ2luUHJvRHRvQhKqAg9nUlBDVGVzdC5Qcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPCTest.Protos.GetUserLoginRequest), global::gRPCTest.Protos.GetUserLoginRequest.Parser, new[]{ "UserName", "Password" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gRPCTest.Protos.UserLoginProDto), global::gRPCTest.Protos.UserLoginProDto.Parser, new[]{ "Id", "CreateDate", "UpdateDate", "Name", "Document", "Age", "CompanyOrPerson" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetUserLoginRequest : pb::IMessage<GetUserLoginRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetUserLoginRequest> _parser = new pb::MessageParser<GetUserLoginRequest>(() => new GetUserLoginRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetUserLoginRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPCTest.Protos.LoginReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserLoginRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserLoginRequest(GetUserLoginRequest other) : this() {
      userName_ = other.userName_;
      password_ = other.password_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetUserLoginRequest Clone() {
      return new GetUserLoginRequest(this);
    }

    /// <summary>Field number for the "userName" field.</summary>
    public const int UserNameFieldNumber = 1;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "password" field.</summary>
    public const int PasswordFieldNumber = 2;
    private string password_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetUserLoginRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetUserLoginRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserName != other.UserName) return false;
      if (Password != other.Password) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (Password.Length != 0) hash ^= Password.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetUserLoginRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.Password.Length != 0) {
        Password = other.Password;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserName = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            UserName = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class UserLoginProDto : pb::IMessage<UserLoginProDto>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserLoginProDto> _parser = new pb::MessageParser<UserLoginProDto>(() => new UserLoginProDto());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLoginProDto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRPCTest.Protos.LoginReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginProDto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginProDto(UserLoginProDto other) : this() {
      id_ = other.id_;
      createDate_ = other.createDate_;
      updateDate_ = other.updateDate_;
      name_ = other.name_;
      document_ = other.document_;
      age_ = other.age_;
      companyOrPerson_ = other.companyOrPerson_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLoginProDto Clone() {
      return new UserLoginProDto(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "createDate" field.</summary>
    public const int CreateDateFieldNumber = 2;
    private string createDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CreateDate {
      get { return createDate_; }
      set {
        createDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "updateDate" field.</summary>
    public const int UpdateDateFieldNumber = 3;
    private string updateDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UpdateDate {
      get { return updateDate_; }
      set {
        updateDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "document" field.</summary>
    public const int DocumentFieldNumber = 5;
    private string document_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Document {
      get { return document_; }
      set {
        document_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "age" field.</summary>
    public const int AgeFieldNumber = 6;
    private int age_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Age {
      get { return age_; }
      set {
        age_ = value;
      }
    }

    /// <summary>Field number for the "companyOrPerson" field.</summary>
    public const int CompanyOrPersonFieldNumber = 7;
    private string companyOrPerson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CompanyOrPerson {
      get { return companyOrPerson_; }
      set {
        companyOrPerson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLoginProDto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLoginProDto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (CreateDate != other.CreateDate) return false;
      if (UpdateDate != other.UpdateDate) return false;
      if (Name != other.Name) return false;
      if (Document != other.Document) return false;
      if (Age != other.Age) return false;
      if (CompanyOrPerson != other.CompanyOrPerson) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (CreateDate.Length != 0) hash ^= CreateDate.GetHashCode();
      if (UpdateDate.Length != 0) hash ^= UpdateDate.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Document.Length != 0) hash ^= Document.GetHashCode();
      if (Age != 0) hash ^= Age.GetHashCode();
      if (CompanyOrPerson.Length != 0) hash ^= CompanyOrPerson.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (CreateDate.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CreateDate);
      }
      if (UpdateDate.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UpdateDate);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Document.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Document);
      }
      if (Age != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Age);
      }
      if (CompanyOrPerson.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CompanyOrPerson);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (CreateDate.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CreateDate);
      }
      if (UpdateDate.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UpdateDate);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Document.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Document);
      }
      if (Age != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Age);
      }
      if (CompanyOrPerson.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CompanyOrPerson);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (CreateDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreateDate);
      }
      if (UpdateDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UpdateDate);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Document.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Document);
      }
      if (Age != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
      }
      if (CompanyOrPerson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyOrPerson);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLoginProDto other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.CreateDate.Length != 0) {
        CreateDate = other.CreateDate;
      }
      if (other.UpdateDate.Length != 0) {
        UpdateDate = other.UpdateDate;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Document.Length != 0) {
        Document = other.Document;
      }
      if (other.Age != 0) {
        Age = other.Age;
      }
      if (other.CompanyOrPerson.Length != 0) {
        CompanyOrPerson = other.CompanyOrPerson;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            CreateDate = input.ReadString();
            break;
          }
          case 26: {
            UpdateDate = input.ReadString();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Document = input.ReadString();
            break;
          }
          case 48: {
            Age = input.ReadInt32();
            break;
          }
          case 58: {
            CompanyOrPerson = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            CreateDate = input.ReadString();
            break;
          }
          case 26: {
            UpdateDate = input.ReadString();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Document = input.ReadString();
            break;
          }
          case 48: {
            Age = input.ReadInt32();
            break;
          }
          case 58: {
            CompanyOrPerson = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
