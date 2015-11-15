var map;

require(["esri/map",
        "esri/symbols/SimpleMarkerSymbol",
        "esri/InfoTemplate",
        "esri/Color",
        "esri/renderers/SimpleRenderer",
        "esri/layers/FeatureLayer",
        "dojo/domReady!"
], function(Map, SimpleMarkerSymbol, InfoTemplate, Color, SimpleRenderer, FeatureLayer) {
    var map = new Map("map", {
        center: [0, 0],
        zoom: 2,
        basemap: "gray"
    });

    /*map.on("mouse-drag", function (event) {
        if (map.infoWindow.isShowing) {
            var loc = map.infoWindow.getSelectedFeature().geometry;
            if (!map.extent.contains(loc)) {
                map.infoWindow.hide();
            }
        }
    });*/

    var point = new SimpleMarkerSymbol();
    point.setSize(14);
    point.setColor(new Color([207, 34, 30])); //Make Scarlet later

    var infoTemplate = new InfoTemplate("Event:", "${EVENT}", "City:", "${CITY}");

    var featureLayer = new FeatureLayer("http://services6.arcgis.com/rAnH6ymcuU1vmU2P/arcgis/rest/services/Incidents/FeatureServer/0", {
        mode: FeatureLayer.MODE_ONDEMAND,
        outFields: ["*"],
        infoTemplate: infoTemplate
    });

    featureLayer.setRenderer(new SimpleRenderer(point));

    map.addLayer(featureLayer);
});