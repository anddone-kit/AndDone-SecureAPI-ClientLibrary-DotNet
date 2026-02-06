# AndDone Client Library - .NET - Packaging 

## Packaging

The GitHub Container Repository (GHCR) will be used to house the NuGet package for client consumption.  

1. Create a GitHub Personal Access Token (PAT)
   1. Login to GitHub
   2. Select User -> Settings -> Developer Settings -> Personal access tokens -> Tokens (classic)
   3. select Generate new token -> Generate new token (classic)
   4. Give an identifiable description name
   5. Copy Token to be used below as GH_PAT
   6. Add the GHCR reference to the local machine by running:
   dotnet nuget add source --username {GH_USER} --password {GH_PAT} --store-password-in-clear-text --name githubanddone "https://nuget.pkg.github.com/AndDone-LLC/index.json"

2. Create Package and Push (command line)
   1. Open a Powershell window
   2. Create a new folder in the workspace folder of choice (ex: d:\workspace\anddone)
   ```sh
      cd d:\workspace
      mkdir anddoneclientlibrary
   ```
   3. Change to the new folder
   ```sh
      cd anddoneclientlibrary
   ```
   4. Clone the repository
   ```sh
      git clone https://github.com/AndDone-LLC/AndDone-SecureAPI-ClientLibrary-DotNet-private.git
   ````
   5. Open nuget.config file in the Project root (AndDone-SecureAPI-ClientLibrary-DotNet-private\src\AndDoneSecureClientLibrary) and modify {GH_USER} and {GH_PAT}
   6. Verify the <RepositoryUrl> in .csproj file is correct
   7. Update the Version in .csproj as needed
   8. Navigate to AndDone-SecureAPI-ClientLibrary-DotNet-private\src\AndDoneSecureClientLibrary
      ```sh
      cd src\AndDoneSecureClientLibrary
      ```
   9. Package the project to create the .nupkg file
      ```sh
      dotnet pack --configuration Release
      ```
   10. Push the package to GHCR
      ```sh
      dotnet nuget push "bin\Release\AndDoneSecureClientLibrary.1.0.0.nupkg" --api-key {GH_PAT} --source "githubanddone" --skip-duplicate
      ```

3. Create Package and Push (Visual Studio)
   1. Open a Powershell window
   2. Create a new folder in the workspace folder of choice (ex: d:\workspace\anddone)
   ```sh
      cd d:\workspace
      mkdir anddoneclientlibrary
   ```
   3. Change to the new folder
   ```sh
      cd anddoneclientlibrary
   ```
   4. Clone the repository
   ```sh
      git clone https://github.com/AndDone-LLC/AndDone-SecureAPI-ClientLibrary-DotNet-private.git
   ````
   5. Open AndDoneSecureClientLibrary.sln
   6. Change the build configuration dropdown to Release
   7. Modify nuget.config file in Project root with {GH_USER} and {GH_PAT}
   8. Verify <RepositoryUrl> in the .csproj file is correct
   9. Update Version in the .csproj as needed
   10. Right click on Solution in Solution Explorer and Build Solution
   11. Right click on the Project in Solution Explorer and Pack 
   12. In the Powershell window
   ```sh
      cd AndDone-SecureAPI-ClientLibrary-DotNet-private\src\AndDoneSecureClientLibrary
   ```
   13. Push the package to GHCR
   ```sh
      dotnet nuget push "bin\Release\AndDoneSecureClientLibrary.1.0.0.nupkg" --api-key {GH_PAT} --source "githubanddone" --skip-duplicate
   ```

4. Associate Package to Repository
   1. In GitHub -> Select User -> Organizations
   2. Select AndDone-LLC
   3. Click Packages in top menu
   4. Click Package Name
   5. In right side, Click Package Settings
   6. Click Add Repository and select Repository for Package
   7. Verify by going to GitHub code page and the Package will be listed on the right side



