#!/usr/bin/env bash

# install dnvm pre-requisites
sudo apt-get install -y unzip curl

# install dnvm
curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh

# install dnx pre-requisites
sudo apt-get install -y libunwind8 gettext libssl-dev libcurl4-openssl-dev zlib1g libicu-dev uuid-dev

# install dnx via dnvm
dnvm upgrade -r coreclr

# install libuv from source
sudo apt-get install -y make automake libtool curl
curl -sSL https://github.com/libuv/libuv/archive/v1.4.2.tar.gz | sudo tar zxfv - -C /usr/local/src
cd /usr/local/src/libuv-1.4.2
sudo sh autogen.sh
sudo ./configure
sudo make
sudo make install
sudo rm -rf /usr/local/src/libuv-1.4.2 && cd ~/
sudo ldconfig

# install git
sudo apt-get -y install git

# install http://hub.github.com
wget https://github.com/github/hub/releases/download/v2.2.3/hub-linux-amd64-2.2.3.tgz
tar xvf hub-linux-amd64-2.2.3.tgz
cd hub-linux-amd64-2.2.3
chmod +x install
sudo ./install

# install node and npm
curl -sL https://deb.nodesource.com/setup_0.12 | sudo bash -
sudo apt-get install -y nodejs
sudo npm install -g npm

# install yo and generator-aspnet
sudo npm install -g yo generator-aspnet

# sit back, relax and let the good times roll
apt-get moo
