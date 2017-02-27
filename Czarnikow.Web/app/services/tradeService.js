app.factory('tradeService', ['$http', function ($http) {
    var baseUrl = "http://localhost:57003";

    var tradeService = {};

    var getTrades = function () {
        return $http.get(baseUrl + '/trade').then(function (response) {
            return response;
        });
    };

    
    var getTrade = function (tradeId) {
        return $http.get(baseUrl + '/trade/' + tradeId).then(function (response) {
            return response;
        });
    };

    
    var updateTrade = function (tradeModel) {
        return $http.put(baseUrl + '/trade/', tradeModel, { headers: { 'Content-Type': 'application/json; charset=utf-8' } }).then(function (response) {
            return response;
        });
    };

    tradeService.getTrade = getTrade;
    tradeService.getTrades = getTrades;
    tradeService.updateTrade = updateTrade;
    
    return tradeService;
}]);