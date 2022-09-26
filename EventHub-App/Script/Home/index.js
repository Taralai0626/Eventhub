var geocoder;
var map;
var lat = '';
var lng = '';

function initMap() {
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 43.6532, lng: -79.3832 },
        zoom: 14
    });
    var input = document.getElementById('address');


    var autocomplete = new google.maps.places.Autocomplete(input);
    autocomplete.bindTo('bounds', map);
}


function initialize() {
    geocoder = new google.maps.Geocoder();
    var latlng = new google.maps.LatLng(43.6532, -79.3832);
    var mapOptions = {
        zoom: 12,
        center: latlng
    }
    map = new google.maps.Map(document.getElementById('map'), mapOptions);
}

function codeAddress() {
    var address = document.getElementById('address').value;
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status == 'OK') {
            lat = results[0].geometry.location.lat();
            lng = results[0].geometry.location.lng();
            map.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location
            });
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}