HomeApp.controller('AddMemberController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.AddSpeInterestsData = function () {
        debugger;
        alert("test");
        var data = {
            special_interests:$scope.form.specialInterests,

            Type: 1,
            UserID: 0,
            is_delete: 0
        }

        AjsFactory.addSpecialInterestsData(data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });

    };

    $scope.AddProQulificationData = function () {
        debugger;
        var data = {
            professional_qualifications:$scope.form.proQualifications,

            Type: 1,
            UserID: 0,
            is_delete: 0
        };

        AjsFactory.addProQulificationData(data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });
    };

    $scope.AddGSTPerData = function () {
        debugger;

        var data = {

            GST_Percentage:$scope.form.GSTPercentage,

            Type: 1,
            UserID: 0,
            is_delete: 0
        };

        AjsFactory.addGSTPerData(data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });
    };
}]);
