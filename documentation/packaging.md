\## Packaging



The GitHub Container Repository (GHCR) will be used to house the NuGet package for client consumption.  



1\. Create a GitHub Personal Access Token (PAT)

&nbsp;  1. Login to GitHub

&nbsp;  2. Select User -> Settings -> Developer Settings -> Personal access tokens -> Tokens (classic)

&nbsp;  3. select Generate new token -> Generate new token (classic)

&nbsp;  4. Give an identifiable description name

&nbsp;  5. Copy Token to be used below as GH\_PAT

&nbsp;  6. Add the GHCR reference to the local machine by running:

&nbsp;  dotnet nuget add source --username {GH\_USER} --password {GH\_PAT} --store-password-in-clear-text --name githubanddone "https://nuget.pkg.github.com/AndDone-LLC/index.json"



2\. Create Package and Push (command line)

&nbsp;  1. Open a Powershell window

&nbsp;  2. Create a new folder in the workspace folder of choice (ex: d:\\workspace\\anddone)

&nbsp;  ```sh

&nbsp;     cd d:\\workspace

&nbsp;     mkdir anddoneclientlibrary

&nbsp;  ```

&nbsp;  4. Change to the new folder

&nbsp;  ```sh

&nbsp;     cd anddoneclientlibrary

&nbsp;  ```

&nbsp;  5. Clone the repository

&nbsp;  ```sh

&nbsp;     git clone https://github.com/AndDone-LLC/AndDone-SecureAPI-ClientLibrary-DotNet-private.git

&nbsp;  ````

&nbsp;  6. Open nuget.config file in the Project root (AndDone-SecureAPI-ClientLibrary-DotNet-private\\src\\AndDoneSecureClientLibrary) and modify {GH\_USER} and {GH\_PAT}

&nbsp;  7. Verify the <RepositoryUrl> in .csproj file is correct

&nbsp;  8. Update the Version in .csproj as needed

&nbsp;  7. Navigate to AndDone-SecureAPI-ClientLibrary-DotNet-private\\src\\AndDoneSecureClientLibrary

&nbsp;     ```sh

&nbsp;     cd src\\AndDoneSecureClientLibrary

&nbsp;     ```

&nbsp;  9. Package the project to create the .nupkg file

&nbsp;     ```sh

&nbsp;     dotnet pack --configuration Release

&nbsp;     ```

&nbsp;  10. Push the package to GHCR

&nbsp;     ```sh

&nbsp;     dotnet nuget push "bin\\Release\\AndDoneSecureClientLibrary.1.0.0.nupkg" --api-key {GH\_PAT} --source "githubanddone" --skip-duplicate

&nbsp;     ```



3\. Create Package and Push (Visual Studio)

&nbsp;  1. Open a Powershell window

&nbsp;  2. Create a new folder in the workspace folder of choice (ex: d:\\workspace\\anddone)

&nbsp;  ```sh

&nbsp;     cd d:\\workspace

&nbsp;     mkdir anddoneclientlibrary

&nbsp;  ```

&nbsp;  4. Change to the new folder

&nbsp;  ```sh

&nbsp;     cd anddoneclientlibrary

&nbsp;  ```

&nbsp;  5. Clone the repository

&nbsp;  ```sh

&nbsp;     git clone https://github.com/AndDone-LLC/AndDone-SecureAPI-ClientLibrary-DotNet-private.git

&nbsp;  ````

&nbsp;  6. Open AndDoneSecureClientLibrary.sln

&nbsp;  7. Change the build configuration dropdown to Release

&nbsp;  4. Modify nuget.config file in Project root with {GH\_USER} and {GH\_PAT}

&nbsp;  5. Verify <RepositoryUrl> in the .csproj file is correct

&nbsp;  6. Update Version in the .csproj as needed

&nbsp;  7. Right click on Solution in Solution Explorer and Build Solution

&nbsp;  8. Right click on the Project in Solution Explorer and Pack 

&nbsp;  9. In the Powershell window

&nbsp;      ```sh

&nbsp;     cd AndDone-SecureAPI-ClientLibrary-DotNet-private\\src\\AndDoneSecureClientLibrary

&nbsp;     ```

&nbsp;  10. Push the package to GHCR

&nbsp;     ```sh

&nbsp;     dotnet nuget push "bin\\Release\\AndDoneSecureClientLibrary.1.0.0.nupkg" --api-key {GH\_PAT} --source "githubanddone" --skip-duplicate

&nbsp;     ```



4\. Associate Package to Repository

&nbsp;  1. In GitHub -> Select User -> Organizations

&nbsp;  2. Select AndDone-LLC

&nbsp;  3. Click Packages in top menu

&nbsp;  4. Click Package Name

&nbsp;  5. In right side, Click Package Settings

&nbsp;  6. Click Add Repository and select Repository for Package

&nbsp;  7. Verify by going to GitHub code page and the Package will be listed on the right side



