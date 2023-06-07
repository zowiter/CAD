// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/modelProto.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UhlnocsServer {
  /// <summary>
  /// Model Service provides methods for adding, updating and getting information about models as well as getting information about NoC parameters and characteristics
  /// </summary>
  public static partial class ModelServiceProto
  {
    static readonly string __ServiceName = "modelProto.ModelServiceProto";

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
    static readonly grpc::Marshaller<global::UhlnocsServer.ModelConfigurationRequest> __Marshaller_modelProto_ModelConfigurationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ModelConfigurationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ModelEmptyMessage> __Marshaller_modelProto_ModelEmptyMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ModelEmptyMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ModelIdRequest> __Marshaller_modelProto_ModelIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ModelIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ModelConfigurationReply> __Marshaller_modelProto_ModelConfigurationReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ModelConfigurationReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ModelsConfigurationsReply> __Marshaller_modelProto_ModelsConfigurationsReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ModelsConfigurationsReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ArchivePartRequest> __Marshaller_modelProto_ArchivePartRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ArchivePartRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ArchivePartReply> __Marshaller_modelProto_ArchivePartReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ArchivePartReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.ParametersWithModelsReply> __Marshaller_modelProto_ParametersWithModelsReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.ParametersWithModelsReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UhlnocsServer.CharacteristicsWithModelsReply> __Marshaller_modelProto_CharacteristicsWithModelsReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UhlnocsServer.CharacteristicsWithModelsReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage> __Method_AddModelConfiguration = new grpc::Method<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddModelConfiguration",
        __Marshaller_modelProto_ModelConfigurationRequest,
        __Marshaller_modelProto_ModelEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage> __Method_UpdateModelConfiguration = new grpc::Method<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateModelConfiguration",
        __Marshaller_modelProto_ModelConfigurationRequest,
        __Marshaller_modelProto_ModelEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelEmptyMessage> __Method_DeleteModel = new grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelEmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteModel",
        __Marshaller_modelProto_ModelIdRequest,
        __Marshaller_modelProto_ModelEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelConfigurationReply> __Method_GetModelConfiguration = new grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelConfigurationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetModelConfiguration",
        __Marshaller_modelProto_ModelIdRequest,
        __Marshaller_modelProto_ModelConfigurationReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ModelsConfigurationsReply> __Method_GetModelsConfigurations = new grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ModelsConfigurationsReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetModelsConfigurations",
        __Marshaller_modelProto_ModelEmptyMessage,
        __Marshaller_modelProto_ModelsConfigurationsReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ArchivePartRequest, global::UhlnocsServer.ModelEmptyMessage> __Method_UploadModelArchive = new grpc::Method<global::UhlnocsServer.ArchivePartRequest, global::UhlnocsServer.ModelEmptyMessage>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadModelArchive",
        __Marshaller_modelProto_ArchivePartRequest,
        __Marshaller_modelProto_ModelEmptyMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ArchivePartReply> __Method_DownloadModelArchive = new grpc::Method<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ArchivePartReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "DownloadModelArchive",
        __Marshaller_modelProto_ModelIdRequest,
        __Marshaller_modelProto_ArchivePartReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ParametersWithModelsReply> __Method_GetParametersWithModels = new grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ParametersWithModelsReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetParametersWithModels",
        __Marshaller_modelProto_ModelEmptyMessage,
        __Marshaller_modelProto_ParametersWithModelsReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.CharacteristicsWithModelsReply> __Method_GetCharacteristicsWithModels = new grpc::Method<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.CharacteristicsWithModelsReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCharacteristicsWithModels",
        __Marshaller_modelProto_ModelEmptyMessage,
        __Marshaller_modelProto_CharacteristicsWithModelsReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UhlnocsServer.ModelProtoReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ModelServiceProto</summary>
    [grpc::BindServiceMethod(typeof(ModelServiceProto), "BindService")]
    public abstract partial class ModelServiceProtoBase
    {
      /// <summary>
      /// This method allows to add new model configuration to CAD.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelEmptyMessage> AddModelConfiguration(global::UhlnocsServer.ModelConfigurationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to update existing model configuration.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelEmptyMessage> UpdateModelConfiguration(global::UhlnocsServer.ModelConfigurationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to delete model configuration and files. Only admins may perform it. This method was created for testing and development and is not recommended for use in production.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelEmptyMessage> DeleteModel(global::UhlnocsServer.ModelIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This methos allows to get model configuration of existing model.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelConfigurationReply> GetModelConfiguration(global::UhlnocsServer.ModelIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get configurations of all existing models.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelsConfigurationsReply> GetModelsConfigurations(global::UhlnocsServer.ModelEmptyMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to upload archive with model files to server.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ModelEmptyMessage> UploadModelArchive(grpc::IAsyncStreamReader<global::UhlnocsServer.ArchivePartRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to download archive with model files from server.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task DownloadModelArchive(global::UhlnocsServer.ModelIdRequest request, grpc::IServerStreamWriter<global::UhlnocsServer.ArchivePartReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get information about all NoC parameters known by CAD.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.ParametersWithModelsReply> GetParametersWithModels(global::UhlnocsServer.ModelEmptyMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method allows to get information about all NoC characteristics known by CAD.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UhlnocsServer.CharacteristicsWithModelsReply> GetCharacteristicsWithModels(global::UhlnocsServer.ModelEmptyMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ModelServiceProtoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddModelConfiguration, serviceImpl.AddModelConfiguration)
          .AddMethod(__Method_UpdateModelConfiguration, serviceImpl.UpdateModelConfiguration)
          .AddMethod(__Method_DeleteModel, serviceImpl.DeleteModel)
          .AddMethod(__Method_GetModelConfiguration, serviceImpl.GetModelConfiguration)
          .AddMethod(__Method_GetModelsConfigurations, serviceImpl.GetModelsConfigurations)
          .AddMethod(__Method_UploadModelArchive, serviceImpl.UploadModelArchive)
          .AddMethod(__Method_DownloadModelArchive, serviceImpl.DownloadModelArchive)
          .AddMethod(__Method_GetParametersWithModels, serviceImpl.GetParametersWithModels)
          .AddMethod(__Method_GetCharacteristicsWithModels, serviceImpl.GetCharacteristicsWithModels).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ModelServiceProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddModelConfiguration, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage>(serviceImpl.AddModelConfiguration));
      serviceBinder.AddMethod(__Method_UpdateModelConfiguration, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelConfigurationRequest, global::UhlnocsServer.ModelEmptyMessage>(serviceImpl.UpdateModelConfiguration));
      serviceBinder.AddMethod(__Method_DeleteModel, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelEmptyMessage>(serviceImpl.DeleteModel));
      serviceBinder.AddMethod(__Method_GetModelConfiguration, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ModelConfigurationReply>(serviceImpl.GetModelConfiguration));
      serviceBinder.AddMethod(__Method_GetModelsConfigurations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ModelsConfigurationsReply>(serviceImpl.GetModelsConfigurations));
      serviceBinder.AddMethod(__Method_UploadModelArchive, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::UhlnocsServer.ArchivePartRequest, global::UhlnocsServer.ModelEmptyMessage>(serviceImpl.UploadModelArchive));
      serviceBinder.AddMethod(__Method_DownloadModelArchive, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::UhlnocsServer.ModelIdRequest, global::UhlnocsServer.ArchivePartReply>(serviceImpl.DownloadModelArchive));
      serviceBinder.AddMethod(__Method_GetParametersWithModels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.ParametersWithModelsReply>(serviceImpl.GetParametersWithModels));
      serviceBinder.AddMethod(__Method_GetCharacteristicsWithModels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UhlnocsServer.ModelEmptyMessage, global::UhlnocsServer.CharacteristicsWithModelsReply>(serviceImpl.GetCharacteristicsWithModels));
    }

  }
}
#endregion