HomeApp.controller('DuplicateMembershipCardController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {


    $scope.SubmitForm = function () {
        debugger;

        $scope.getAmount = function (amount) {
            alert(amount);
            $scope.form.amount = parseFloat(amount);
        }




        var data = {
            member_id: $scope.form.memberno,
            //membername,
            category: $scope.form.category,
            receipt_id: $scope.form.receiptno,
            curr_date: $scope.form.date,
            amount: $scope.form.amount,
            paid_by: $scope.form.paidby,
            cheque_no: $scope.form.chequeno,
            bank_name: $scope.form.bankname,
            cheque_date: $scope.form.paydate,

            Type: 1,
            UserID: 0,
            is_delete: 0
        };
        AjsFactory.AddDuplicateCard(data)
            .then(function (response) {
                debugger;
                if (response.data.length != 0) {
                    alert('Request has been saved successfully.');
                }
            });
    };
}]);