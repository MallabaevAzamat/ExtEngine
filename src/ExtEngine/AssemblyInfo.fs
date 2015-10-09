namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ExtEngine")>]
[<assembly: AssemblyProductAttribute("ExtEngine")>]
[<assembly: AssemblyDescriptionAttribute("small core for extensible project, similary for electron (base of atom-editor), but constructed on .net platform")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
