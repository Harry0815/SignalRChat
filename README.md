SignalRChat

Testen der Signal R Funktionalität

Erstellen der .NET Applikkation
dotnet new webapp -o SignalRChat

Aufruf mit VS Code
code -r SignalRChat

oder aber über Solution Explorer im VS Code direkt


LibMan ersetzen und neu installieren
dotnet tool uninstall -g Microsoft.Web.LibraryManager.Cli
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

SignalR Client JS Scripte installieren
libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.js



