AspNetCoreMvcPaging
Приложение ASP.NET Core MVC с одной страницей, отображающей список товаров с пейджингом.

Технологии
ASP.NET Core 3.0
Entity Framework Core 3.0
Code First Migration
EntityFrameworkCore.SqlServer
mssqllocaldb
Razor Pages

Установка
Клонировать или скачать проект
Открыть ServerApp.sln в Visual Studio
Запустить из студии в конфигурации ServerApp
При первом запуске будет запущен скрипт начальной миграции и заполнение БД тестовыми данными в localdb.
localhost:5001 - страница списка товаров с пэйджингом
appsetting.development.json настройки:
  PageSize - размер страницы
  AdjecentPagesNum - количество отображаемых страниц до и после текущей в пэйджинге
localhost:5001/swagger - документация
