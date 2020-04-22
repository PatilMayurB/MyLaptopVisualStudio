myApp.config(function ($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('');
    $routeProvider
        //.when('/', {
        //    templateUrl: 'Index.html',
        //    controller: 'mainController'
        //})
        .when('/CreateEmployee', {
            templateUrl: 'CreateEmployee.html',
            controller: 'myController'
        })
        .when('/HomePage', {
            templateUrl: 'HomePage.html',
            controller: 'mainController'
        });
});