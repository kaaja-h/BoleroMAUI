// For more information see https://aka.ms/fsharp-console-apps
module BoleroWPF.Program

open System
open Bolero.Remoting.Client
open BoleroMAUI.Shared
open BoleroWPFApplication
open Microsoft.Extensions.DependencyInjection
[<EntryPoint;STAThread>]
let main args =
    let app = new MainApp<MyApp>()
    let serviceCollection = new ServiceCollection()
    serviceCollection.AddWpfBlazorWebView()|> ignore
    serviceCollection.AddBoleroRemoting(fun a -> a.BaseAddress <- new Uri("http://localhost:5005/") )|> ignore

    app.Init(serviceCollection.BuildServiceProvider()) |> ignore
    app.Run()
    
