# NewsParser
Перед тем как начать этот проект:
1. Не забудьте поменять строку подключения к базе данных на ваше в файле appsettings.json
2. Приложения использует миграции. Откройте командную строку разработчика Visual Studio 2019 либо терминал в Rider или Visual studio code и введите следующие команды:
    *dotnet ef migrations add имя_миграции
    *dotnet ef database update
    PS:Не рекомендую использовать командную строку диспетчера пакетов, у неё есть очень неприятный баг связанный с deps.json.
3. Приложение парсит сайт nur.kz один раз при миграции и сохраняет в базу данных первые 30 постов(по 10 постов из 3 категорий), и больше не обновляет контент.
