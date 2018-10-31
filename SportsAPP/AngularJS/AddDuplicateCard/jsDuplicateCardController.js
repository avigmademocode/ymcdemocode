HomeApp.controller('DuplicateMembershipCardController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {


    $scope.categoryx = [
        { id: 200, name: "Full Member" },
        { id: 2, name: "Islam" },
        { id: 3, name: "Buddhism" },
        { id: 4, name: "Judaism" },
        { id: 5, name: "Christianity" },
        { id: 6, name: "Sikhism" },
        { id: 7, name: "Others" }
    ];

    $scope.getAmount = function (amount) {
        alert(amount);
        $scope.form.amount = parseFloat(amount);
    }


    $scope.SubmitForm = function () {
        debugger;
        


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
            is_delete: 1
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