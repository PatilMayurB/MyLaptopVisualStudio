myApp.service("APIService", function ($http) {

    //Get All Employee
    this.getAllEmployee = function () {
        var getAllRequest = $http({
            method: 'get',
            url: "http://localhost:5000/api/GetAllEmployee"
        });
        return getAllRequest;
    }

    //Add Employee
    this.postEmployee = function (employee) {
        var postRequest = $http({
            method: 'post',
            data: employee,
            url: "http://localhost:5000/api/AddEmployee"
        });
        return postRequest;
    }

    //Get Single Employee
    this.getEmployee = function (empId) {
        var getRequest =  $http.get("http://localhost:5000/api/GetEmployee/" + empId);
        //var getRequest = $http({
        //    method: 'get',
        //    url: "http://localhost:5000/api/GetEmployee/",
        //    params: {EmpId : empId}
        //});

        return getRequest;
    }

});

//myApp.factory("myFactory", function () {
//    var savedData = {}
//    function set(data) {
//        savedData = data;   
//    }

//    function get() {
//        return savedData;
//    }

//    return {
//        set: set,
//        get : get
//    }
//});