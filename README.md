# Parcial N.° 2 - Herramientas de Programación Aplicada III

## Objetivo

Desarrollar una aplicación de escritorio en C# utilizando el patrón de diseño Model View Presenter (MVP), permitiendo la autenticación de usuarios mediante una base de datos MySQL y el uso de algoritmos hash para la protección de contraseñas. Además, implementar una interfaz gráfica basada en Windows Forms con navegación tipo MDI y un módulo funcional para el juego de Craps.

---

## Requisitos Previos

| Tecnología | Versión / Tipo |
| :--- | :--- |
| **Lenguaje** | C# |
| **Framework** | .NET Framework |
| **Entorno de Desarrollo** | Microsoft Visual Studio Community |
| **Base de Datos** | MySQL Workbench 8.0 |
| **Arquitectura** | MVP (Model View Presenter) |
| **Conector** | MySql.Data |
| **Control de Versiones** | Git & GitHub |

---

## Estructura del Proyecto

| Proyecto | Función |
| :--- | :--- |
| **MVP_Entidades** | Contiene las entidades del sistema |
| **MVP_Datos** | Gestiona la conexión y consultas a MySQL |
| **MVP_Negocio** | Implementa la lógica del negocio y servicios Hash |
| **MVP_Presentacion** | Contiene la interfaz gráfica basada en Windows Forms |

---

## Instalación y Ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/TU-USUARIO/Parcial2-HPA3.git
```

### 2. Abrir la solución

Abrir el archivo:

```text
ParcialN2_MVP.sln
```

utilizando Microsoft Visual Studio.

### 3. Configurar la Base de Datos

```sql
CREATE DATABASE parcial_mvp;

USE parcial_mvp;

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    passwordHash VARCHAR(255) NOT NULL
);
```

### 4. Ejecutar la Aplicación

Seleccionar el proyecto:

```text
MVP_Presentacion
```

como proyecto de inicio y ejecutar con:

```text
F5
```

---

## Funcionalidades Implementadas

### Autenticación de Usuarios

- Inicio de sesión mediante usuario y contraseña
- Verificación de credenciales almacenadas en MySQL
- Uso de SHA-256 para el manejo seguro de contraseñas
- Implementación de interfaces:
  - `IHashService`
  - `IVerificarHashService`
- Patrón MVP aplicado al proceso de autenticación.

### Menú Principal

- Menú lateral de navegación
- Hora actual actualizada mediante Timer
- Usuario autenticado visible en la parte inferior
- Carga dinámica de formularios dentro del panel principal

### Juego de Craps

- Generación aleatoria de dados
- Implementación de reglas oficiales del juego Craps
- Visualización del punto obtenido
- Validación automática de victoria, derrota o continuidad

---

## Controles Utilizados

| Control | Uso |
| :--- | :--- |
| **Form** | Ventanas principales y secundarias |
| **Label** | Mostrar información al usuario |
| **TextBox** | Captura de usuario y contraseña |
| **Button** | Navegación y ejecución de acciones |
| **Panel** | Organización visual de la interfaz |
| **Timer** | Actualización de la hora |
| **PictureBox** | Elementos gráficos de apoyo |

---

## Validaciones Implementadas

- Verificación de campos vacíos
- Validación de usuario existente
- Validación de contraseña incorrecta
- Verificación mediante Hash SHA-256
- Acceso restringido al menú principal para usuarios autenticados

---

## Resultados

### 1. Validaciones del Sistema

#### Validación de Campos Vacíos

**Descripción:** El sistema impide el acceso cuando alguno de los campos requeridos no contiene información.

**Resultado:**

<img width="547" height="341" alt="image" src="https://github.com/user-attachments/assets/5d3567c2-a615-4f60-88c6-58c2f9042283" />

---

#### Validación de Contraseña Incorrecta

**Descripción:** El sistema informa cuando la contraseña ingresada no coincide con el hash almacenado en la base de datos.

**Resultado:**

<img width="561" height="325" alt="image" src="https://github.com/user-attachments/assets/7c58cfdf-15ee-4422-9d03-e340dfe2cbf4" />

---

### 2. Interfaz Principal (MDI)

#### Menú Principal

**Descripción:** Formulario principal con menú lateral, hora actual y usuario autenticado.

**Resultado:**

<img width="720" height="395" alt="image" src="https://github.com/user-attachments/assets/d5cd0681-7305-4a75-83d0-12451bfb3425" />

---

#### Navegación entre Formularios

**Descripción:** El sistema permite cargar formularios secundarios dentro del panel principal mediante los botones de navegación.

**Resultado:**

<img width="723" height="401" alt="image" src="https://github.com/user-attachments/assets/ac143b84-ba12-46ab-a34d-10c661cf8226" />

---

### 3. Juego de Craps

#### Desarrollo del Juego

**Descripción:** Implementación gráfica del lanzamiento de dados y cálculo del punto.

**Resultado:**

<img width="795" height="435" alt="image" src="https://github.com/user-attachments/assets/c456474c-0061-44f2-b365-1d187d429b75" />


---

#### Resultado del Juego

**Descripción:** El sistema determina automáticamente si el jugador gana, pierde o continúa jugando según las reglas establecidas.

**Resultado:**

<img width="1122" height="610" alt="image" src="https://github.com/user-attachments/assets/1a6fc35a-abe4-4cd3-8ed6-1d3d34de7439" />

---

## Componentes Principales

| Clase | Función |
| :--- | :--- |
| `E_Usuario` | Representa un usuario del sistema |
| `D_Conexion` | Gestiona la conexión a MySQL |
| `D_Usuario` | Consultas relacionadas con usuarios |
| `N_Usuario` | Procesa la autenticación |
| `IHashService` | Contrato para generar hash |
| `IVerificarHashService` | Contrato para verificar hash |
| `HashService` | Implementación SHA-256 |
| `ILoginView` | Contrato de la Vista |
| `LoginPresenter` | Lógica de presentación MVP |
| `FrmLogin` | Pantalla de autenticación |
| `FrmPrincipal` | Interfaz principal del sistema |
| `FrmCraps` | Módulo del juego Craps |

---

## Tecnologías Utilizadas

- C#
- .NET Framework
- Windows Forms
- MySQL Workbench 8.0
- MySql.Data
- SHA-256
- MVP (Model View Presenter)
- Git
- GitHub

---

## Fecha de Ejecución

09 de noviembre de 2026

| Datos del Estudiante | Detalles |
| :--- | :--- |
| **Nombre** | Greisy Coronado |
| **Curso** | Herramientas de Programación Aplicada III |
| **Instructor** | Ing. Irina Fong |
| **Proyecto** | Parcial N.° 2 MVP |
| **Repositorio** | Parcial2_HPA3 |
