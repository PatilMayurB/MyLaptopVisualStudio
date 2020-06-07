myApp.controller("apiController", function apiController($scope, $http, serviceAPI) {

    getAllEmployees();

    function getAllEmployees() {

        var recieved = serviceAPI.getEmployees();

        recieved.then(
            function (response) {
                $scope.Employees = response.data;
            }
        )

    }

});