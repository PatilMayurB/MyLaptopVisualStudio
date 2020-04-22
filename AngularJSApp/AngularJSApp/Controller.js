myApp.controller("mainController", function ($scope, $location, myFactory, APIService) {

    var people = [  ];
    $scope.people = people;

    recieveEmployees();

    function recieveEmployees() {
        var recievedEmployees = APIService.getAllEmployee();
        recievedEmployees.then(function (response) {
            $scope.people = response.data;
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }

    $scope.save = function () {
        var employee = {
            EmpName: $scope.EmpName,
            Department: $scope.Department,
            Age: $scope.Age,
            UserName: $scope.UserName,
            Password: $scope.Password
        };

        var savedEmployeeId = APIService.postEmployee(employee);
        savedEmployeeId.then(function (response) {
            $scope.EmpId = response.empId;
            recieveEmployees();
        },
            function (error) {
                $scope.errorMessage = "Error";
            });
    };

    $scope.getEmployee= function (id) {
        var recievedEmployee = APIService.getEmployee(id);
        recievedEmployee.then(function (response) { 
            myFactory.set(response.data);
            $location.path('/CreateEmployee');
            },
            function (error) {
                $scope.errorMessage = "Error";
            });
    }
});

myApp.controller("myController", function ($scope, myFactory, APIService) {
    $scope.emp = myFactory.get();
});

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
