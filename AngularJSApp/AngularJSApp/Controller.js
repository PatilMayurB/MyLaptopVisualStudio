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
})