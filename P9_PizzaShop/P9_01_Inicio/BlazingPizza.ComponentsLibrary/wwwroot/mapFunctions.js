function initLeafletMap() {
    console.log("ok inicializa el mapa")
    var map = L.map('map').setView([40.416775, -3.70379], 13); // Coordenadas de Madrid

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: 'Map data © <a href="https://openstreetmap.org">OpenStreetMap</a> contributors'
    }).addTo(map);

    L.marker([40.416775, -3.70379]).addTo(map) // Marcador en Madrid
        .bindPopup('Madrid')
        .openPopup();
}
