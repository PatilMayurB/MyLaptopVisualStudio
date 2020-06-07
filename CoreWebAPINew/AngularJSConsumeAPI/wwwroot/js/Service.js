///<reference path="Script.js" />


myApp.service('serviceAPI', function ($http) {

   // var rootUrl = 'https://localhost:5001';
    var rootUrl = 'http://localhost:52043';

    this.getEmployees = function () {
        return $http.get(rootUrl + "/api/GetAllEmployee");
    }
});