HomeApp.controller('AddBranchController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.BranchId = $scope.BranchId ? $scope.BranchId.split('?')[1] : window.location.search.slice(1);
    alert($scope.BranchId);

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



    //Add the branch data
    $scope.submitForm = function () {
        debugger;
        var Type;
        if ($scope.BranchId == 0) {
            Type= 1;
        }
        else {
             Type = 2;
        }


        var bool = true;
        bool = EmailValidation($scope.form.BranchEmail);
     
        var Data = {
           // BranchId: $scope.BranchId,
            Branch_name: $scope.form.BranchName,
            BranchEmailId: $scope.form.BranchEmail,
            phoneno: $scope.form.BranchPhone,
            FullAddress: $scope.form.Address1 + ' ' + $scope.form.Address2,
            Address1: $scope.form.Address1,
            Address2: $scope.form.Address2,
            City: $scope.form.City,
            State: $scope.form.State,
            pincode: $scope.form.Zip,

            Pkey_Branch_id: $scope.BranchId,
            UserID: 0, //using local stoarge 
            Type: Type,
            is_delete:1
        }
        alert(JSON.stringify(Data));
        AjsFactory.AddNewBranch(Data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    alert('Request has been saved successfully.');
                   // $scope.getBranchData();
                }
            });
    };

    $scope.GetcityData = function () {
        //debugger;

        AjsFactory.getCityData()
            .then(function (response) {
               // debugger;
                if (response.data[0].length != 0) {
                 //   debugger;
                    $scope.cityLst = response.data[0];
                }
            });
    
    
    };
    $scope.GetcityData();

    $scope.GetStateData = function () {
        //debugger;

        AjsFactory.getStateData()
            .then(function (response) {
                //debugger;
                if (response.data[0].length != 0) {
                  //  debugger;
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
            alert("Invalid Email Id");
            return false;
        }
    }
    
    //Edit branch data 
    $scope.getBranchData = function () {
        debugger;
        var Data = {
            Pkey_Branch_id: $scope.BranchId,
           // Type:2
        };

        AjsFactory.GetBranchData(Data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    $scope.form.BranchId = response.data[0][0].Pkey_Branch_id,
                        $scope.form.BranchName = response.data[0][0].Branch_name;
                    $scope.form.BranchEmail = response.data[0][0].BranchEmailId;
                    $scope.form.BranchPhone = response.data[0][0].phoneno;
                    $scope.form.Address1 = response.data[0][0].address1;
                    $scope.form.Address2 = response.data[0][0].address2;
                    $scope.form.BranchEmail = response.data[0][0].BranchEmailId;
                    $scope.form.City = response.data[0][0].city;
                    $scope.form.State = response.data[0][0].state;
                    $scope.form.Zip = response.data[0][0].pincode;
                }
            });
    };
    $scope.getBranchData();

}]);