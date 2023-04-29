## Первый запуск
- Создать новый проект `dotnet new webapi`, 
  - `dotnet restore` для восстановления

## Добавление поддержки аутентификации и авторизации в проект
- Установить две библиотеки
  - `dotnet add package Microsoft.AspNetCore.Authentication.Certificate` \[[github](https://github.com/dotnet/aspnetcore) | [url](https://asp.net/)\]
  - `dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer` \[[github](https://github.com/dotnet/aspnetcore) [url](https://asp.net/)\]
- В файле [appsettings.json](./SecurityApi/appsettings.json) поменять `SecurityToken`

## Проверка
- Сделать POST-запрос на `$HOST$/api/Security/token`

придёт ответ вида
```
{
  "token": "eyJhbGciO...Uz8lNixMmo_HNYbRbw"
}
```

- любому запросу на `$HOST$/api/Workers/$Method$` нужно добавлять заголовок
  - `Authorization`: `Bearer eyJhbGciO...Uz8lNixMmo_HNYbRbw` 
- [postman json](./TokenSecurityAuthorize.postman_collection.json)

  