# Cafetería El Buen Sabor - Sistema de Pedidos

## 1. Nombre y matrícula
* **Nombre:** Kelvin Isaac Adames Mota
* **Matrícula:** 2026-0029

## 2. Descripción del programa
Aplicación de escritorio en C# (Windows Forms) desarrollada en `frmPedidos` para gestionar los pedidos de **Cafetería El Buen Sabor**[cite: 2]. Permite registrar los datos del cliente y la fecha, agregar productos con opciones de tamaño y porción extra, acumular el subtotal en columnas alineadas y calcular descuentos, recargo por empaque para llevar, ITBIS y total a pagar[cite: 1, 2].

## 3. Datos de entrada
* **Cliente (`txtCliente`):** Nombre del cliente[cite: 1, 2].
* **Cliente frecuente (`chkFrecuente`):** Indica si aplica descuento del 10 % sobre el subtotal[cite: 1, 2].
* **Fecha (`dtpFecha`):** Fecha del pedido (por defecto, la fecha actual)[cite: 1, 2].
* **Producto (`txtProducto`):** Nombre del artículo a agregar[cite: 1].
* **Precio (`txtPrecio`):** Precio base unitario del producto[cite: 1].
* **Cantidad (`nudCantidad`):** Cantidad de unidades del producto (rango de 1 a 20)[cite: 1].
* **Tamaño (`rbtNormal` / `rbtGrande`):** `Normal` por defecto o `Grande` (+RD$25.00)[cite: 1, 2].
* **Porción extra (`chkPorcionExtra`):** Agrega un recargo de +RD$30.00 por unidad[cite: 2].
* **Servicio (`rbtLocal` / `rbtLlevar`):** `Consumir en local` por defecto o `Para llevar` (+RD$20.00 una sola vez por pedido)[cite: 1, 2].

## 4. Proceso
1. **Inicialización (`Load`):** Configura las columnas del encabezado (`lblEncabezado`) con anchos `6`, `24`, `10` y `12` (`PadRight`/`PadLeft`) y establece los valores iniciales del formulario[cite: 1].
2. **Agregar al pedido (`btnAgregar`):** Valida los campos del producto, calcula el precio unitario sumando los recargos correspondientes (`rbtGrande` y/o `chkPorcionExtra`), obtiene el total de la línea (`precio unitario × cantidad`), agrega la fila formateada a `lstPedido`, acumula el subtotal y reinicia los controles del producto[cite: 1, 2].
3. **Calcular total (`btnCalcular`):** Verifica que existan productos en `lstPedido`[cite: 1]; calcula el descuento (10 % del subtotal si `chkFrecuente` está marcado), el empaque (RD$20.00 si `rbtLlevar` está seleccionado), la base imponible (`subtotal - descuento + empaque`), el ITBIS (18 % de la base imponible) y el total a pagar (`base imponible + ITBIS`)[cite: 1, 2].
4. **Nuevo pedido (`btnLimpiar`):** Limpia los campos, restablece el subtotal a cero y devuelve el foco a `txtCliente`[cite: 1].
5. **Salir (`btnSalir`):** Solicita confirmación mediante un cuadro `MessageBox` (Sí/No) antes de cerrar la aplicación[cite: 2].

## 5. Salida
* **Listado de pedido (`lstPedido`):** Muestra cada línea agregada con cantidad, producto y detalle entre paréntesis, precio unitario y total de línea alineados con fuente `Consolas`[cite: 1, 2].
* **Resumen de importes (`lblSubtotal`, `lblDescuento`, `lblEmpaque`, `lblItbis`, `lblTotal`):** Despliega los valores calculados con formato `RD$ 0.00`[cite: 1, 2].

## 6. Capturas de pantalla del programa en ejecución
> Coloca aquí tus capturas (por ejemplo, en una carpeta `screenshots/` dentro del repositorio) y enlázalas así:

* **Formulario inicial:** `![Formulario inicial](screenshots/inicio.png)`
* **Pedido agregado y cálculo del caso de prueba:** `![Caso de prueba](screenshots/caso-prueba.png)`
* **Confirmación al salir:** `![Confirmar salida](screenshots/salir.png)`
