# Trabajo integrador
Curso "Desarrollador .NET" de Impulsando Talento - NEORIS Becas 2022 dictado por UTN BA

# Consigna
Una empresa de viajes quiere registrar las ventas de los paquetes a sus clientes. Dicha empresa suele realizar bonificaciones en función del importe acumulado por las ventas de sus clientes.

Dicho software debe administrar:

Cliente: Debe contener mínimamente nacionalidad,provincia, dirección y teléfono de contacto. Existen clientes particulares que tendrán dni, apellido y nombre, y corporativo que ademas del apellido, nombre y dni del viajante tiene cuit y razón social de la empresa.

Paquetes vendidos: Hay 2 tipos de paquetes: Nacionales, internacionales, Los paquetes internacionales tienen cotización del dolar y una marca indicando si se requiere visa . Ambos tipos de paquetes tienen nombre, precio, lista de lugares (entre 1 y 10), cantidad de días, fecha de viaje, si esta vigente o vencido. Los nacionales tienen impuestos en %, los internacionales en valor fijo. Los nacionales se venden contado y hasta 12 cuotas, los internacionales hasta 6 cuotas. Los paquetes pueden estar activos o inactivos porque ya vencieron.

Facturación: El sistema tiene registro de las facturas de sus clientes.

# Especificaciones de diseño

La empresa conoce todas las facturas realizadas, sus clientes y los paquetes. Cada paquete “conoce” la lista de lugares que se visitan. Cada factura tiene una referencia al cliente al que se le factura.

Realizar un sistema que permita:

1-Crear un nuevo cliente validando todos los datos de ingreso.
2-Listar todas las facturas de un cliente y el total de sus ventas
3-Deshabilitar un paquete.
4-Actualizar el precio de un paquete.
5-Listar los clientes que han tenido al menos dos ventas.

Todo lo que puedan/quieran agregar sobre ésto será bienvenido.
