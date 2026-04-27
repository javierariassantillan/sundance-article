# Sundance Article Project

## 📌 Descripción
Aplicación web que muestra artículos tipo blog consumiendo una API REST.

Arquitectura desacoplada:
- Frontend en Vue 3 (Vite)
- Backend en .NET Core

## 🧠 Arquitectura
- Separación de responsabilidades (componentes Vue)
- Service layer (`articleService.js`) para consumo de API
- Backend expone endpoint REST

## ⚙️ Tecnologías
- Vue 3 + Vite
- JavaScript
- .NET Core Web API

## 🚀 Ejecución

### Backend
cd backend
dotnet run

### Frontend
cd frontend
npm install
npm run dev

## 🔗 Endpoint
http://localhost:5082/api/article
