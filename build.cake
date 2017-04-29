var sln = "MicroService.sln";
var proj = "src/MicroServiceApi/MicroServiceApi.csproj";

Task("Build").Does(() => {
    DotNetCoreBuild(sln);
});

Task("Run").Does(() => {
    DotNetCoreRun(proj);
});

var target = Argument("target", "default");
RunTarget(target);
