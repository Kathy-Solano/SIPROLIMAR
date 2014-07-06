/**
/* Autores: Marcela Conejo, Katherine Solano
/*
/**
**/
Search = function(){
	return{
		login: function(parametro){
			var rawResponse = Query.login(parametro);
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteProductos: function(){
			var rawResponse = Query.getProductos();
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteProducto: function(parametro){
			var rawResponse = Query.getProducto(parametro);
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		tamannoProducto: function(){
			var rawResponse = Query.getTamannoProducto()
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteClientes: function(){
			var rawResponse = Query.getClientes();
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteCliente: function(parametro){
			var rawResponse = Query.getCliente(parametro);
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteFacturas: function(){
			var rawResponse = Query.getFacturas();
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		reporteFactura: function(parametro){
			var rawResponse = Query.getFactura(parametro);
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response;
		},
		getNombreCliente: function(id){
			var rawResponse = Query.getCliente(id);
			var response = {};
			response.content = rawResponse.responseJSON;
			response.statusCode = rawResponse.status;
			return response.content.nombre;
		}
	}
}();