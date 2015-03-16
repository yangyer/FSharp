namespace MvcFSharp.WebCore

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Routing
open System.Web.Optimization

// F# record type that can be used for creating route information
type Route = { 
  controller : string
  action : string
  id : UrlParameter }

// Represents the application and registers routes
type Global() =
  inherit System.Web.HttpApplication() 

  static member RegisterRoutes(routes:RouteCollection) =
    routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
    routes.MapRoute(
        "Default", // Route name
        "{controller}/{action}/{id}", // URL with parameters
        { controller = "Home"; action = "Index"; id = UrlParameter.Optional } // Parameter defaults
      )

  static member RegisterBundles(bundles:BundleCollection) =
    bundles.Add(ScriptBundle("~/bundles/jquery").Include([|"~/Scripts/jquery-{version}.js"|]))
    bundles.Add(ScriptBundle("~/bundles/jqueryval").Include([|"~/Scripts/jquery.validate*"|]))
    bundles.Add(ScriptBundle("~/bundles/modernizr").Include([|"~/Scripts/modernizr-*"|]))
    bundles.Add(ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"))
    bundles.Add(StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"))
    
      
  member x.Start() =
    AreaRegistration.RegisterAllAreas()
    Global.RegisterRoutes(RouteTable.Routes)
    Global.RegisterBundles(BundleTable.Bundles)
    