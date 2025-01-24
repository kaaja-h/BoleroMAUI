# BoleroMAUI

MAUI app with bolero blazor app

Used standard bolero-app template. Than splited Client project to twoo part
- BlazorWebAssembly (BoleroMAUI.Client)- only initializing services and runing razor app
- Razor part (BoleroMAUI.Shared) - all client logic
Than added MAUI app (BoleroMAUI) using BlazorWebView for shared part



What works
- windows app
- Android app
- remoting

Problems
- MAUI app is c#
- Make remoting url using some configuration not in file
- IOS app not tested (don't have iphone)
