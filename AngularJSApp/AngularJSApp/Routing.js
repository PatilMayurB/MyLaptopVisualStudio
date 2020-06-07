myApp.config(function ($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('');
    $routeProvider
        //.when('/', {
        //    templateUrl: 'Index.html',
        //    controller: 'mainController'
        //})
        .when('/CreateEmployee', {
            templateUrl: 'CreateEmployee.html',
            controller: 'mainController'
        })
        .when('/HomePage', {
            templateUrl: 'HomePage.html',
            controller: 'mainController'
        })
        .when('/SingleEmployee', {
            templateUrl: 'SingleEmployee.html',
            controller: 'mainController'
        })
        .when('/EditEmployee', {
            templateUrl: 'EditEmployee.html',
            controller: 'myController'
        })
        ;
});