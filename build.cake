var sln = "MicroService.sln";
var apiProj = "src/MicroServiceApi/MicroServiceApi.csproj";
var webProj = "src/MIcroServiceWeb/MicroServiceWeb.csproj";

Task("Build").Does(() => {
    DotNetCoreBuild(sln);
});

Task("Run").Does(() => {
    DotNetCoreRun(apiProj);
});

Task("Run-Web").Does(() => {
    DotNetCoreRun(webProj);
});

var target = Argument("target", "default");
RunTarget(target);
