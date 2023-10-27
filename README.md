# csharp

#### install on ubuntu with vs code

        https://www.youtube.com/watch?v=WeTesTCzep0

installation

##### 1 .Install .NET Core 2.0 Runtime on Linux Ubuntu XX.XX x64
        https://www.microsoft.com/net/download/linux-package-manager/ubuntu16-04/runtime-2.0.6
        
        
##### 2 .Install mono complete on ubuntu  : compiler for c#
        sudo apt-get install mono-complete
        
        
                -- or --
                
        https://www.mono-project.com/download/stable/    : skip 1

        https://dotnet.microsoft.com/download/linux-package-manager/ubuntu18-04/sdk-current

        https://en.wikipedia.org/wiki/Mono_(software)
        
##### 3 .compile
          mcs file_name.cs
          --or--
          csc file_name.cs
          --choosing latest compiler ---
          csc -langversion:latest file_name.cs
                
#### 3.1 list of available compiler version         

                csc -langversion:?
          
          output : 
                  1
                2
                3
                4
                5
                6
                7.0 (default)
                7.1
                7.2
                7.3 (latest)
                latest
  
##### 4 .running the program
          mono file_name.exe   


##### 5. check c#
              dotnet --info
              
              
              
#### upgrade mono compiler on ubuntu
      https://www.mono-project.com/download/stable/
      
      sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
                sudo apt install apt-transport-https
                echo "deb https://download.mono-project.com/repo/ubuntu stable-xenial main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
                sudo apt update

                sudo apt install mono-devel
                
#### dotnet new

                prints what type of projects can be created using dotnet command
                webapi for rest api, dotnet uses open api(check path)
                after creating project, build and run
                check swagger : 
                http://localhost:5157/swagger/index.html

#### references : 

                        https://github.com/dotnet/training-tutorials/blob/master/content/csharp/getting-started/README.md
                        https://github.com/neo-project/examples-csharp
                        https://github.com/la-yumba/functional-csharp-code/tree/master/Examples
                        https://github.com/AllAlgorithms/csharp
                        https://github.com/benperk/BeginningCSharp7
                        https://zetcode.com
                        https://www.youtube.com/playlist?list=PL0eyrZgxdwhxD9HhtpuZV22KxEJAZ55X-
                        https://programmingwithmosh.com/net/csharp-6-features-that-help-you-write-cleaner-code/
