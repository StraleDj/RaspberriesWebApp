@ECHO OFF

REM ***Skripta za pokretanje aplikacije***

SET APP_DIR=%~dp0bin\Debug\
SET APP_NAME=RaspberryWebApp.WebAPI.exe

START "" %APP_DIR%%APP_NAME%
START chrome "http://localhost:8989/index.html"

PAUSE