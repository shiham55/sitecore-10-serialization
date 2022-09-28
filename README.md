# Project for Sitecore Demos

todo: project intro

#### Setup instructions

##### Prerequists 

- Clone the project 
- Install Sitcore 10.2 locally
  - CM : https://sitecoredemossc.dev.local/sitecore/
  - ID : https://sitecoredemosidentityserver.dev.local/
- Install Sitecore Management Services Module in Sitecore instance

##### Configuration
- Open command prompt from project root
- Run command \
	`dotnet sitecore login --authority https://sitecoredemosidentityserver.dev.local/ --cm https://sitecoredemossc.dev.local --allow-write true`
 
