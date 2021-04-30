# Laboratorio_4

Aplicacion de patrones de diseño estructurales

Tenemos un objeto tienda que esta acoplada al API de un banco y nos llega el requerimiento de que debemos aumentar un metodo de pago nuevo, por ejemplo el de paypal.
Si queremos implementarlo tendriamos que modificar casi toda la clase tienda para que se acepten las 2 formas de pago lo cual si nos lo imaginamos seria muy complejo de hacer.
Razon por la cual usamos el patron adapter para poder implementar las 2 formas de pago.
