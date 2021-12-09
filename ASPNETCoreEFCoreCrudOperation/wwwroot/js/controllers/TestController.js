app.controller('TestController', ['$scope', function ($scope) {
    $scope.list = ["Clean my room", "Go to store", "Study stuff"];
    $scope.addItem = function () {
        $scope.list.push($scope.addToDo);
    }
}]);

