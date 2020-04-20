myApp.service('serviceAPI', function ($http) {

    var rootUrl = 'https://localhost:5001';

    this.getEmployees = function () {
        return $http.get(rootUrl + "api/GetAllEmployee");
    }
});