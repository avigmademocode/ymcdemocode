HomeApp.controller('ActivityController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.ActivityId = $scope.ActivityId ? $scope.ActivityId.split('?')[1] : window.location.search.slice(1);
    //alert($scope.ActivityId);

    //if ($scope.ActivityId != '') {
    //    $scope.getActivityData();
    //}

    $scope.addActivity = function () {
        debugger;

        var Type;
        if ($scope.ActivityId == 0) {
            Type = 1;

        }
        else {
            Type = 2;
        }

        var Data = {

            activity_name: $scope.form.activityname,
            // branch_name: $scope.form.Branch_name,
            amount: $scope.form.amount,
            branch_id: $scope.form.Branch,
            city_id: $scope.form.City,
            state_id: $scope.form.State,

            Pkey_activity_id: $scope.ActivityId,
            Type: Type,
            UserID: 0,
            is_delete: 1
        };
       // alert(JSON.stringify(Data));
        AjsFactory.AddActivityDetail(Data)
            .then(function (response) {
                                      
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });

    };
    $scope.GetBranchData = function () {
        //debugger;

        AjsFactory.getBranchDetailsData()
            .then(function (response) {
               // debugger;
                if (response.data[0].length != 0) {
                    // debugger;
                    $scope.BranchLst = JSON.parse(response.data);  //response.data;

                }

            });
    };

    $scope.GetBranchData();

    $scope.GetCityData = function () {
        //  debugger;

        AjsFactory.getCityDetailsdata()
            .then(function (response) {
                // debugger;
                if (response.data[0].length != 0) {
                    // debugger;
                    $scope.cityLst = response.data[0];
                    $scope.Test();

                }

            });
       

    };

    $scope.GetCityData();

    $scope.GetStateData = function () {
        // debugger;

        AjsFactory.getStateDetailsdata()
            .then(function (response) {
                // debugger;
                if (response.data[0].length != 0) {
                    // debugger;
                    $scope.stateLst = response.data[0];

                }

            });

    };

    $scope.GetStateData();

    $scope.Test = function () {

        $scope.form.Branch = 4;
        $scope.form.City = 1;
        $scope.form.State = 1;
    }

    $scope.getActivityData = function () {
        debugger;
        var Data = {
            Pkey_activity_id: $scope.ActivityId,
            Type: 2,

        };
        AjsFactory.getActivityDetailsdata(Data)
            .then(function (response) {
                debugger;
                if (response.data[0][0].length != 0) {

                    $scope.form.activityname = response.data[0][0].activity_name;
                    $scope.form.amount = response.data[0][0].amount;
                    $scope.form.Branch = response.data[0][0].branch_id;
                    $scope.form.City = response.data[0][0].city_id;
                    $scope.form.State = response.data[0][0].state_id;

                }
            });
    };
    
    $scope.getActivityData();
}]);