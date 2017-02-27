app.controller('tradeController', ['$scope', '$location', 'tradeService', function ($scope, $location, tradeService) {
    $scope.trades = [];
   

    var getActiveTrades = function () {
        tradeService.getTrades().then(function (response) {
            $scope.trades = response.data;
        }, function (error) {
            console.log(error);
        });
    }
        
    $scope.OnEditTrade = function (tradeId) {
        $location.path('/editTrade/' + tradeId);
    }

    
    getActiveTrades();
}]);