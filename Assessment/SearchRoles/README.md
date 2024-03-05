http://localhost:5111/swagger/index.html

to deploy to a vm:

install the skd and runtime

wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x ./dotnet-install.sh
./dotnet-install.sh --version latest
./dotnet-install.sh --version latest --runtime aspnetcore
./dotnet-install.sh --channel 8.0

ls ~/.dotnet


echo $PATH


export PATH="$HOME/.dotnet:$PATH"


source ~/.bashrc

dotnet --version
