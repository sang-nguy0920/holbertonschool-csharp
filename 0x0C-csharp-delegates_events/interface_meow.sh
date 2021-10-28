

# Usage: ./interface_meow.sh <project_name> <task number>

# Example: ./interface_meow.sh 1-meow 1 

​

if [ $# -eq 2 ];

then

    project_name="$1".cs;

    task="$2"

    let prevQ=$task-1

    new='  <PropertyGroup>\n    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>';

    old='  <PropertyGroup>';

    dotnet new console -o $1;

    cd "$1";

    cp ../"$prevQ"-*/*_*.cs .;

    mv "$prevQ"*.cs $project_name;

    rm Program.cs

    sed -i "s@^$old@$new@" "$1".csproj;

    touch "$2"-main.cs

    sudo chmod u+x "$1".csproj;

    sudo chmod u+x "$2"-main.cs;

    

​

else

    echo "Example Usage: ./meow.sh 1-meow 1"

fi
