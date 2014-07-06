/**
/* Autores: Marcela Conejo, Katherine Solano
/*
/**
**/
Query = function(){
    var baseURL = "http://localhost:60588/api/";
    function requestService(url){
        return $.ajax(baseURL + url, {
            contentType: "text/plain, charset=utf-8",
            data: "",
            type: "GET",
            crossDomain: true,
            async: false
        });
    }
    return {
        login: function(parametro){
            return requestService("usuario/get" + parametro)
        },
        getProductos: function(){
            return requestService("producto/get");
        },
        getProducto: function(parametro){
            return requestService("producto/get/" + parametro);
        },
        getTamannoProducto: function(){
            return requestService("tamannoproducto/get");
        },
        getClientes: function(){
            return requestService("cliente/get");
        },
        getCliente: function(parametro){
            return requestService("cliente/get/" + parametro);
        },
        getFacturas: function(){
            return requestService("factura/get");
        },
        getFactura: function(parametro){
            return requestService("factura/get/" + parametro);
        }
    }
}();

