HomeApp.controller('MembershipRenewalController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.submitForm = function () {


        debugger;
        var Data = {

            member_name: $scope.form.membername,
            is_service_tax: $scope.form.servicestaxyes,
            date_of_birth: $scope.form.dateofbirth,
            age: $scope.form.age,
            previous_experience: $scope.form.previousexp,
            category: $scope.form.category,
            entrance_fee: $scope.form.entrancefee,
            amount: $scope.form.amount,
            paid_by: $scope.form.paidby,
            cheque_no: $scope.form.chequeno,
            cheque_date: $scope.form.chequedate,
            bank_name: $scope.form.bankname,
            receipt_no: $scope.form.receiptno,
            GST_NO: $scope.form.gstno,
            start_date: $scope.form.startdate,
            expiry_date: $scope.form.expirydate,
            
            Type: 1,
            UserID: 0,
            is_delete: 0
        }
        alert(JSON.stringify(Data));
        AjsFactory.AddActivitydata(Data)
            .then(function (response) {
                // alert(response.data.length);
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });
    };
    $scope.mydata = [];
    $scope.GetMemberData = function () {
        //debugger;
        AjsFactory.getMemberDetailsData()
            .then(function (response) {

                if (response.data.length != 0) {
                    //debugger;
                    dataItem = JSON.parse(response.data);
                    $scope.FirsrName = dataItem.Table

                    angular.forEach($scope.FirsrName, function (item) {
                        $scope.mydata.push(item.first_name);
                    });

                } else {
                    alert('Record Not Found!');
                }

            });

    }
    $scope.GetMemberData();



    $scope.complete = function (string) {

        var output = [];
        angular.forEach($scope.mydata, function (namefill) {
            if (namefill.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
                output.push(namefill);
            }
        });
        $scope.filterName = output;
    }
    $scope.fillTextbox = function (string) {
        $scope.namefill = string;
        $scope.filterName = null;
    }



    
 


}]);