	function ControleDeSelecao(){
		var dropdown = document.getElementById("operadores").options[document.getElementById("operadores").selectedIndex].value;			
		var placeText;
		var visibilidade;
	}		

	function Calcular(id1, id2){
		var operador = document.getElementById("operadores").options[document.getElementById("operadores").selectedIndex].value;
		
		var num1 = document.getElementById(id1).value;
		var num2 = document.getElementById(id2).value;
		var resultado = new Number();

        switch(operador)
		{
			case "+":
			case "-":
			case "/":
			case "*":
				var StrExpressao = num1 + operador + num2;
				resultado = eval(StrExpressao); 
                break;										
		}		
		document.getElementById("saida").innerHTML = "resultado: " + resultado;
	}