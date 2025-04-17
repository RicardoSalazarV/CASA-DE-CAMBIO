# CASA DE CAMBIO

CASA DE CAMBIO es una aplicación de escritorio desarrollada en C# con Windows Forms, que permite realizar conversiones entre diferentes monedas usando tasas de cambio fijas. Su interfaz intuitiva permite al usuario ingresar un monto, seleccionar una moneda de origen mediante radio buttons, y visualizar el resultado convertido junto con un ícono representativo.

Características

Conversión de divisas con tasas fijas predefinidas.

Interfaz gráfica amigable desarrollada con Windows Forms.

Visualización dinámica de imágenes asociadas a cada tipo de moneda.

Mensajes de validación para entrada de datos incorrectos.

Funcionalidad de limpieza de datos y reinicio de estado de interfaz.


Monedas soportadas

Las tasas de cambio están codificadas de la siguiente forma:

Estructura del Proyecto

Form1.cs: Contiene la lógica principal de la aplicación, manejo de eventos y conversión de divisas.

imageList1: Almacena las imágenes que se muestran al seleccionar una moneda.

radioButton1-4: Permiten seleccionar la moneda de origen.

textBox2: Campo donde el usuario ingresa el monto a convertir.

textBox1: Muestra el resultado convertido.

label2: Describe la moneda destino después de la conversión.

groupBox1: Agrupa las opciones de moneda y se muestra dinámicamente.


Requisitos

.NET Framework 4.7 o superior

Visual Studio 2019 o posterior

Sistema operativo Windows


Instrucciones de uso

1. Clona o descarga el repositorio del proyecto.


2. Abre el archivo .sln en Visual Studio.


3. Compila el proyecto (Ctrl + Shift + B).


4. Ejecuta la aplicación (F5).


5. Ingresa un valor numérico en el campo correspondiente.


6. Selecciona la moneda de origen con los radio buttons.


7. Observa el resultado en el campo de salida junto con la imagen asociada.



Notas Técnicas

El cálculo se realiza en tiempo real al seleccionar un radio button, siempre que se haya ingresado una cantidad válida.

La lógica de validación y el control de la visibilidad de elementos están embebidos en los manejadores de eventos.


Mejoras Futuras

Integración con API de tasas de cambio en tiempo real.

Soporte multimoneda con selección personalizada.

Guardado de historial de conversiones.

Internacionalización (i18n).