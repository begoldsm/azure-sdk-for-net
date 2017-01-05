::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
setlocal
set autoRestVersion=1.0.0-Nightly20170104
set source=-Source https://www.myget.org/F/autorest/api/v2

set accountSpecFile="https://raw.githubusercontent.com/Azure/azure-rest-api-specs/a19d0ffd09c9359a28abb953dc18767bdeacaa36/arm-datalake-store/account/2016-11-01/swagger/account.json"
set filesystemSpecFile="https://raw.githubusercontent.com/Azure/azure-rest-api-specs/a19d0ffd09c9359a28abb953dc18767bdeacaa36/arm-datalake-store/filesystem/2016-11-01/swagger/filesystem.json"

set repoRoot=%~dp0..\..\..\..
set generateFolder=%~dp0Generated

if exist %generateFolder% rd /S /Q  %generateFolder%

call "%repoRoot%\tools\autorest.gen.cmd" %accountSpecFile% Microsoft.Azure.Management.DataLake.Store %autoRestVersion% %generateFolder% 
call "%repoRoot%\tools\autorest.gen.cmd" %filesystemSpecFile% Microsoft.Azure.Management.DataLake.Store %autoRestVersion% %generateFolder% 

endlocal