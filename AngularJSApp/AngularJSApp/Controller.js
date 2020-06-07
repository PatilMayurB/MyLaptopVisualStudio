myApp.controller("mainController", function ($scope, $location, myFactory, APIService) {

    // Array to save received data of all employees
    var people = [];
    $scope.people = people;

    // Calling method to get all employees
    recieveEmployees();

    // Method to call all employees
    function recieveEmployees() {
        var recievedEmployees = APIService.getAllEmployee();
        recievedEmployees.then(function (response) {
            $scope.people = response.data;
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }

    //Function to save a new employee
    $scope.saveChanges = function () {
        var employee = {
            EmpName: $scope.EmpName,
            Department: $scope.Department,
            Age: $scope.Age,
            UserName: $scope.UserName,
            Password: $scope.Password
        };
        var savedEmployeeId = APIService.postEmployee(employee);
        savedEmployeeId.then(function (response) {
            recieveEmployees();
            $location.path('/HomePage');
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    };

    // Function to get a single employee
    $scope.getEmployee = function (id) {
        var recievedEmployee = APIService.getEmployee(id);
        recievedEmployee.then(function (response) { 
            myFactory.set(response.data);
            $location.path('/EditEmployee');
            },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }

    $scope.deleteEmployee = function (id) {
        var deletedEmployee = APIService.deleteEmployee(id);
        deletedEmployee.then(function (response) {
            recieveEmployees();
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }

});

//Controller for EditEmployee page
myApp.controller("myController", function ($scope, $location, myFactory, APIService) {
    $scope.emp = myFactory.get();

    $scope.updateEmployee = function () {
        var employee = {
            EmpId: $scope.emp.empId,
            EmpName: $scope.emp.empName,
            Department: $scope.emp.department,
            Age: $scope.emp.age,
            UserName: $scope.emp.userName,
            Password: $scope.emp.password
        };
        var employeeEdited = APIService.updateEmployee(employee);
        employeeEdited.then(function (response) {
            //$scope.EmpId = response.empId;
            //recieveEmployees();
            $location.path('/HomePage');
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }
});

//Factory to save and retrieve data
//They are singleton, can be used across app
myApp.factory("myFactory", function () {
    var savedData = {}

    function set(data) {
        savedData = data;
    }

    function get() {
        return savedData;
    }
    return {
        set: set,
        get: get
    }
});
