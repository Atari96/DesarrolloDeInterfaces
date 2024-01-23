// En este script se agrega el service-worker, que nos permitirá instalar la app, trabajar sin conexion o gestionar notificaciones

// Se inicializa cuando el evento capturado corresponde a la instalacion, semuestra el mensaje en consola
// y le indicamos que no espere y pase a estar activo inmediatamente
self.addEventListener('install', async event => {
    console.log('Installing service worker...');
    self.skipWaiting();
});

// Se inicializa cuando se realiza una solicitud de red, se puede ajustar para controlar si se deben de utilizar
// los datos en cache si estamos offline
self.addEventListener('fetch', event => {
    return null;
});

// Se inicializa cuando se recibe una peticion push, guardando en la variable payload los datos transformandolos en un json
self.addEventListener('push', event => {
    const payload = event.data.json();
    // con event.wait le indicamos que tiene que esperar hasta obtener la informacion y muestre la notificacion
    event.waitUntil(
        self.registration.showNotification('Blazing Pizza', {
            body: payload.message,
            icon: 'img/icon-512.png',
            vibrate: [100, 50, 100],
            data: { url: payload.url }
        })
    );
});

// Se inicializa cuando hacemos clic sobre una notificacion, cierra la notificacion y abre el navegador con la url para mostrar la informacion
self.addEventListener('notificationclick', event => {
    event.notification.close();
    event.waitUntil(clients.openWindow(event.notification.data.url));
});