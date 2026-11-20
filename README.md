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
**Formulario inicial:** <img width="1054" height="730" alt="Captura de pantalla 2026-11-19 222851" src="https://github.com/user-attachments/assets/b803091d-9720-4084-a9d2-31d1b791d22d" />
`
**Pedido agregado y cálculo del caso de prueba:** `<img width="1055" height="728" alt="Captura de pantalla 2026-11-19 222357" src="https://github.com/user-attachments/assets/e404d9d1-8930-4826-a222-183867ceb5da" />
<img width="1059" height="732" alt="Captura de pantalla 2026-11-19 222521" src="https://github.com/user-attachments/assets/3193514e-c823-4e16-8b5a-6d4f943bd2d6" />
 `
 **Confirmación al salir:** `<img width="1060" height="728" alt="Captura de pantalla 2026-11-19 223600" src="https://github.com/user-attachments/assets/4f0191f1-ccf1-44f0-96cf-32189f8b5ee3" />
`
 


