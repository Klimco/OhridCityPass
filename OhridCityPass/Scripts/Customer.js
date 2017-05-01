angular.module('CustomerApp', [])
.controller("CustomerCtrl", function ($scope, $http) {
    $scope.title = "questions to be loaded";
    $scope.correctAnswer = false;

});