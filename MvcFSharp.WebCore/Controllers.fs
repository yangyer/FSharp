namespace MvcFSharp.WebCore.Controllers

open System
open System.Web.Mvc
open System.Reflection

[<HandleError>]
type HomeController() =
    inherit Controller()

    member self.Index() =
        self.View();

    member self.About() =
        let (?<-) (viewData:ViewDataDictionary) (name:string) (value:'T) =
            viewData.Add(name, box value)
        self.ViewData?Message <- "FSharp + MVC, o boy"
        self.View()

    member self.Contact() =
        let (?<-) (viewData:ViewDataDictionary) (name:string) (value:'T) =
            viewData.Add(name, box value)
        self.ViewData?Message <- "My Contact Page"
        self.View()