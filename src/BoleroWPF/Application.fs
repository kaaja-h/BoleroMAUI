namespace BoleroWPFApplication

open System.Windows;
open System.Windows.Controls;
open System.Windows.Media;
open System.Windows.Ink
open Microsoft.AspNetCore.Components.WebView.Wpf


type MainApp<'T>()=
    inherit Application()
    
    let root = new Window()
    let blazor =     BlazorWebView()
        
    member this.Init(services )=
        root.Show()
        root.ResizeMode <- ResizeMode.CanResizeWithGrip
        let grid = Grid()
        blazor.HostPage <- "wwwroot\index.html"
        blazor.Services <- services
        let rootComponent = RootComponent()
        rootComponent.Selector<-"#app"
        rootComponent.ComponentType <- typeof<'T>
        blazor.RootComponents.Add(rootComponent)
        grid.Children.Add(blazor) |> ignore
        
        root.Content <- grid       
        base.MainWindow <- root
        base.MainWindow.Closed.Add( fun x -> this.Shutdown(0))
        ()