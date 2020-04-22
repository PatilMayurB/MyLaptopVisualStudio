myApp.controller("mainController", function ($scope, $location, myFactory, APIService) {

    var people = [
        {
            "empId": 24,
            "empName": "OmkarP",
            "department": "Retail",
            "age": 25,
            "userName": "OmkarP",
            "password": "OmkarP"
        }
    ];
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

    //$scope.EmpId = "0";
    //$scope.EmpName = "";
    //$scope.Department = "";
    //$scope.Age = "";
    //$scope.UserName = "";
    //$scope.Password = "";

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

    $scope.getEmployee= function (item1) {
        //window.location = '#/CreateEmployee';
        //var recievedEmployee = APIService.getEmployee(item1.empId);

        //recievedEmployee.then(function (response) { 
        //window.location = '#/CreateEmployee';
        //var item = response.data;
        //$scope.EmpId = item.empId;
        //$scope.EmpName = item.empName;
        //$scope.Department = item.department;
        //$scope.Age = item.age;
        //$scope.UserName = item.userName;
        //$scope.Password = item.password;
        //},
        //    function (error) {
        //        $scope.errorMessage = "Error";
        //    });
        var recievedEmployee = APIService.getEmployee(item1);
        recievedEmployee.then(function (response) { 
            myFactory.set(response.data);
            $location.path('/CreateEmployee');
            },
            function (error) {
                $scope.errorMessage = "Error";
            });
        //var recievedEmployee = APIService.getEmployee(16);

        //recievedEmployee.then(function (response) {
        //    var item = response.data;
        //    $scope.EmpId = item.empId;
        //    $scope.EmpName = item.empName;
        //    $scope.Department = item.department;
        //    $scope.Age = item.age;
        //    $scope.UserName = item.userName;
        //    $scope.Password = item.password;
        //},
        //    function (error) {
        //        $scope.errorMessage = "Error";
        //    });

    }
});

myApp.controller("myController", function ($scope, myFactory, APIService) {
    
    //var recievedEmployee = APIService.getEmployee(16);
    $scope.emp = myFactory.get();

        //recievedEmployee.then(function (response) { 
        //var item = response.data;
        //$scope.EmpId = item.empId;
        //$scope.EmpName = item.empName;
        //$scope.Department = item.department;
        //$scope.Age = item.age;
        //$scope.UserName = item.userName;
        //$scope.Password = item.password;
    //},
    //    function (error) {
    //        $scope.errorMessage = "Error";
    //    });
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



        //window.location = 'CreateEmployee.html';
        //$scope.EmpId = item.empId;
        //$scope.EmpName = item.empName;
        //$scope.Department = item.department;
        //$scope.Age = item.age;
        //$scope.UserName = item.userName;
        //$scope.Password = item.password;
        //$location.url = '/CreateEmployee.html';


//myApp.controller("myController", function ($scope) {

//    $scope.message = "Message from Controller";
//    $scope.people = [
//        { id: 1, name: 'Siddu' },
//        { id: 2, name: 'Sayali' },
//        { id: 3, name: 'Mayur' }
//    ];

//    $scope.imageSource = "Images/Dragon.jpg";

//    var tech = [
//        { name: "C#", likes: 0, dislikes: 0 },
//        { name: "SQL", likes: 0, dislikes: 0 },
//        { name: ".Net", likes: 0, dislikes: 0 },
//    ];

//    $scope.tech = tech;

//    var subjectId = null;

//    $scope.addLike = function (index) {
//        $scope.tech[index].likes++;
//    }

//    $scope.addDislike = function (index) {
//        $scope.tech[index].dislikes++;
//    }
//});
