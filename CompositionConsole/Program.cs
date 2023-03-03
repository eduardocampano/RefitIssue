using System.Reflection;
using ComposerContract;

var assembly = Assembly.LoadFile(Path.Combine(Environment.CurrentDirectory, "../../../../RandomUser/bin/Debug/net7.0/RandomUser.dll"));
var composerType = assembly.GetTypes().Single(t => t.IsAssignableTo(typeof(IComposer)));
var instance = (IComposer)Activator.CreateInstance(composerType)!;
await instance.Compose();
