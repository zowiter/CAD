// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/userProto.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UhlnocsClient {
  public static partial class UserServiceProto
  {
    static readonly string __ServiceName = "userProto.UserServiceProto";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UserWithoutIdRequest> __Marshaller_userProto_UserWithoutIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UserWithoutIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UserIdMessage> __Marshaller_userProto_UserIdMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UserIdMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UserSignInRequest> __Marshaller_userProto_UserSignInRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UserSignInRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UserFullDataMessage> __Marshaller_userProto_UserFullDataMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UserFullDataMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.EmptyMessage> __Marshaller_userProto_EmptyMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.EmptyMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UserOpenDataReply> __Marshaller_userProto_UserOpenDataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UserOpenDataReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UsersIdsRequest> __Marshaller_userProto_UsersIdsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UsersIdsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsClient.UsersOpenDataReply> __Marshaller_userProto_UsersOpenDataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsClient.UsersOpenDataReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserWithoutIdRequest, global::UhlnocsClient.UserIdMessage> __Method_SignUpUser = new grpc::Method<global::UhlnocsClient.UserWithoutIdRequest, global::UhlnocsClient.UserIdMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignUpUser",
        __Marshaller_userProto_UserWithoutIdRequest,
        __Marshaller_userProto_UserIdMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserSignInRequest, global::UhlnocsClient.UserFullDataMessage> __Method_SignInUser = new grpc::Method<global::UhlnocsClient.UserSignInRequest, global::UhlnocsClient.UserFullDataMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignInUser",
        __Marshaller_userProto_UserSignInRequest,
        __Marshaller_userProto_UserFullDataMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.EmptyMessage> __Method_DeleteUser = new grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteUser",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_EmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserFullDataMessage, global::UhlnocsClient.EmptyMessage> __Method_UpdateUser = new grpc::Method<global::UhlnocsClient.UserFullDataMessage, global::UhlnocsClient.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_userProto_UserFullDataMessage,
        __Marshaller_userProto_EmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.UserFullDataMessage> __Method_GetUserFullData = new grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.UserFullDataMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserFullData",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_UserFullDataMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.UserOpenDataReply> __Method_GetUserOpenData = new grpc::Method<global::UhlnocsClient.UserIdMessage, global::UhlnocsClient.UserOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserOpenData",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_UserOpenDataReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.UsersIdsRequest, global::UhlnocsClient.UsersOpenDataReply> __Method_GetUsersOpenData = new grpc::Method<global::UhlnocsClient.UsersIdsRequest, global::UhlnocsClient.UsersOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUsersOpenData",
        __Marshaller_userProto_UsersIdsRequest,
        __Marshaller_userProto_UsersOpenDataReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsClient.EmptyMessage, global::UhlnocsClient.UsersOpenDataReply> __Method_GetAllUsersOpenData = new grpc::Method<global::UhlnocsClient.EmptyMessage, global::UhlnocsClient.UsersOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUsersOpenData",
        __Marshaller_userProto_EmptyMessage,
        __Marshaller_userProto_UsersOpenDataReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UhlnocsClient.UserProtoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for UserServiceProto</summary>
    public partial class UserServiceProtoClient : grpc::ClientBase<UserServiceProtoClient>
    {
      /// <summary>Creates a new client for UserServiceProto</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public UserServiceProtoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserServiceProto that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public UserServiceProtoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected UserServiceProtoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected UserServiceProtoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserIdMessage SignUpUser(global::UhlnocsClient.UserWithoutIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignUpUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserIdMessage SignUpUser(global::UhlnocsClient.UserWithoutIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SignUpUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserIdMessage> SignUpUserAsync(global::UhlnocsClient.UserWithoutIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignUpUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserIdMessage> SignUpUserAsync(global::UhlnocsClient.UserWithoutIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SignUpUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserFullDataMessage SignInUser(global::UhlnocsClient.UserSignInRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignInUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserFullDataMessage SignInUser(global::UhlnocsClient.UserSignInRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SignInUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserFullDataMessage> SignInUserAsync(global::UhlnocsClient.UserSignInRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SignInUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserFullDataMessage> SignInUserAsync(global::UhlnocsClient.UserSignInRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SignInUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.EmptyMessage DeleteUser(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.EmptyMessage DeleteUser(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.EmptyMessage> DeleteUserAsync(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.EmptyMessage> DeleteUserAsync(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.EmptyMessage UpdateUser(global::UhlnocsClient.UserFullDataMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateUser(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.EmptyMessage UpdateUser(global::UhlnocsClient.UserFullDataMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.EmptyMessage> UpdateUserAsync(global::UhlnocsClient.UserFullDataMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateUserAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.EmptyMessage> UpdateUserAsync(global::UhlnocsClient.UserFullDataMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateUser, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserFullDataMessage GetUserFullData(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserFullData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserFullDataMessage GetUserFullData(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserFullData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserFullDataMessage> GetUserFullDataAsync(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserFullDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserFullDataMessage> GetUserFullDataAsync(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserFullData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserOpenDataReply GetUserOpenData(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserOpenData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UserOpenDataReply GetUserOpenData(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserOpenData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserOpenDataReply> GetUserOpenDataAsync(global::UhlnocsClient.UserIdMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserOpenDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UserOpenDataReply> GetUserOpenDataAsync(global::UhlnocsClient.UserIdMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserOpenData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UsersOpenDataReply GetUsersOpenData(global::UhlnocsClient.UsersIdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUsersOpenData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UsersOpenDataReply GetUsersOpenData(global::UhlnocsClient.UsersIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUsersOpenData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UsersOpenDataReply> GetUsersOpenDataAsync(global::UhlnocsClient.UsersIdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUsersOpenDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UsersOpenDataReply> GetUsersOpenDataAsync(global::UhlnocsClient.UsersIdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUsersOpenData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UsersOpenDataReply GetAllUsersOpenData(global::UhlnocsClient.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUsersOpenData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::UhlnocsClient.UsersOpenDataReply GetAllUsersOpenData(global::UhlnocsClient.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllUsersOpenData, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UsersOpenDataReply> GetAllUsersOpenDataAsync(global::UhlnocsClient.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllUsersOpenDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::UhlnocsClient.UsersOpenDataReply> GetAllUsersOpenDataAsync(global::UhlnocsClient.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllUsersOpenData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override UserServiceProtoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserServiceProtoClient(configuration);
      }
    }

  }
}
#endregion