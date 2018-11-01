HomeApp.controller('MembershipRenewalController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    $scope.chequeboxhide = true;
    $scope.servicesTax = [
        { id: 1, Tax: 'YES' },
        { id: 0, Tax: 'No' }
    ];

    $scope.categoryx = [
        { id: 1, Name: 'Full Member' },
        { id: 2, Name: 'Associate Member' },
        { id: 3, Name: 'Student Member' },
        { id: 4, Name: 'Youth Member' },
        { id: 5, Name: 'Transient Member' },
    ];
    $scope.paidx = [
        { id: 1, Name: 'Cash' },
        { id: 2, Name: 'Credit/Debit Card' },
        { id: 3, Name: 'Cheque' },
        { id: 4, Name: 'DD' },
    ];
    //git chek


    // validation
    $scope.checkErr = function (startDate, expirydate) {
        // var curDate = new Date();
        if (new Date(startDate) > new Date(expirydate)) {
            alert("End Date should be greater than start date");
            $scope.form.startDate = "";
            $scope.form.expirydate = "";

            return false;
        }
        //if (new Date(startDate) < curDate) {
        //    alert("Invalid Date");
        //    $scope.form.startDate = "";
        //    $scope.form.expirydate = "";

        //    return false;
        //}
    };

    $scope.submitForm = function () {


        if ($scope.form.chequedate == undefined) {
            $scope.form.chequedate = null;
            $scope.form.chequeno = null;
            $scope.form.bankname = null;
        }

        debugger;
        var Data = {

            member_name: $scope.form.Member.first_name,
            is_service_tax: $scope.form.servicestaxyes,
            date_of_birth: $scope.form.BoDdate,
            age: $scope.form.Age,
            previous_experience: $scope.form.previousexp,
            category: $scope.form.category.pkey_category_id,
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

                    member_name: $scope.form.Member.first_name = '';
                    $scope.form.servicestaxyes = 0;
                    $scope.form.BoDdate = null;
                    $scope.form.Age = 0;
                    $scope.form.previousexp = 0;
                    $scope.form.category.pkey_category_id = "";
                    $scope.form.entrancefee = 0;
                    $scope.form.amount = null;
                    $scope.form.paidby = '';
                    $scope.form.chequeno = 0;
                    $scope.form.chequedate = null;
                    $scope.form.bankname = '';
                    $scope.form.receiptno = 0;
                    $scope.form.gstno = '';
                    $scope.form.startdate = null;
                    $scope.form.expirydate = null;
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
                    $scope.FirsrName = dataItem.Table;



                } else {
                    alert('Record Not Found!');
                }

            });

    }
    $scope.GetMemberData();




    $scope.GetBranchData = function () {
        //debugger;
        AjsFactory.getBranchDetailsData()
            .then(function (resopnse) {
                //debugger;
                if (resopnse.data[0].length != 0) {
                    //debugger;
                    BranchLstData = JSON.parse(resopnse.data);
                    $scope.BranchLst = BranchLstData.Table;
                    //resopnse.data;
                }
            });
    };
    $scope.GetBranchData();


    //get  filter member data
    $scope.memberget = function (brnachId) {
        //debugger last_name
        $scope.memberDataFilter = [];
        for (var i = 0; i < $scope.FirsrName.length; i++) {
            if ($scope.FirsrName[i].BranchId == brnachId) {

                var obj = {};
                obj.pkey_member_id = $scope.FirsrName[i].pkey_member_id;
                obj.first_name = $scope.FirsrName[i].first_name;
                obj.Full_name = $scope.FirsrName[i].first_name + " " + $scope.FirsrName[i].last_name;
                if ($scope.FirsrName[i].date_of_birth != null) {
                    var dateOut = new Date($scope.FirsrName[i].date_of_birth);
                    obj.date_of_birth = dateOut;
                } else {
                    obj.date_of_birth = null;
                }
                //obj.date_of_birth = $scope.FirsrName[i].date_of_birth;
                obj.age = $scope.FirsrName[i].age;
                $scope.memberDataFilter.push(obj);

            }
        }
    }


    // get category
    $scope.GetcategoryData = function () {
        //debugger;
        AjsFactory.getcategoryData()
            .then(function (resopnse) {
                //debugger;
                if (resopnse.data[0].length != 0) {
                    //debugger;

                    $scope.Categories = resopnse.data[0];
                    //resopnse.data;
                }
            });
    };
    $scope.GetcategoryData();

    $scope.fillpaid = function (item) {
        //debugger
        $scope.form.amount = item.Amount;

    }

    $scope.clkpaid = function (id) {

        if (id == 3 || id == 4) {
            $scope.chequeboxhide = false;
        } else {
            $scope.chequeboxhide = true;
        }

    }


    // getclick to member details drowodn
    $scope.clickmember = function (item) {

        //debugger
        $scope.form.BoDdate = item.date_of_birth;
        $scope.form.Age = item.age;

    }



}]);