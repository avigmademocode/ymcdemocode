HomeApp.controller('MemberController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    
    $scope.submitForm = function () {
        debugger;

        var Data = {
            categoryId: $scope.form.category,
            entrance_fee: $scope.form.entranceFee,
            infrastructure_fee: $scope.form.infrastructurefee,
            Admission_fee: $scope.form.admissionfee,
            total: $scope.form.total,

            Type: 1,
            UserID: 0,
            is_delete: 1

        };
        alert(JSON.stringify(Data));
        AjsFactory.AddMemberFeeDetailsData(Data)
            .then(function (response) {
                //debugger;
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            })
    };

    $scope.add = function (num1, num2, num3) {
       // alert(test);
        //debugger;
        $scope.form.total = parseFloat(num1) + parseFloat(num2) + parseFloat(num3);
    };

    $scope.getMemberfeeData = function () {
       // debugger;
        var data = {
            categoryId: 0,
            total: $scope.total,
        };
        AjsFactory.GetMemberfeeData(data)
            .then(function (response) {
              //  debugger;
                if (response.data.length != 0) {
                    $scope.categoryLst  = response.data[0];
                }

            });
    };
    $scope.getMemberfeeData()
}]);