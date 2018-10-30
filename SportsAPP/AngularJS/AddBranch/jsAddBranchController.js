HomeApp.controller('AddBranchController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    //$scope.form.State = 1;
    //$scope.postData = function () {

    //    //alert("Hellow");

    //}
    //$scope.postData();

    $scope.SaveChange = function () {

        //debugger;

        var Data = {
            test: "test"
           
        }
        AjsFactory.viewDetails(Data)
            .then(function (response) {

            })
    }




    $scope.submitForm = function () {
        debugger;
        var bool = true;
        bool = EmailValidation($scope.form.BranchEmail);
      
        //formData = $scope.form;
        //alert(JSON.stringify(formData));
     //   alert("test");
        var Data = {
            BranchId: $scope.form.BranchId,
            BranchName: $scope.form.BranchName,
            BranchEmail: $scope.form.BranchEmail,
            BranchPhone: $scope.form.BranchPhone,
            FullAddress: $scope.form.Address1 + ' ' + $scope.form.Address2,
            Address1: $scope.form.Address1,
            Address2: $scope.form.Address2,
            City: $scope.form.City,
            State: $scope.form.State,
            Zip: $scope.form.Zip,
            UserID: 0, //using local stoarge 
            Type: 1,
            is_delete:0
        }
        alert(JSON.stringify(Data));
        AjsFactory.AddNewBranch(Data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    alert('Request has been saved successfully.');
                }
            });
    };

    $scope.GetcityData = function () {
        debugger;

        AjsFactory.getCityData()
            .then(function (response) {
                debugger;
                if (response.data[0].length != 0) {
                    debugger;
                    $scope.cityLst = response.data[0];
                }
            });
    
    
    };
    $scope.GetcityData();

    $scope.GetStateData = function () {
        debugger;

        AjsFactory.getStateData()
            .then(function (response) {
                debugger;
                if (response.data[0].length != 0) {
                    debugger;
                    $scope.stateLst = response.data[0];
                }

            });
    };
    $scope.GetStateData();

    function EmailValidation(BranchEmail) {
       // debugger;
        var reg = /^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/;
        if (reg.test(BranchEmail)) {
            return true;
        }
        else {
            return false;
        }
    }
    


}]);