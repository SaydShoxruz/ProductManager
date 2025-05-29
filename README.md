# ProductManager — WinForms CRUD App
Простое настольное приложение для управления списком товаров с поддержкой операций: добавление, редактирование, удаление и поиск.

## Функциональность
-  Просмотр всех товаров
-  Добавление нового товара
-  Редактирование выбранного товара
-  Удаление товара с подтверждением
-  Поиск по имени товара
-  Сохранение данных в базе

## Технологии
- .NET 8
- WinForms
- Entity Framework Core
- PostgreSQL
- LINQ
- C#

## Структура
- `MainForm.cs` — отображение списка и кнопки управления
- `ProductForm.cs` — модальное окно для добавления/редактирования товара
- `AppDbContext.cs` — контекст базы данных
- `Product.cs` — модель
- `AppService.cs` — Сервис приложения
- `Repositories` — репозитории для помощи с базой

## Настройка подключения
Файл `appsettings.json` содержит строку подключения:
```json
{
  "DefaultConnection": "Host=localhost;Port=5432;Database=products;Username=yourusername;Password=yourpassword"
}
