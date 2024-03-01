
window.cambiarTema = function (cssFile) {
    console.log("en script cambiar tema inicio"+cssFile+"este")
    console.log("imprime cssFil "+cssFile);
    // Aquí cambias el tema de tu aplicación aplicando el archivo CSS deseado
    // Por ejemplo, podrías cambiar el href del elemento link que referencia a tu archivo CSS
    var linkElement = document.getElementById('site');
    if (linkElement) {
        linkElement.setAttribute('href', cssFile);
        console.log("script cambiar tema");
    } else {
        console.error("No se encontró el elemento CSS con id 'site'.");
    }
};