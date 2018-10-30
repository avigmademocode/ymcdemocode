HomeApp.controller('ActivityReceiptController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {



    $scope.addReceipt = function () {
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
            is_delete: 0,

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
            .then(function (resopnse) {
                if (reponse.data.length != 0) {
                    debugger;
                    $scope.ActivityLst = reponse.data[0];

                }
            });

    };

    $scope.GetActivityData();
}]);