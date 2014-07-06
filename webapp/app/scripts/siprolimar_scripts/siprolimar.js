/**
/* Autores: Marcela Conejo, Katherine Solano
/*
/**
**/
Siprolimar = function(){
	$(document).ready(function() {
	    Views.hideViews();
	    Views.setCurrentView("welcomeView");
	    Common.addActiveClass();
	    Views.bindViews();
	    $('#loginButton').click(function(){Login.doLogin();});
	    $('#password').keyup(function(e){
	    	if(e.keyCode == 13){
	    		e.preventDefault();
	    		Login.doLogin();	
	    	}
	    });
	    $('#buscarProducto').keyup(function(){
	    	var id = $('#buscarProducto').val().trim();
	    	if(isNaN(id)) Views.initializeReporteProductoView(true,0);
	    	else Views.initializeReporteProductoView(false, id);
	    });
	    $('#buscarCliente').keyup(function(){
	    	var id = $('#buscarCliente').val().trim();
	    	if(isNaN(id) || id.length < 3) Views.initializeReporteClienteView(true,0);
	    	else Views.initializeReporteClienteView(false, id);
	    });
	    $('#buscarFactura').keyup(function(){
	    	var id = $('#buscarFactura').val().trim();
	    	if(isNaN(id) || id.length < 3) Views.initializeReporteFacturaView(true,0);
	    	else Views.initializeReporteFacturaView(false, id);
	    });
	});
}();