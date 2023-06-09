// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/userProto.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UhlnocsServer {
  /// <summary>
  /// User Service provides methods for signing up, signing in, updating and getting data about CAD users.
  /// </summary>
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
    static readonly grpc::Marshaller<global::UhlnocsServer.UserFullDataMessage> __Marshaller_userProto_UserFullDataMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UserFullDataMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UserEmptyMessage> __Marshaller_userProto_UserEmptyMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UserEmptyMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UserSignInRequest> __Marshaller_userProto_UserSignInRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UserSignInRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UserIdMessage> __Marshaller_userProto_UserIdMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UserIdMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UserOpenDataReply> __Marshaller_userProto_UserOpenDataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UserOpenDataReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UsersIdsRequest> __Marshaller_userProto_UsersIdsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UsersIdsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.UsersOpenDataReply> __Marshaller_userProto_UsersOpenDataReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.UsersOpenDataReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage> __Method_SignUpUser = new grpc::Method<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignUpUser",
        __Marshaller_userProto_UserFullDataMessage,
        __Marshaller_userProto_UserEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserSignInRequest, global::UhlnocsServer.UserFullDataMessage> __Method_SignInUser = new grpc::Method<global::UhlnocsServer.UserSignInRequest, global::UhlnocsServer.UserFullDataMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SignInUser",
        __Marshaller_userProto_UserSignInRequest,
        __Marshaller_userProto_UserFullDataMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserEmptyMessage> __Method_DeleteUser = new grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteUser",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_UserEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage> __Method_UpdateUser = new grpc::Method<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateUser",
        __Marshaller_userProto_UserFullDataMessage,
        __Marshaller_userProto_UserEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserFullDataMessage> __Method_GetUserFullData = new grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserFullDataMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserFullData",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_UserFullDataMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserOpenDataReply> __Method_GetUserOpenData = new grpc::Method<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserOpenData",
        __Marshaller_userProto_UserIdMessage,
        __Marshaller_userProto_UserOpenDataReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UsersIdsRequest, global::UhlnocsServer.UsersOpenDataReply> __Method_GetUsersOpenData = new grpc::Method<global::UhlnocsServer.UsersIdsRequest, global::UhlnocsServer.UsersOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUsersOpenData",
        __Marshaller_userProto_UsersIdsRequest,
        __Marshaller_userProto_UsersOpenDataReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.UserEmptyMessage, global::UhlnocsServer.UsersOpenDataReply> __Method_GetAllUsersOpenData = new grpc::Method<global::UhlnocsServer.UserEmptyMessage, global::UhlnocsServer.UsersOpenDataReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllUsersOpenData",
        __Marshaller_userProto_UserEmptyMessage,
        __Marshaller_userProto_UsersOpenDataReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UhlnocsServer.UserProtoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UserServiceProto</summary>
    [grpc::BindServiceMethod(typeof(UserServiceProto), "BindService")]
    public abstract partial class UserServiceProtoBase
    {
      /// <summary>
      /// This method allows user to sign up.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserEmptyMessage> SignUpUser(global::UhlnocsServer.UserFullDataMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows user to sign in.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserFullDataMessage> SignInUser(global::UhlnocsServer.UserSignInRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to delete user info. Only admins of CAD may perform this operation. This method was created for testing and development and is not recommended for use in production.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserEmptyMessage> DeleteUser(global::UhlnocsServer.UserIdMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows user to update information about him. Id can not be changed by it. If you want to change your id, contact admins.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserEmptyMessage> UpdateUser(global::UhlnocsServer.UserFullDataMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get all information about user (including confidential info). Users may not use this method to get info about other users.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserFullDataMessage> GetUserFullData(global::UhlnocsServer.UserIdMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get non-confidential information about user.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UserOpenDataReply> GetUserOpenData(global::UhlnocsServer.UserIdMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get non-confidential information about certain users.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UsersOpenDataReply> GetUsersOpenData(global::UhlnocsServer.UsersIdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get non-confidential information about all users.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.UsersOpenDataReply> GetAllUsersOpenData(global::UhlnocsServer.UserEmptyMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(UserServiceProtoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SignUpUser, serviceImpl.SignUpUser)
          .AddMethod(__Method_SignInUser, serviceImpl.SignInUser)
          .AddMethod(__Method_DeleteUser, serviceImpl.DeleteUser)
          .AddMethod(__Method_UpdateUser, serviceImpl.UpdateUser)
          .AddMethod(__Method_GetUserFullData, serviceImpl.GetUserFullData)
          .AddMethod(__Method_GetUserOpenData, serviceImpl.GetUserOpenData)
          .AddMethod(__Method_GetUsersOpenData, serviceImpl.GetUsersOpenData)
          .AddMethod(__Method_GetAllUsersOpenData, serviceImpl.GetAllUsersOpenData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UserServiceProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SignUpUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage>(serviceImpl.SignUpUser));
      serviceBinder.AddMethod(__Method_SignInUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserSignInRequest, global::UhlnocsServer.UserFullDataMessage>(serviceImpl.SignInUser));
      serviceBinder.AddMethod(__Method_DeleteUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserEmptyMessage>(serviceImpl.DeleteUser));
      serviceBinder.AddMethod(__Method_UpdateUser, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserFullDataMessage, global::UhlnocsServer.UserEmptyMessage>(serviceImpl.UpdateUser));
      serviceBinder.AddMethod(__Method_GetUserFullData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserFullDataMessage>(serviceImpl.GetUserFullData));
      serviceBinder.AddMethod(__Method_GetUserOpenData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserIdMessage, global::UhlnocsServer.UserOpenDataReply>(serviceImpl.GetUserOpenData));
      serviceBinder.AddMethod(__Method_GetUsersOpenData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UsersIdsRequest, global::UhlnocsServer.UsersOpenDataReply>(serviceImpl.GetUsersOpenData));
      serviceBinder.AddMethod(__Method_GetAllUsersOpenData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.UserEmptyMessage, global::UhlnocsServer.UsersOpenDataReply>(serviceImpl.GetAllUsersOpenData));
    }

  }
}
#endregion
