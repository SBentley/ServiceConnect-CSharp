SET OUTDIR=C:\Git\ServiceConnect\src\

@ECHO === === === === === === === ===

@ECHO ===NUGET Publishing ....

del *.nupkg

:: comment

::NuGet pack "%OUTDIR%ServiceConnect\ServiceConnect.nuspec"
NuGet pack "%OUTDIR%ServiceConnect.Client.RabbitMQ\ServiceConnect.Client.RabbitMQ.nuspec"
::NuGet pack "%OUTDIR%ServiceConnect.Interfaces\ServiceConnect.Interfaces.nuspec"
::NuGet pack "%OUTDIR%ServiceConnect.Container.StructureMap\ServiceConnect.Container.StructureMap.nuspec"
::NuGet pack "%OUTDIR%ServiceConnect.Persistance.MongoDb\ServiceConnect.Persistance.MongoDb.nuspec"
::NuGet pack "%OUTDIR%ServiceConnect.Persistance.MongoDbSsl\ServiceConnect.Persistance.MongoDbSsl.nuspec"
::NuGet pack "%OUTDIR%ServiceConnect.Container.Ninject\ServiceConnect.Container.Ninject.nuspec"


::nuget push ServiceConnect.3.0.2.nupkg -Source https://www.nuget.org/api/v2/package
nuget push ServiceConnect.Client.RabbitMQ.3.0.5.nupkg -Source https://www.nuget.org/api/v2/package
::nuget push ServiceConnect.Interfaces.3.0.2.nupkg -Source https://www.nuget.org/api/v2/package
::nuget push ServiceConnect.Container.StructureMap.3.0.0.nupkg
::nuget push ServiceConnect.Persistance.MongoDb.3.0.0.nupkg
::nuget push ServiceConnect.Persistance.MongoDbSsl.3.0.1.nupkg -Source https://www.nuget.org/api/v2/package
::nuget push ServiceConnect.Container.Ninject.3.0.0.nupkg           

@ECHO === === === === === === === ===

PAUSE
