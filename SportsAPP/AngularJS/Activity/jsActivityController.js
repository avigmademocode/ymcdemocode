HomeApp.controller('ActivityController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {


    $scope.addActivity = function () {
        debugger;

        var Data = {

            activity_name: $scope.form.activityname,
            // branch_name: $scope.form.Branch_name,
            amount: $scope.form.amount,
            branch_id: $scope.form.Branch,
            city_id: $scope.form.City,
            state_id: $scope.form.State,

            Type: 1,
            UserID: 0,
            is_delete: 0
        };
        alert(JSON.stringify(Data));
        AjsFactory.AddActivityDetail(Data)
            .then(function (response) {
                 alert(response.data.length);
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });

    };
    $scope.GetBranchData = function () {
        //debugger;

        AjsFactory.getBranchDetailsData()
            .then(function (resopnse) {
                //debugger;
                if (resopnse.data[0].length != 0) {
                     //debugger;
                    $scope.BranchLst = JSON.parse(resopnse.data);  //resopnse.data;

                }

            });
    };

    $scope.GetBranchData();

    $scope.GetCityData = function () {
        //  debugger;

        AjsFactory.getCityDetailsdata()
            .then(function (resopnse) {
                // debugger;
                if (resopnse.data[0].length != 0) {
                    // debugger;
                    $scope.cityLst = resopnse.data[0];
                    $scope.Test();

                }

            });
       

    };

    $scope.GetCityData();

    $scope.GetStateData = function () {
        // debugger;

        AjsFactory.getStateDetailsdata()
            .then(function (resopnse) {
                // debugger;
                if (resopnse.data[0].length != 0) {
                    // debugger;
                    $scope.stateLst = resopnse.data[0];

                }

            });

    };

    $scope.GetStateData();

    $scope.Test = function () {

        $scope.form.Branch = 4;
        $scope.form.City = 1;
        $scope.form.State = 1;
    }
   

}]);