using GameServer;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7123");
var client1 = new Greeter.GreeterClient(channel);
var response = await client1.SayHelloAsync(new HelloRequest() { Name = "Bill" });

Console.WriteLine(response);
Console.ReadLine();