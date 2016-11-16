var app = angular.module('NumberSequence', []);
var seqResult = [];

app.controller('SequenceController', function ($scope, $http) {


    $scope.GetSequence = function (inputNumber) {

        $scope.sequences = [];
        param = [];

        var param = {
            InputNumber: inputNumber
        };

        $http({
            url: '/Sequence/GetSequence',
            method: 'POST',
            params: param
        }).success(function (data, status, headers, config) {

            $scope.message = '';
            $scope.errors = [];

            if (data.success === false) {
                $scope.errors = data.errors;
            }
            else {
                $scope.sequences = data;

            }
        }).error(function (data, status, headers, config) {
            $scope.errors = [];
            $scope.message = 'Unexpected Error';


        });
    }

});

