#!/bin/bash

# Очищаємо проект
dotnet clean

# Відновлюємо залежності
dotnet restore

# Будуємо проект
dotnet build

# Запускаємо проект
dotnet run

# Запускаємо тести
dotnet test

