myApp.controller("myController", function ($scope) {

    $scope.message = "Message from Controller";
    $scope.people = [
        { id: 1, name: 'Siddu' },
        { id: 2, name: 'Sayali' },
        { id: 3, name: 'Mayur' }
    ];

    $scope.imageSource = "Images/Dragon.jpg";

    var tech = [
        { name: "C#", likes: 0, dislikes: 0 },
        { name: "SQL", likes: 0, dislikes: 0 },
        { name: ".Net", likes: 0, dislikes: 0 },
    ];

    $scope.tech = tech;

    var subjectId = null;

    $scope.addLike = function (index) {
        $scope.tech[index].likes++;
    }

    $scope.addDislike = function (index) {
        $scope.tech[index].dislikes++;
    }
});

myApp.controller("mainController", function ($scope, APIService) {


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

                var recievedEmployees = APIService.getEmployee();
        recievedEmployees.then(function (response) {
            $scope.people = response.data;
        },
            function (error) {
                $scope.errorMessage = "Error";
            }
        );
    

        //$scope.people.push({
        //    "empId": 16,
        //    "empName": "Sharada",
        //    "department": "Accounts",
        //    "age": 45,
        //    "userName": "Sharada",
        //    "password": "Sharada"
        //})
    }

});