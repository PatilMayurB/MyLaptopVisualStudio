myApp.service("APIService", function ($http) {

    this.getEmployee = function () {
        return $http.get("http://localhost:5000/api/GetAllEmployee");
    }
});