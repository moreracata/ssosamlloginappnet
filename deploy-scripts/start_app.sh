
sudo echo "start_install phase started..."
sudo echo "Restarting application service"

sudo systemctl stop "webapi.service"
sudo systemctl enable  "webapi.service"
sudo systemctl start "webapi.service"

sudo service nginx restart