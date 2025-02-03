# Mouse Capture API

Приложение для записи снимков координат мыши, полученных с HTML-страницы.

Ключевые проекты в решении:
* `Web` - Web API
* `UnitTests` - тесты

## Описание API

Приложение предоставляет доступ к ручке для записи снимков координат мыши, полученных с HTML-страницы.

### Captures
* `POST /api/v1/captures` - добавить снимки

## Установка и запуск

Необходимые зависимости:
* [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
* [EF Core CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) (для работы с миграциями)
* [Docker](https://www.docker.com/products/docker-desktop) (для запуска в контейнерах)

### Через dotnet

Убедитесь, что выбран нужный поставщик данных в [appsettings.json](src/Web/appsettings.json). Приложение поддерживает PostgreSQL.

Убедитесь, что база данных запущена и доступна.
Не забудьте указать строку подключения в [appsettings.json](src/Web/appsettings.json), например:

`Host=localhost;Port=5432;Database=capture;Username=capture;Password=capture`

Из корневой директории проекта:

```shell
dotnet run --project .\src\Web
```

### Через Docker

В проекте используется Docker Compose для запуска контейнеров с приложением и базой данных. Это рекомендуемый способ запуска.

Строка подключения к базе данных в [appsettings.json](src/Web/appsettings.json) уже настроена на использование Docker.

Убедитесь, что Docker запущен. Из корневой директории проекта:

```shell
docker compose up --build
```

Приложение будет доступно по адресу `http://localhost:5000`.

HTML-страница для тестирования API будет доступна по адресу `http://localhost:5000/index.html`.

### Тестирование

Из корневой директории проекта:

```shell
dotnet test
```

## Миграции

Миграция применится автоматически при запуске Web API. Для применения миграции вручную, выполните:

```shell
dotnet ef database update --project <MigrationProject> --startup-project src\Web\Web.csproj --context DataContext
```

В качестве `<MigrationProject>` используйте проект с миграциями, например:

`src\Data.Migrations.Psql\Data.Migrations.Psql.csproj`.

