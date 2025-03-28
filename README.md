# WPF-приложение: Импорт и визуализация объектов

## 📌 Описание

Приложение на WPF, выполненное в рамках тестового задания. Позволяет импортировать данные об объектах из CSV и Excel-файлов, отображать их в таблице и визуализировать на прямоугольной схеме размером 20×12 условных единиц (м/ч).

---

## ⚙️ Функциональность

- ✅ Импорт данных из файлов:
  - CSV (`;` — разделитель)
  - Excel (`.xls`/`.xlsx`)
- ✅ Таблица с редактируемыми строками
- ✅ Вывод детальной информации о выбранной строке
- ✅ Отображение объектов в виде прямоугольников на `Canvas`
- ✅ Реакция на изменение данных в таблице (автоматическая перерисовка)
- ✅ Поддержка резиновой вёрстки (адаптивный Canvas)

---

## 🧾 Формат данных

Каждая строка файла содержит:
- **Название** объекта
- **Горизонтальная координата (м)** — от `0` до `20`
- **Вертикальная координата (ч)** — от `0` до `12`
- **Ширина (м)** — от `0` до `20`
- **Высота (ч)** — от `0` до `12`
- **Дефект** — `да` / `yes` для дефектов

---

## 🖥️ Интерфейс

- Слева: таблица с возможностью редактирования
- Справа: блок с информацией о выбранном объекте и схема с отрисованными прямоугольниками
- Снизу: кнопки импорта

---

## 🚀 Запуск

1. Открыть решение `testovoe.sln` в Visual Studio
2. Установить зависимости (в частности, пакет `ClosedXML`)
3. Запустить проект

---

## 🧪 Пример тестовых файлов

Папка `test` содержит:
- `objects.csv`
- `Objects.xlsx`

Можно использовать их для проверки импорта и отображения.

---

## 🗂 Структура проекта

- `Item.cs` — модель объекта
- `DrawingService.cs` — логика отрисовки на Canvas
- `ImportService.cs` — парсинг CSV/Excel
- `MainWindow.xaml` — визуальное представление
- `MainWindow.xaml.cs` — основная логика и взаимодействие

---

## ☁️ Сборка

Собранный `.exe` и примеры файлов доступны по ссылке:

👉 [Скачать с Google Диска](https://drive.google.com/file/d/1LqOgQUZeMNOJlnqZukUaro11bKv4Dj8F/view?usp=sharing)

---

## 🔖 Примечание

Проект реализован без использования сторонних MVVM-фреймворков (например, Prism), но архитектурно разбит на слои: модель, сервисы, представление.

---

## 📬 Контакты

Если возникнут вопросы — [renzhinan2001@gmail.com](mailto:renzhinan2001@gmail.com).
