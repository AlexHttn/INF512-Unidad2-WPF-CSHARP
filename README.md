# INF512-Unidad2-WPF-CSHARP

Este proyecto es una aplicación de escritorio desarrollada en C# con WPF (Windows Presentation Foundation), cuyo propósito principal es permitir al usuario convertir cantidades de dinero entre diferentes monedas del mundo de manera rápida y sencilla.

La interfaz cuenta con dos ComboBox donde el usuario selecciona la moneda de origen, es decir la moneda de su país, y la moneda de destino a la que desea convertir. Además tiene un TextBox donde se ingresa la cantidad a convertir, un botón que ejecuta la conversión y un Label que muestra el resultado final de forma clara y visual.

Por la parte lógica, la aplicación utiliza un diccionario en C# que almacena once monedas junto con sus tasas de cambio relativas al dólar estadounidense (USD). La fórmula de conversión funciona en dos pasos: primero convierte la cantidad ingresada a dólares dividiendo entre la tasa de la moneda origen, y luego multiplica ese valor por la tasa de la moneda destino, obteniendo así el resultado final. Este método permite convertir entre cualquier par de monedas sin necesidad de tener una tabla con todas las combinaciones posibles.

Entre las monedas disponibles se encuentran el Dólar estadounidense, Euro, Peso dominicano, Peso mexicano, Peso colombiano, Peso argentino, Peso chileno, Sol peruano, Real brasileño, Libra esterlina y el Yen japonés, cubriendo así las principales monedas de América Latina, Europa y Asia.

La aplicación también tiene un comportamiento intuitivo: cada vez que el usuario cambia alguno de los ComboBox, el resultado anterior se limpia automáticamente para evitar confusión con conversiones previas. El resultado se presenta dentro del Label con la cantidad de origen arriba, una flecha indicando la dirección de la conversión y el valor final resaltado en verde y negrita para que sea fácil de identificar a simple vista.

En cuanto al diseño, la ventana utiliza una imagen de fondo alusiva al tema del dinero, lo que le da una identidad visual acorde al propósito de la aplicación, haciendo que la experiencia del usuario sea más agradable e intuitiva.
