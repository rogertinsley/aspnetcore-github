# GitHub OAuth Spike

Exploring ASP.NET CoreCLR

## Getting started

* ASP.NET RC1 installed according to the instructions in [http://docs.asp.net/en/latest/getting-started/installing-on-linux.html](http://docs.asp.net/en/latest/getting-started/installing-on-linux.html).

```
git clone https://github.com/rogertinsley/githubspike
cd aspnetcore-github
vagrant up
vagrant ssh
cd src/web
dnu restore
dnx web
```

Port forwarding from host:5000 to guest:5000.

**Note** that port forwarding will not work if the guest HTTP server listens on `localhost`. Change `project.json` to listen on `0.0.0.0` instead

```
"web": "Microsoft.AspNet.Server.Kestrel --server.urls http://0.0.0.0:5000"
```

You will need to install SecretManager via `dnu commands install Microsoft.Extensions.SecretManager`

```shell
cd /vagrant/src/Web/
user-secret set GitHubClientID <clientid>
user-secret set GitHubClientSecret <clientsecret>
```
