HomeApp.controller('AddMemberController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.AddSpeInterestsData = function () {
        debugger;
        alert("test");
        var data = {
            special_interests: $scope.form.specialInterests,

            Type: 1,
            UserID: 0,
            is_delete: 1
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
            professional_qualifications: $scope.form.proQualifications,

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

            GST_Percentage: $scope.form.GSTPercentage,

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

    $scope.getspecialInterestData = function () {
        //debugger;
        var data = {

            pkey_special_interests_id: 0,
            special_interests: $scope.special_interests,
        };


        AjsFactory.getSpecialInterestData(data)
            .then(function (response) {
                // debugger;
                if (response.data.length != 0) {
                    //debugger;
                    $scope.specintLst = response.data[0];
                }
            });

    };
    $scope.getspecialInterestData();

    $scope.getProQulificationData = function () {
        debugger;
        var Data =
            {
                Pkey_Professional_QualificationId: 0,
                professional_qualifications: $scope.professional_qualifications,
            };
        AjsFactory.GetProQulificationData(Data)
            .then(function (response) {

                if (response.data.length != 0) {
                    //debugger;
                    $scope.professinalLst = response.data[0];
                }
            });

    };
    $scope.getProQulificationData();


    $scope.getGSTPercentage = function ()
    {
        //debugger;
        var Data = {
            pkey_GSTPercent_id: 0,
            GST_Percentage: $scope.GST_Percentage,
        };
        AjsFactory.GetGSTPercentageData(Data)
            .then(function (response)
            {

                if (response.data.length != 0) {
                    //debugger;
                    $scope.GSTPercentageLst = response.data[0];
                }
            });
    };
    //val.GST_Percentage;

    $scope.getGSTPercentage();


    $scope.getGSTPer = function (val) {
        debugger;
        // alert(val.GST_Percentage);
        // $scope.item = val.GST_Percentage;
       
       
        $scope.form.GSTPercentage = val.GST_Percentage;
    };
 
}]);
