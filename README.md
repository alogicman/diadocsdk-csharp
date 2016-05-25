             | Build Status
-------------|--------------
master       | [![Build status (master)](https://ci.appveyor.com/api/projects/status/mfypanwf6t25akud/branch/master?svg=true)](https://ci.appveyor.com/project/halex2005/diadocsdk-csharp/branch/master)
lastest      | [![Build status (lastest)](https://ci.appveyor.com/api/projects/status/mfypanwf6t25akud?svg=true)](https://ci.appveyor.com/project/halex2005/diadocsdk-csharp)

# diadocsdk-charp

diadocsdk-csharp является официальной C#-реализацией клиента, использующего [публичный API Диадока](http://api-docs.diadoc.ru/).

## Сборка проекта

Для окончательной сборки проекта используется утилита [Cake](http://cakebuild.net/).

Запуск powershell-скрипта `build.ps1` скачает утилиту Cake, если ее у вас нет, и запустит сборку проекта.
Из командной строки этот скрипт можно запустить с помощью `generate.bat`.

Выполняется:

- генерация версии на основе тега github
- генерация C#-кода из proto-файлов
- ILMerge (сборка protobuf-net включается в DiadocApi)
- подписание сборки строгим именем
- создание nuget-пакета