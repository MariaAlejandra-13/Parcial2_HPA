# Universidad Tecnológica de Panamá

# Facultad de Ingeniería de Sistemas Computacionales

## Parcial #2 - Programación en Capas, Conexiones e Inicio de Sesión

### Herramientas de Programación Aplicada III

## Fecha de Ejecución: 08/11/2026

---

## Objetivos

- Desarrollar un sistema de inicio de sesión en C# con Windows Forms y SQL Server.
- Organizar la solución en las capas de Entidades, Datos, Negocio y Presentación.
- Aplicar el patrón Modelo–Vista–Presentador (MVP) al flujo de autenticación.
- Implementar dos interfaces independientes para generar y verificar el hash de una contraseña.
- Configurar una conexión a SQL Server con una cuenta dedicada y comprobar sus permisos.
- Mostrar un menú lateral, un reloj en tiempo real y los datos del usuario autenticado.
- Presentar en un `DataGridView` los productos que alcanzaron o quedaron por debajo del stock mínimo.

---

## Introducción

En este parcial se desarrolló una aplicación de escritorio que valida el acceso de usuarios registrados en SQL Server. La solución utiliza programación en capas para separar la interfaz gráfica, las reglas de autenticación y las consultas a la base de datos. Dentro de Presentación, el patrón MVP permite que el formulario notifique una solicitud de ingreso al presentador, que coordina la validación y devuelve el resultado a la vista.

Cuando se aprueba el acceso, la aplicación abre una ventana principal con un menú lateral izquierdo, un área de sumario y una cuadrícula de productos bajo stock. La hora y la fecha se actualizan mediante un temporizador. Al pie de la barra lateral se muestran el usuario y el correo asociados a la sesión iniciada.

---

## Requisitos Previos

### Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| C# y .NET 10 | Desarrollo de la aplicación y sus bibliotecas de clases. |
| Windows Forms | Diseño del formulario de inicio de sesión y de la ventana principal. |
| Visual Studio Community | Edición, compilación y ejecución de la solución. |
| SQL Server Express 2022 | Almacenamiento de datos y ejecución de procedimientos almacenados. |
| SQL Server Management Studio 2022 | Administración de la base, pruebas de consultas, exportación y respaldo. |
| `Microsoft.Data.SqlClient` | Conexión de la aplicación con SQL Server. |
| `System.Configuration.ConfigurationManager` | Lectura de la configuración de conexión. |
| Git y GitHub | Control de versiones y publicación del código fuente. |

### Sistema Operativo

- Windows con el SDK de .NET 10 y las herramientas de desarrollo de escritorio de .NET instaladas.

---

## Contenido del Repositorio

El repositorio contiene la solución de Visual Studio, los proyectos de la aplicación, los recursos de los formularios, las evidencias de ejecución y los archivos de la base de datos.

| Proyecto o carpeta | Contenido |
|---|---|
| `Entidades` | Clase `E_Usuario`, que representa el registro recuperado de SQL Server. |
| `Datos` | `D_Conexion`, `D_Usuario` y `D_Producto`, responsables de la conexión y las consultas. |
| `Negocio` | Validación del usuario, consulta de productos bajo stock y servicios de hash. |
| `Presentacion` | Formularios, archivos del Designer, recursos gráficos, `ILoginView` y `LoginPresenter`. |
| `database/` | Exportación SQL y respaldo completo de la base de datos. |


### Archivos de la Base de Datos

| Archivo | Contenido |
|---|---|
| `database/HPA_Capas_Login_Final.sql` | Script de exportación con estructura y datos de la base. |
| `database/HPA_Capas_Login_Final.bak` | Copia de seguridad completa para restaurar en SQL Server. |

### Instrucciones de Ejecución

1. Clonar o descargar el repositorio.
2. En SSMS, restaurar `HPA_Capas_Login_Final.bak` o preparar la base en una instancia de prueba con `HPA_Capas_Login_Final.sql`. Si el script contiene rutas de archivos de la instancia original, ajustarlas antes de ejecutarlo.
3. Crear o vincular en la instancia de destino la cuenta dedicada a la aplicación. Concederle permiso `EXECUTE` sobre los procedimientos de inicio de sesión y de consulta de productos bajo stock.
4. Abrir la solución `.sln` en Visual Studio Community y restaurar los paquetes NuGet.
5. En `Presentacion/App.config`, configurar la entrada `ConexionHPA` con la instancia, el nombre de la base y las credenciales locales de conexión. Mantener la contraseña de SQL Server fuera del repositorio.
6. Establecer `Presentacion` como proyecto de inicio y presionar **F5**.
7. Para la demostración, ingresar con el usuario de la aplicación `admin` y la contraseña `123456`, si se conservaron los datos de prueba.

La cuenta de SQL Server se configura en la cadena de conexión. El usuario `admin` de la demostración se escribe en el formulario y corresponde a un registro de `dbo.usuarios`.

---

# Problema #1 - Inicio de Sesión con el Patrón MVP

## Descripción

El formulario `FrmLogin` solicita un nombre de usuario y una contraseña. La aplicación comprueba que los campos estén completos y verifica que el usuario exista, esté activo y tenga una contraseña que coincida con el hash almacenado.

### Controles utilizados

- `Label` para identificar los campos de entrada.
- `TextBox` para escribir el usuario y la contraseña. El campo de contraseña oculta los caracteres.
- `Button` para solicitar el inicio de sesión.
- `MessageBox` para mostrar el resultado de una validación.

### Funcionamiento

1. El usuario completa los campos y presiona **Iniciar sesión**.
2. `FrmLogin`, mediante el contrato `ILoginView`, notifica a `LoginPresenter` que se solicitó un ingreso.
3. `LoginPresenter` llama a `N_Usuario` para validar las credenciales.
4. `N_Usuario` solicita el registro a `D_Usuario`, comprueba su estado y verifica la contraseña.
5. Si la validación es correcta, la vista confirma el ingreso y el programa abre `FrmPrincipal`. Si se rechaza, el formulario permanece abierto y muestra el mensaje correspondiente.

## Resultado - Problema #1

El formulario presenta los campos necesarios para solicitar el acceso.

<img width="562" height="387" alt="image" src="https://github.com/user-attachments/assets/3d8971e8-a552-4b9a-9cbf-1ddd01cb2141" />


La siguiente prueba muestra la respuesta del sistema ante una contraseña incorrecta.

<img width="560" height="380" alt="image" src="https://github.com/user-attachments/assets/f53fdde7-bb77-4a43-a2f4-0e868ea8ea61" />



---

# Problema #2 - Conexión a SQL Server y Verificación del Hash

## Descripción

La aplicación utiliza la base de datos `HPA_Capas_Login`. La tabla `dbo.usuarios` guarda el nombre de usuario, su estado, el correo electrónico en `dsCorreo` y el hash de la contraseña en `dsPassword`. El hash SHA-512 ocupa 64 bytes y se almacena en una columna `VARBINARY(64)`.

### Elementos de C# utilizados

| Elemento | Función |
|---|---|
| `D_Conexion` | Lee la entrada `ConexionHPA` y crea la conexión a SQL Server. |
| `D_Usuario` | Ejecuta el procedimiento almacenado con un parámetro y convierte el resultado en un `E_Usuario`. |
| `IHashService` | Define el contrato para generar el hash de una contraseña. |
| `IVerificarHashService` | Define el contrato para verificar una contraseña frente al hash almacenado. |
| `Sha512HashService` | Calcula el hash SHA-512 en formato binario. |
| `Sha512VerificarHashService` | Calcula el hash de la contraseña ingresada mediante `IHashService` y compara el resultado con los bytes almacenados. |

### Funcionamiento

`D_Usuario` ejecuta `dbo.usp_Usuario_ObtenerPorNombre` con el nombre ingresado. El procedimiento recupera el registro de la cuenta, incluido su correo. En Negocio se comprueba que la cuenta esté activa y se verifica la contraseña. Si el ingreso se aprueba, el nombre de usuario y el correo se transfieren al flujo de la sesión.

### Prueba de Privilegios Mínimos

La prueba se realiza en SSMS con la misma cuenta configurada en `ConexionHPA`.

| Acción | Resultado esperado |
|---|---|
| Ejecutar `dbo.usp_Usuario_ObtenerPorNombre` para el usuario de prueba. | SQL Server permite ejecutar el procedimiento. |
| Ejecutar `dbo.usp_Productos_BajoStock`. | SQL Server devuelve el listado que usa la cuadrícula. |
| Consultar directamente `dbo.usuarios` con `SELECT dsUsuario FROM dbo.usuarios`. | SQL Server rechaza la consulta por falta de permisos. |

## Resultado - Problema #2

Los contratos de generación y verificación del hash se encuentran en archivos separados dentro de la capa de Negocio.

<img width="952" height="458" alt="image" src="https://github.com/user-attachments/assets/965f18e2-8382-4536-88de-9c55b5d8b13f" />
<img width="953" height="460" alt="image" src="https://github.com/user-attachments/assets/f4c776fb-cb6c-44cd-8ce3-8144b1784d21" />
<img width="796" height="377" alt="image" src="https://github.com/user-attachments/assets/b2250005-1ee0-4b89-a7e1-aee548052f08" />


---

# Problema #3 - Formulario Principal, Sesión y Productos Bajo Stock

## Descripción

Después de iniciar sesión se abre `FrmPrincipal`. La pantalla se organiza con una barra azul de navegación a la izquierda y un área de contenido a la derecha. El área de contenido presenta el sumario, la cuadrícula de productos bajo stock y el reloj con la fecha. La parte inferior del menú muestra el nombre de usuario y su correo.

### Controles utilizados

| Control | Función |
|---|---|
| `Panel` | Organiza el menú lateral, el área de contenido y las tarjetas del sumario. |
| `Button` | Presenta las opciones del menú. |
| `ImageList` | Contiene los íconos utilizados en los controles. |
| `Label` | Muestra los títulos, los datos de sesión, la hora y la fecha. |
| `Timer` | Actualiza el reloj cada segundo. |
| `DataGridView` | Muestra los productos bajo stock en las columnas ID, PRODUCTO y STOCK. |

### Funcionamiento

1. `Program.cs` obtiene el usuario y el correo del login aprobado y los pasa al constructor de `FrmPrincipal`.
2. El formulario muestra ambos datos en `lblSesion`. El correo aparece debajo del nombre cuando el registro tiene uno configurado.
3. Al mostrarse la ventana, el temporizador inicia la actualización de `lblHora` y `lblFecha` a partir de la hora local del equipo.
4. La consulta de productos pasa por `N_Producto` y `D_Producto`. La capa de Datos ejecuta `dbo.usp_Productos_BajoStock`, que devuelve los productos cuyo `Stock` es menor o igual a `StockMinimo`.
5. El resultado se enlaza al `DataGridView` mediante `DataSource`. Las columnas creadas en el Designer se vinculan a `Id`, `Producto` y `Stock` mediante `DataPropertyName`.

### Ejemplo de Funcionamiento

| Producto de prueba | Stock | Stock mínimo | Resultado esperado |
|---|---:|---:|---|
| Laptop Asus X540LA Intel Core i3 | 2 | 5 | Aparece en la cuadrícula. |
| Notebook Lenovo IdeaPad 110 | 5 | 5 | Aparece porque alcanzó el mínimo. |
| Laptop Lenovo IdeaPad 320 | 12 | 5 | Queda fuera porque supera el mínimo. |

## Resultado - Problema #3

La siguiente evidencia muestra el formulario principal durante una sesión activa.

<img width="643" height="386" alt="image" src="https://github.com/user-attachments/assets/d739b09c-14e0-400e-b443-bdd0a8cbf943" />
<img width="288" height="210" alt="image" src="https://github.com/user-attachments/assets/bdb498da-3ebb-4905-ad98-8b34517264e8" />



---

# Resultados Obtenidos

Se desarrolló un flujo de autenticación que separa la interacción con el formulario, la coordinación del presentador, las reglas de Negocio y el acceso a SQL Server. El formulario permite comprobar tanto el rechazo de una contraseña incorrecta como la apertura de la ventana principal después de un acceso válido.

La pantalla principal identifica la sesión activa, actualiza la hora y la fecha y presenta los productos que cumplen el criterio de bajo stock. La exportación `.sql` y el respaldo `.bak` conservan la estructura y los datos utilizados para la demostración.

---

# Dificultades y Soluciones

### Adaptación de MySQL a SQL Server

El laboratorio de referencia utiliza MySQL. Para conectar el proyecto a SQL Server se adaptó la consulta del usuario a Transact-SQL y se utilizó `Microsoft.Data.SqlClient` en la capa de Datos.

---

### Actualización del reloj en tiempo real

Los textos configurados en el Designer servían para ubicar los controles. La hora actual se obtiene al abrir el formulario y se actualiza cada segundo mediante el evento `Tick` del temporizador de Windows Forms.

---

### Visualización del usuario y su correo

El texto inicial del `Label` era fijo. Para mostrar la sesión activa se incorporó `dsCorreo` al registro de usuario y se pasaron el nombre autenticado y el correo desde el login hasta `FrmPrincipal`.

---

### Carga de productos en el DataGridView

La base inicial contenía la tabla de usuarios. Para obtener los productos bajo stock se agregaron las tablas `Marcas` y `Productos`, se cargaron registros de prueba y se creó un procedimiento almacenado para aplicar el filtro. En el formulario se vincularon las columnas del Designer con los nombres devueltos por la consulta.

---

# Información del Estudiante

**Nombre:** Maria Townshend  
**Grupo:** 1IL133  
**Curso:** Herramientas de Programación Aplicada III  
**Institución:** Universidad Tecnológica de Panamá  
**Facultad:** Facultad de Ingeniería de Sistemas Computacionales  
**Instructor:** Ing. Irina Fong
