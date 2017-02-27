app.controller('editTradeController', ['$scope', '$location', '$routeParams', 'tradeService', function ($scope, $location, $routeParams, tradeService) {
    $scope.tradeId = $routeParams.tradeId;
    $scope.tradeModel = {
        Id: 0,
        Quantity: 0,
        Amount: 0
    };

    var getTrade = function (tradeId) {
        if (tradeId > 0) {
            tradeService.getTrade(tradeId).then(function (response)
            { $scope.tradeModel = response.data; },
        function (error) {
            console.log(error);
        });
        }
    }

    $scope.OnSaveTrade = function () {

            tradeService.updateTrade($scope.tradeModel).then(
               function (response) {
                   $location.path('/trades');
               },
           function (error) {
               console.log(error);
           });
       
    }

    getTrade($scope.tradeId);
}]);