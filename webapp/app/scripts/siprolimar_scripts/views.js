/**
/* Autores: Marcela Conejo, Katherine Solano
/*
/**
**/
Views =function(){
	var currentView;
	return{
		hideViews: function(){
			$('.view').hide();
		},
		backToHome: function(){
			Views.hideViews();
			Common.removeActiveClass();
			Views.showWelcomeView();
		},
		initializeWelcomeView: function(){
			var user = Common.getCookie("currentUser");
			$('#welcomeView p').text("Bienvenido a SIPROLIMAR, " + user);
		},
		hideWelcomeView: function(){
			$('#welcomeView').hide();
		},
		showWelcomeView: function(){
			$('#welcomeView').show();
		},
		bindViews: function(){
			$('#reporteProducto').click(function(){
				Views.initializeReporteProductoView(true,0);
			});
			$('#reporteCliente').click(function(){
				Views.initializeReporteClienteView(true,0);
			});
			$('#reporteFactura').click(function(){
				Views.initializeReporteFacturaView(true,0);
			});
			$('#crearFactura').click(function(){
				Views.initializeCrearFacturaView();
			});
		},
		getCurrentView: function(){
			return currentView;
		},
		setCurrentView: function(current){
			var view = $("#"+current).attr("data-view");
			currentView = view;
		},
		//Vista de Reporte de Productos
		initializeReporteProductoView: function(all, id){
			Views.hideViews();
			var productos;
			$('#notificador').hide();
			if(all){
				productos = Search.reporteProductos();
			}else{
				productos = Search.reporteProducto(id);
			}

			if(productos.content != null) {//Indica si el query fue exitoso
				Views.renderProductos(productos); 
			}else{
				$('#notificador span').text("No se encuentra el producto con el código " + id);
				$('#notificador').show();
			}
			Common.stopLoading();
			Views.hideWelcomeView();
			$('#reporteProductoView').show(); 
			Views.setCurrentView("reporteProductoView");
			Common.addActiveClass();
		},
		renderProductos: function(productos){
			var tamannos = Search.tamannoProducto();
			$('#reporteProductoResults tbody').empty();// Limpiar la tabla para evitar resultados repetidos
			$(productos.content).each(function(index,elem){
				var producto = elem;
				var tamanno;
				$(tamannos.content).each(function(i,e){
					var nombre = e.nombre.trim();
					var id = e.idTamaño
					if(producto.tamanno == id){
						tamanno = nombre;
					}
				});
				$('#reporteProductoResults tbody').append("<tr>"+ 
														    "<td class='idProducto center'>"+ producto.idProducto +"</td>" + 
														    "<td class='nombre'>"+ producto.nombre +" "+ tamanno +"</td>" +
														    "<td class='precioVenta'>¢"+ producto.precioVenta +"</td>" +
														    "<td class='cantidadExistencia'>"+ producto.cantidadExistencia +"</td>" +
													      "</tr>");
			});
		},
		//Vista de reporte de clientes
		initializeReporteClienteView: function(all, id){
			Views.hideViews();
			var clientes;
			$('#notificador').hide();
			if(all){
				clientes = Search.reporteClientes();
			}else{
				clientes = Search.reporteCliente(id);
			}

			if(clientes.content != null) {//Indica si el query fue exitoso
				Views.renderClientes(clientes); 
			}else{
				$('#notificador span').text("No se encuentra el cliente con el código " + id);
				$('#notificador').show();
			}
			Common.stopLoading();
			Views.hideWelcomeView();
			$('#reporteClienteView').show(); 
			Views.setCurrentView("reporteClienteView");
			Common.addActiveClass();
		},
		renderClientes: function(clientes){			
			$('#reporteClienteResults tbody').empty();// Limpiar la tabla para evitar resultados repetidos
			$(clientes.content).each(function(index,elem){
				var cliente = elem;					
				$('#reporteClienteResults tbody').append("<tr>"+ 
														    "<td class='idCliente center'>"+ cliente.idCliente +"</td>" + 
														    "<td class='cedula'>"+ cliente.cedula +"</td>" +
														    "<td class='nombre'>"+ cliente.nombre +"</td>" +
														    "<td class='correo'>"+ cliente.correo +"</td>" +
													      "</tr>");
			});
		},
		//Vista de reporte de facturas
		initializeReporteFacturaView: function(all, id){
			Views.hideViews();
			var facturas;
			$('#notificador').hide();
			if(all){
				facturas = Search.reporteFacturas();
			}else{
				facturas = Search.reporteFactura(id);
			}

			if(facturas.content != null) {//Indica si el query fue exitoso
				Views.renderFacturas(facturas); 
			}else{
				$('#notificador span').text("No se encuentra la factura con el código " + id);
				$('#notificador').show();
			}
			Common.stopLoading();
			Views.hideWelcomeView();
			$('#reporteFacturaView').show(); 
			Views.setCurrentView("reporteFacturaView");
			Common.addActiveClass();
		},
		renderFacturas: function(facturas){			
			$('#reporteFacturaResults tbody').empty();// Limpiar la tabla para evitar resultados repetidos
			$(facturas.content).each(function(index,elem){
				var factura = elem;	
				var fecha = factura.fechaHora.substring(0,10);
				var cliente = Search.getNombreCliente(factura.cliente);
				$('#reporteFacturaResults tbody').append("<tr>"+ 
														    "<td class='idFactura center'>"+ factura.idFactura +"</td>" + 
														    "<td class='fecha'>"+ fecha +"</td>" +
														    "<td class='monto'>¢"+ factura.montoTotal +"</td>" +
														    "<td class='cliente'><span id='codigoCliente' data-toggle='tooltip' data-original-title='" + cliente + "' data-placement='top'>"+ factura.cliente +"</span></td>" +
													      "</tr>");
			});
		},
		//Métodos para creación de facturas
		initializeCrearFacturaView: function(){
			Views.hideWelcomeView();
			Views.setCurrentView("crearFacturaView");
			Common.addActiveClass();
			$('#crearFacturaView').show();
		}
	}
}();