var map;
var markers = []; 

function initialize() {
    var latlng = new window.google.maps.LatLng(-18.8800397, -47.05878999999999);
 
    var options = {
        zoom: 6,
        center: latlng,
        mapTypeId: window.google.maps.MapTypeId.ROADMAP
    };
 
    map = new window.google.maps.Map(document.getElementById("mapa"), options);
}
 
initialize();

function carregarPontos() {
	
	 var localizacaoAtual = new window.google.maps.Marker({
		position: new window.google.maps.LatLng('-23.532881', '-46.792003'),
		title: "Meu ponto personalizado! :-D",
		icon: "/Content/images/marcador.png",
		map: map
	});
 
    $.getJSON("/Scripts/pontos.json", function(pontos) {
 
        $.each(pontos, function(index, ponto) {
 
            var marker = new window.google.maps.Marker({
                position: new window.google.maps.LatLng(ponto.Latitude, ponto.Longitude),
                title: "Meu ponto personalizado! :-D",
				icon: "/Content/images/marcador.png",
                map: map
            });
			
			markers.push(marker);
			console.log("atualizado");
 
        });
 
    });
 
}
 
carregarPontos();


function removeMarkers(){	
	for(var i = 0; i<markers.length; i++){
		markers[i].setMap(null);
	}		
}
		

setInterval(function(){
	removeMarkers();
	carregarPontos();
},5000);