# GTPSLauncher
This app allow you, play Growtopia Private Server without changing Hosts for PC

Dont Forget to Star This Repository

GTPSLauncher Need
- Visual Basic 2010
- If you have Visual Studio, You No Need to download Visual Basic 2010
- No work with visual studio code (maybe, just try)
## How to use
1. Download GTPSLauncher
2. Extract GTPSLauncher
3. Open Folder GuckProject
4. Open GuckProject.vbproj
5. If Say "Dont Edit" Please dont edit
## Features
- Turn ON/OFF Button
- UP/DOWN Server Checker

## How to use Server UP/DOWN Checker

1. You need to install XAMPP to your VPS
2. Checklist MySQL and Apache
3. Turn on MySQL and Apache
4. Goto XAMPP Folder
5. Goto htdocs folder
6. Create name folder "status" (Without ")
7. Create name file "server.txt" (Without ")
8. Open server.txt and make text
- Example
```
GTKZ Server is UP
```
9. Save server.txt
10. Edit this
```
My.Computer.Network.DownloadFile("http://IPVPS/PATH/NAME.TXT"
```
To this
```
My.Computer.Network.DownloadFile("http://IPGTPS/status/server.txt"
```

And then done
## Note
If you find This:
```
My.Computer.Network.DownloadFile("http://IPVPS/PATH/NAME.TXT", "C:\Server\Changelog.txt")
```
Please dont remove http:// or https://, if you remove http:// or https://, this application will not running properly
