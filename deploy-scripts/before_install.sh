sudo echo "before_install phase started..."
sudo echo "Installing dependencies..."

sudo echo "Installing .NET Core SDK..."
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0

sudo apt-get update
sudo apt-get install -y aspnetcore-runtime-8.0

sudo apt-get install -y dotnet-runtime-8.0

sudo echo "Installing Node..."
sudo apt install nodejs -y
sudo apt install npm -y
sudo npm install -g typescript -y

sudo apt-get install unzip -y

sudo echo "Installing Nginx"
sudo apt update 
sudo apt install nginx  -y

sudo chmod -R 777 "/var/www/appmanager/deploy-scripts"

sudo echo "Setting Nginx Configuration"

sudo mkdir -p "/etc/nginx/sites-available/"
sudo chmod -R 777 "/etc/nginx/sites-available/"

sudo mkdir -p "/etc/nginx/sites-enabled/"
sudo chmod -R 777 "/etc/nginx/sites-enabled/"

sudo mv -f "/var/www/appmanager/deploy-scripts/appmanager" "/etc/nginx/sites-available/appmanager"
sudo ln -sf "/etc/nginx/sites-available/appmanager" "/etc/nginx/sites-enabled/appmanager"

sudo mkdir -p "/var/www/"
sudo chmod -R 777 "/var/www/"


sudo mkdir -p "/App_Data"
sudo mkdir -p "/wwwroot"
  
