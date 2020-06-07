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
        //var getRequest =  $http.get("http://localhost:5000/api/GetEmployee/" + empId);
        var getRequest = $http({
            method: 'get',
            url: "http://localhost:5000/api/GetEmployee/" + empId,
        });

        return getRequest;
    }
    this.updateEmployee = function (employee) {
        var postRequest = $http({
            method: 'put',
            url: "http://localhost:5000/api/UpdateEmployee",
            data: employee
        });
        return postRequest;
    }

    this.deleteEmployee = function (empId) {
        var getRequest = $http.delete("http://localhost:5000/api/DeleteEmployee/" + empId);
        //var getRequest = $http({
        //    method: 'get',
        //    url: "",
        //    params: {EmpId : empId}
        //});

        return getRequest;
    }
});
