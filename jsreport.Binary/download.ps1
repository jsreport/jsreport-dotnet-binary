﻿[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
(new-object System.Net.WebClient).DownloadFile('https://github.com/jsreport/jsreport/releases/download/4.3.1/jsreport-win.zip','jsreport.zip')
