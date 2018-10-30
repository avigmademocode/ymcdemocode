HomeApp.controller('AddMemberController', ['$scope', "$filter", '$window', '$location', 'AjsFactory', function ($scope, $filter, $window, $location, AjsFactory) {




    $scope.getAge = function (datedob) {
        var sdate = $filter('date')(new Date(datedob), 'dd/MM/yyyy');
        var startdate = sdate.split("/").reverse().join("/");
        var today = new Date();
        var birthDate = new Date(startdate);
        var age = today.getFullYear() - birthDate.getFullYear();
        var m = today.getMonth() - birthDate.getMonth();
        if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        $scope.form.age = age;
        console.log(age);
    }

    $scope.getAmount = function (amount) {
        alert(amount);
        $scope.form.amount = parseFloat(amount);
    }














    $scope.submitForm = function () {
       

        var Data = {
            exist_memberId: 1,
            receiptNo: $scope.form.ReceiptNo,
            first_name: $scope.form.FirstName,
            last_name: $scope.form.LastName,
            mobile_number: $scope.form.Phone,
            email_id: $scope.form.Email,
            date_of_birth: $scope.form.dateofbirth,
            renewal: $scope.form.renewal,
            age: $scope.form.age,
            qualification: $scope.form.qualification,
            religion: $scope.form.religion,
            marital_Status: $scope.form.maritalstatus,
            gender: $scope.form.Gender,
            profession: $scope.form.profession,
            category: $scope.form.category,
            amount: $scope.form.amount,
            paid_by: $scope.form.paidby,
            cheque_no: $scope.form.chequeno,
            cheque_date: $scope.form.paydate,
            bank_name: $scope.form.bankname,
            //image_name
            //image_path

            GST_No: $scope.form.gstno,

            office_tel_no: $scope.form.officetelno,
            residential_tel_no: $scope.form.residentialtelNo,
            special_interest: $scope.form.specialinterest,
            pan_no: $scope.form.panno,


            BranchName: $scope.form.BranchName,
            Activity: $scope.form.Activity,
            // FullAddress: $scope.form.Address1 + ' ' + $scope.form.Address2,
            PermAddress1: $scope.form.Address1,
            PermAddress2: $scope.form.Address1,
            PermAddress3: $scope.form.Address1,
            Perm_pincode: $scope.form.pZip,
            Perm_city: $scope.form.pCity,
            Perm_state: $scope.form.pState,
           // Perm_country: $scope.form.Perm_country,


            SameAsPermAdd_Loc: $scope.form.SameAsPermAdd_Loc,

            LocalAddress1: $scope.form.LAddress2,
            LocalAddress2: $scope.form.LAddress2,
            LocalAddress3: $scope.form.LAddress2,
            Local_pincode: $scope.form.LZip,
            Local_city: $scope.form.LCity,
            Local_state: $scope.form.LState,
            //Local_country: $scope.form.Local_country,

            SameAsPermAdd_Offi: $scope.form.SameAsPermAdd_Offi,

            OfficeAddress1: $scope.form.Address3,
            OfficeAddress2: $scope.form.Address3,
            OfficeAddress3: $scope.form.Address3,
            Off_pincode: $scope.form.Zip,
            Off_city: $scope.form.City,
            Off_state: $scope.form.State,
            //Off_country: $scope.form.Off_country,

            CorresAddr: $scope.form.correspondenceaddress,
            StartDate: $scope.form.startdate,
            ExpiryDate: $scope.form.expirydate,
            is_blacklist_member: $scope.form.is_blacklist_member,

            Type: 1,
            UserID: 0,
            is_delete: 0

        };
       // alert(JSON.stringify(Data));
        AjsFactory.AddMember(Data)
            .then(function (response) {
                //debugger;
                // alert(response.data);
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                }
            });
       
    };




    $scope.CoppyAddress = function () {
        //debugger;
        if ($scope.chkCoppy == true) {
            $scope.form.LAddress2 = $scope.form.Address1;
            $scope.form.LCity = $scope.form.pCity;
            $scope.form.LState = $scope.form.pState;
            $scope.form.LZip = $scope.form.pZip;
        }
        else {
            $scope.form.LAddress2 = '';
            $scope.form.LCity = '';
            $scope.form.LState = '';
            $scope.form.LZip = '';
        }
    }
   




    $scope.CoppyAddress2 = function () {
        //debugger;
        if ($scope.chkCoppy2 == true) {
            $scope.form.Address3 = $scope.form.LAddress2;
            $scope.form.City = $scope.form.LCity;
            $scope.form.State = $scope.form.LState;
            $scope.form.Zip = $scope.form.LZip;
        }
        else {
            $scope.form.Address3 = '';
            $scope.form.City = '';
            $scope.form.State = '';
            $scope.form.Zip = '';
        }
    };

    $scope.GetBranchData = function () {
        debugger;

        AjsFactory.getBranchData()
            .then(function (response) {
                debugger;
                //alert(response.data.length);
                if (response.data.length != 0) {
                    debugger;
                    $scope.branchLst = response.data[0];
                }
            });

    };
    $scope.GetBranchData();


}]);