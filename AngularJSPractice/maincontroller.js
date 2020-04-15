//Assigning a controller to the app
//Contoller builds a model for a view to display

//Here we are adding a $scope variable as parameter to the controller function
    //here we will assign all our controller variables which will 
    //be made available in #content div in HTML page


//using 'app' because variable 'app' has assigned angular.module in file - app.js    
app.controller("MainController", function($scope){

    //Assigning controller variables to $scope to access in HTML
    //To print the string in HTML page

    //Scope variable that ACTS AS A MODEL
    $scope.inputText = "";

    //Array of objects in scope

    //To hold object of selected person
    $scope.selectedPerson = 0;

    //To hold string value of selected genre
    $scope.selectedGenre = null;

    //To hold array of objects
    var people = [
        { id: 0, name: 'Leon', music: [ 'Rock', 'Metal', 'Dubstep', 'Electro' ], live: true },
        { id: 1, name: 'Chris', music: [ 'Indie', 'Drumstep', 'Dubstep', 'Electro' ], live: true },
        { id: 2, name: 'Harry', music: [ 'Rock', 'Metal', 'Thrash Metal', 'Heavy Metal' ], live: false },
        { id: 3, name: 'Allyce', music: [ 'Pop', 'RnB', 'Hip Hop' ], live: true }
      ];


    $scope.people = people;

      $scope.addPerson = null;

      //Assigning function to a scope
      //This function will be called at keypress
      $scope.addNew = function (){
          if ($scope.addPerson != null || $scope.addPerson != ""){
              $scope.people.push({ id : $scope.people.length, name : $scope.addPerson , music : [] , live : true})
          }
      }
});
app.controller("MyController", function($scope){

    //Assigning controller variables to $scope to access in HTML
    //To print the string in HTML page
    $scope.message  = "Message from angular controller";
});