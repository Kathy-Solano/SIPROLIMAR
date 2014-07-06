/**
/* Autores: Marcela Conejo, Katherine Solano
/*
/**
**/

Common = function(){
	return{
		loading: function(){
			$('.loading').show();
		},
		stopLoading: function(){
			$('.loading').hide();
		},
		removeActiveClass: function(){
			var modulos = $('.mainNav li.main');
			$(modulos).each(function(index, elem){
				var modulo = $(elem);
				modulo.removeClass('active');
			});
		},
		addActiveClass: function(){
			var currentView = Views.getCurrentView();
			switch(currentView){
				case "facturacion":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				case "clientes":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				case "productos":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				case "reportes":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				case "acerca":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				case "ayuda":
				Common.removeActiveClass();
				$("."+currentView).addClass('active');
				break;
				default:
				Common.removeActiveClass();
			}

		},
		setCookie: function(c_name,value,exdays) {
			var exdate = new Date();
			exdate.setDate(exdate.getDate() + exdays);
			var c_value = escape(value) + ((exdays == null) ? "" : "; expires="+exdate.toUTCString());
			document.cookie = c_name + "=" + c_value;
		},
		getCookie: function(c_name) {
			var c_value = document.cookie;
			var c_start = c_value.indexOf(" " + c_name + "=");
			if (c_start == -1) {
				c_start = c_value.indexOf(c_name + "=");
			}
			if (c_start == -1) {
				c_value = null;
			} else {
				c_start = c_value.indexOf("=", c_start) + 1;
				var c_end = c_value.indexOf(";", c_start);
				if (c_end == -1) {
					c_end = c_value.length;
				}
				c_value = unescape(c_value.substring(c_start,c_end));
			}
			return c_value;
		},
		delCookie: function(c_name) {
			document.cookie = c_name + '=; expires=Thu, 01 Jan 1970 00:00:01 GMT;';
		}
	}
}();