/// <reference path="Script.js" />
/// <reference path="Service.js" />



myApp.controller("apiController", function apiController($scope, $http, serviceAPI) {

    getAllEmployees();

    function getAllBooks() {

        var recieved = serviceAPI.getEmployees();

        recieved.then(
            function (response) {
                $scope.Employees = response.data;
            }
        )

    }

});