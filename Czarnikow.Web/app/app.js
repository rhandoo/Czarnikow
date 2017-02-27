var app = angular.module('CzarnikowApp', ['ngRoute'])
app.config(function ($routeProvider) {
    $routeProvider.when("/trades", {
        controller: "tradeController",
        templateUrl: "/app/views/trades.html"
    });

    $routeProvider.when("/editTrade/:tradeId", {
        controller: "editTradeController",
        templateUrl: "/app/views/editTrade.html"
    });

    $routeProvider.otherwise({ redirectTo: "/trades" });


});

