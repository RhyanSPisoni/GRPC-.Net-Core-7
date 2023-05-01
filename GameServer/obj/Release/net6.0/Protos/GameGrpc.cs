// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/game.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GameServer.Protos {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class GameService
  {
    static readonly string __ServiceName = "game.GameService";

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
    static readonly grpc::Marshaller<global::GameServer.Protos.GetGameRequest> __Marshaller_game_GetGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GameServer.Protos.GetGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GameServer.Protos.GameResponse> __Marshaller_game_GameResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GameServer.Protos.GameResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GameServer.Protos.NewGameRequest> __Marshaller_game_NewGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GameServer.Protos.NewGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GameServer.Protos.PutGameRequest> __Marshaller_game_PutGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GameServer.Protos.PutGameRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GameServer.Protos.DeleteGameRequest> __Marshaller_game_DeleteGameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GameServer.Protos.DeleteGameRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GameServer.Protos.GetGameRequest, global::GameServer.Protos.GameResponse> __Method_GetGame = new grpc::Method<global::GameServer.Protos.GetGameRequest, global::GameServer.Protos.GameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGame",
        __Marshaller_game_GetGameRequest,
        __Marshaller_game_GameResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GameServer.Protos.NewGameRequest, global::GameServer.Protos.GameResponse> __Method_NewGame = new grpc::Method<global::GameServer.Protos.NewGameRequest, global::GameServer.Protos.GameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewGame",
        __Marshaller_game_NewGameRequest,
        __Marshaller_game_GameResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GameServer.Protos.PutGameRequest, global::GameServer.Protos.GameResponse> __Method_PutGame = new grpc::Method<global::GameServer.Protos.PutGameRequest, global::GameServer.Protos.GameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PutGame",
        __Marshaller_game_PutGameRequest,
        __Marshaller_game_GameResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GameServer.Protos.DeleteGameRequest, global::GameServer.Protos.GameResponse> __Method_DeleteGame = new grpc::Method<global::GameServer.Protos.DeleteGameRequest, global::GameServer.Protos.GameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteGame",
        __Marshaller_game_DeleteGameRequest,
        __Marshaller_game_GameResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GameServer.Protos.GameReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GameService</summary>
    [grpc::BindServiceMethod(typeof(GameService), "BindService")]
    public abstract partial class GameServiceBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GameServer.Protos.GameResponse> GetGame(global::GameServer.Protos.GetGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GameServer.Protos.GameResponse> NewGame(global::GameServer.Protos.NewGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GameServer.Protos.GameResponse> PutGame(global::GameServer.Protos.PutGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GameServer.Protos.GameResponse> DeleteGame(global::GameServer.Protos.DeleteGameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GameServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGame, serviceImpl.GetGame)
          .AddMethod(__Method_NewGame, serviceImpl.NewGame)
          .AddMethod(__Method_PutGame, serviceImpl.PutGame)
          .AddMethod(__Method_DeleteGame, serviceImpl.DeleteGame).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GameServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GameServer.Protos.GetGameRequest, global::GameServer.Protos.GameResponse>(serviceImpl.GetGame));
      serviceBinder.AddMethod(__Method_NewGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GameServer.Protos.NewGameRequest, global::GameServer.Protos.GameResponse>(serviceImpl.NewGame));
      serviceBinder.AddMethod(__Method_PutGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GameServer.Protos.PutGameRequest, global::GameServer.Protos.GameResponse>(serviceImpl.PutGame));
      serviceBinder.AddMethod(__Method_DeleteGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GameServer.Protos.DeleteGameRequest, global::GameServer.Protos.GameResponse>(serviceImpl.DeleteGame));
    }

  }
}
#endregion