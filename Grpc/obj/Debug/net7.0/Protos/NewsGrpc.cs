// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/news.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc {
  public static partial class NewsService
  {
    static readonly string __ServiceName = "NewsService";

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
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.NewsDTO> __Marshaller_NewsDTO = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.NewsDTO.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.NewsId> __Marshaller_NewsId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.NewsId.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.StringMessage> __Marshaller_StringMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.StringMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.UpdateNewsDTO> __Marshaller_UpdateNewsDTO = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.UpdateNewsDTO.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Grpc.NewsDTO> __Method_GetNews = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Grpc.NewsDTO>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetNews",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_NewsDTO);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Grpc.NewsId, global::Grpc.NewsDTO> __Method_GetNewById = new grpc::Method<global::Grpc.NewsId, global::Grpc.NewsDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetNewById",
        __Marshaller_NewsId,
        __Marshaller_NewsDTO);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Grpc.NewsDTO, global::Grpc.StringMessage> __Method_CreateNews = new grpc::Method<global::Grpc.NewsDTO, global::Grpc.StringMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateNews",
        __Marshaller_NewsDTO,
        __Marshaller_StringMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Grpc.UpdateNewsDTO, global::Grpc.StringMessage> __Method_UpdateNews = new grpc::Method<global::Grpc.UpdateNewsDTO, global::Grpc.StringMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateNews",
        __Marshaller_UpdateNewsDTO,
        __Marshaller_StringMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Grpc.NewsId, global::Grpc.StringMessage> __Method_RemoveNews = new grpc::Method<global::Grpc.NewsId, global::Grpc.StringMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveNews",
        __Marshaller_NewsId,
        __Marshaller_StringMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.NewsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NewsService</summary>
    [grpc::BindServiceMethod(typeof(NewsService), "BindService")]
    public abstract partial class NewsServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetNews(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::Grpc.NewsDTO> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Grpc.NewsDTO> GetNewById(global::Grpc.NewsId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Grpc.StringMessage> CreateNews(global::Grpc.NewsDTO request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Grpc.StringMessage> UpdateNews(global::Grpc.UpdateNewsDTO request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Grpc.StringMessage> RemoveNews(global::Grpc.NewsId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(NewsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetNews, serviceImpl.GetNews)
          .AddMethod(__Method_GetNewById, serviceImpl.GetNewById)
          .AddMethod(__Method_CreateNews, serviceImpl.CreateNews)
          .AddMethod(__Method_UpdateNews, serviceImpl.UpdateNews)
          .AddMethod(__Method_RemoveNews, serviceImpl.RemoveNews).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NewsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetNews, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Grpc.NewsDTO>(serviceImpl.GetNews));
      serviceBinder.AddMethod(__Method_GetNewById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.NewsId, global::Grpc.NewsDTO>(serviceImpl.GetNewById));
      serviceBinder.AddMethod(__Method_CreateNews, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.NewsDTO, global::Grpc.StringMessage>(serviceImpl.CreateNews));
      serviceBinder.AddMethod(__Method_UpdateNews, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.UpdateNewsDTO, global::Grpc.StringMessage>(serviceImpl.UpdateNews));
      serviceBinder.AddMethod(__Method_RemoveNews, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Grpc.NewsId, global::Grpc.StringMessage>(serviceImpl.RemoveNews));
    }

  }
}
#endregion