namespace BoleroMAUI.Shared

open System
open Elmish
open Bolero
open Bolero.Html
open Bolero.Remoting
open Bolero.Remoting.Client
open Bolero.Templating.Client

type MyApp() =
    inherit ProgramComponent<Main.Model, Main.Message>()

    //override _.CssScope = CssScopes.

    override this.Program =
        let bookService = this.Remote<Main.BookService>()
        let update = Main.update bookService
        Program.mkProgram (fun _ -> Main.initModel, Cmd.ofMsg Main.GetSignedInAs) update Main.view
        |> Program.withRouter Main.router
#if DEBUG
        |> Program.withHotReload
#endif

