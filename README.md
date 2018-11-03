# csharp

installation

##### 1 .Install .NET Core 2.0 Runtime on Linux Ubuntu XX.XX x64
        https://www.microsoft.com/net/download/linux-package-manager/ubuntu16-04/runtime-2.0.6
        
        
##### 2 .Install mono complete on ubuntu  : compiler for c#
        sudo apt-get install mono-complete

##### 3 .compile
          mcs file_name.cs
          
  
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
