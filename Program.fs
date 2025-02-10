open System.Threading

[<EntryPoint>]
let main _argv =
    printfn "Hijack success..."
    Thread.Sleep(1000) // Wait for 1 second
    0 // Exit code
