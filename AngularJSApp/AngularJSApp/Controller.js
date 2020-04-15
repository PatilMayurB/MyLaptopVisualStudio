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

myApp.controller("mainController", function ($scope) {
    var people = [
        { id: 0, name: 'Leon', music: ['Rock', 'Metal', 'Dubstep', 'Electro'], live: true },
        { id: 1, name: 'Chris', music: ['Indie', 'Drumstep', 'Dubstep', 'Electro'], live: true },
        { id: 2, name: 'Harry', music: ['Rock', 'Metal', 'Thrash Metal', 'Heavy Metal'], live: false },
        { id: 3, name: 'Allyce', music: ['Pop', 'RnB', 'Hip Hop','Edm'], live: true }
    ];

    $scope.people = people;
});