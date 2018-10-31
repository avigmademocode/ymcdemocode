HomeApp.controller('ActivityReceiptController', ['$scope', "$filter", '$window', '$location', 'AjsFactory', function ($scope, $filter, $window, $location, AjsFactory) {

    $scope.checkErr = function (validfrom, validupto) {
        var curDate = new Date();
        if (new Date(validfrom) > new Date(validupto)) {
            alert("End Date should be greater than start date");
            $scope.form.validfrom = "";
            $scope.form.validupto = "";
            return false;
        }
        if (new Date(validfrom) < curDate) {
            alert("Invalid Date");
            
            $scope.form.validfrom = "";
            $scope.form.validupto = "";
            return false;
        }
    };



    $scope.addReceipt = function () {

       
        var sdate = $filter('date')(new Date($scope.form.validfrom), 'dd/MM/yyyy');
        var validfrom = sdate.split("/").reverse().join("-");

        
        var edate = $filter('date')(new Date($scope.form.validupto), 'dd/MM/yyyy');
        var validupto = edate.split("/").reverse().join("-");     //for date conversion

        var date2 = new Date($scope.form.validupto);       //for date difference
        var date1 = new Date($scope.form.validfrom);
        var timeDiff = Math.abs(date2.getTime() - date1.getTime());
        var NoOfDays = Math.ceil(timeDiff / (1000 * 3600 * 24));

        debugger;
        var data = {

            receipt_id: $scope.form.receiptno,
            curr_date: $scope.form.currdate,
            member_id: $scope.form.memberId,
            from_date: $scope.form.validfrom,
            to_date: $scope.form.validupto,
            member_name: $scope.form.membername,
            activity_id: $scope.form.activity,
            branch_id: $scope.form.branch,
            city_id: $scope.form.city,
            amount: $scope.form.amount,
            paid_by: $scope.form.paidby,
            cheque_no: $scope.form.chequeno,
            cheque_date: $scope.form.chequedate,
            bank_name: $scope.form.bankname,
            Is_MemeberRegister: $scope.form.register,

            Type: 1,
            UserID: 0,
            is_delete: 1,

        }



        alert(JSON.stringify(data));
        AjsFactory.AddReceiptData(data)
            .then(function (response) {
                // alert(response.data.length);

                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });
    };

    //$scope.GetBranchData = function () {
    //    debugger;
       
    //    AjsFactory.getBranchDetailsData()
    //        .then(function (resopnse) {
    //            if (reponse.data.length != 0) {
    //                debugger;
    //                $scope.BranchLst = reponse.data[0];

    //            }
    //        });

    //};

    //$scope.GetBranchData();


    $scope.GetActivityData = function () {
        //debugger;

        AjsFactory.getActivityDetailsData()
            .then(function (response){
                if (response.data.length != 0) {
                    debugger;
                    $scope.ActivityLst = response.data[0];

                }
            });

    };

    $scope.GetActivityData();
}]);