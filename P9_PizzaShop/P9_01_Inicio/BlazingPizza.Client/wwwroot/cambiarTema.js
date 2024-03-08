// Con este script cambiamos el nomber del campo href que le pasamos como parametro
// Como link tenemos que pasar el cambio en la barra de navegacion, hacemos un truco y le añadimos una marca horaria 
function cambiarTema(cssFile) {
    var oldlink = document.getElementById("id_site");
    var newlink = document.createElement("link");
    newlink.setAttribute("id", "id_site");
    newlink.setAttribute("rel", "stylesheet");
    newlink.setAttribute("type", "text/css");
    newlink.setAttribute("href", cssFile);
    // Agrega una caden de consulta al final de la direccion
    newlink.setAttribute("href", cssFile + "?v=" + new Date().getTime());
    document.getElementsByTagName("head")[0].replaceChild(newlink, oldlink);
};