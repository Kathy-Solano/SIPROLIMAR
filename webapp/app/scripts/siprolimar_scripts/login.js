Login = function(){
	
	function setCurrentUserName(name){
		Common.setCookie("currentUser", name, 100);
	}

	return {
		doLogin: function(){
			$('#loginNotificator').hide();
			var usuario = $('#usuario').val().trim();
			var password = $('#password').val().trim();
			var okToGo = true;
			if(usuario == "" || password == ""){
				$('#loginNotificator span').text("El usuario y la contraseña son campos requeridos.");
				$('#loginNotificator').show();
				okToGo = false;
			}
			if(okToGo){
				var parameter = '?nombre=' + usuario + '&password=' + password;
				var response = Search.login(parameter);
				var validUser = response.content;
				if(validUser){
					setCurrentUserName(usuario);
					window.location = 'siprolimar.html';
				}else{
					$('#loginNotificator span').text("El usuario o la contraseña son incorrectos.");
					$('#loginNotificator').show();	
				}	
			}
			
		}
	}
}();