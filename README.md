# repasoDA2

## Comandos Docker API

```
docker build -t todoapi .
docker run -it --rm -p 5001:80 --name todoapi todoapi
```

## Ideas para adelante

### Diseño

* Clase abstracta Lista
    * id
    * nombre
    * [ int ] (estos serian los id de los elementos)
    * capaz en vez de int hacer listElement abstracta y que hereden despues las concretas
* Heredan ListaTareas ListaCompras ListaGastos
* Clases concretas Tarea Gasto Producto
* Dividir en capas, API -> Logica -> DataAccess

### Arquitectura

Usar una VM en cualq provider gratuito de los de gh education (AWS de preferencia para agarrar cancha).

DB SQLite local, archivo pelado.
API deployada en un contenedor, en bookmarks hay guia.
Para backups de la DB en bookmarks hay un one liner que la copia al host, ahi lo que puedo hacer despues es respaldar a un S3 con un cron diario (pensando en AWS).
