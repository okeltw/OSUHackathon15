var layerDefinition = {
    "geometryType": "
    
    GeometryPolygon",
    "fields": [{
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }, {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    } , {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }, {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }, {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }, {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }, {
        "Event": "Attack",
        "Location": "as",
        "Description": "",
        "Longitude": "",
        "Latitude": ""
    }]
}

var featureCollection = {
    layerDefinition: layerDefinition,
    featureCollection: null
};

var featureLayer = new FeatureLayer(featureCollection, {
    mode: FeatureLayer.MODE_SNAPSHOT,
    infoTemplate: infoTemplate 
})

featureLayer.setRenderer(new SimpleRenderer(point));

map.addLayer(featureLayer);