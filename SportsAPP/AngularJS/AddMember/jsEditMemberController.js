HomeApp.controller('AddEditController', ['$scope', "$filter", '$window', '$location', 'AjsFactory', function ($scope, $filter, $window, $location, AjsFactory) {


    $scope.UserID = $scope.UserID ? $scope.UserID.split('?')[1] : window.location.search.slice(1);
    //alert($scope.UserID);
    $scope.Genderx = [
        { id: 1, name: "Male" },
        { id: 2, name: "Female" },
        { id: 3, name: "Other" }
    ];
    //
    $scope.qualificationx = [
        { id: 1, name: "UG" },
        { id: 2, name: "PG" },
        { id: 3, name: "Other" }
    ];

    $scope.qualificationx = [
        { id: 1, name: "UG" },
        { id: 2, name: "PG" },
        { id: 3, name: "Other" }
    ];

    $scope.religionx = [
        { id: 1, name: "Hinduism" },
        { id: 2, name: "Islam" },
        { id: 3, name: "Buddhism" },
        { id: 4, name: "Judaism" },
        { id: 5, name: "Christianity" },
        { id: 6, name: "Sikhism" },
        { id: 7, name: "Others" }
    ];
    $scope.maritalstatusx = [
        { id: 1, name: "Single" },
        { id: 2, name: "Married" }
    ];







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
        //alert(amount);
        $scope.form.amount = parseFloat(amount);
    }
   
   

    $scope.GetMemberData = function () {

        var Data = {
            id: $scope.UserID
        };


        AjsFactory.GetMemberDataID(Data)
            .then(function (response) {
                debugger;
                if (response.data.length > 0) {

                    $scope.ReceiptNo = response.data[0][0].receiptNo;
                    $scope.FirstName = response.data[0][0].first_name;
                    $scope.LastName = response.data[0][0].last_name;
                    $scope.Phone = response.data[0][0].mobile_number;
                    $scope.Email = response.data[0][0].email_id;
                    $scope.dateofbirth = response.data[0][0].date_of_birth;
                    //$scope.form.renewal = response.data[0].;
                    $scope.age = response.data[0][0].age;
                    $scope.qualification = response.data[0][0].qualification;
                    $scope.religion = response.data[0][0].religion;
                    $scope.maritalstatus = response.data[0][0].marital_Status;
                    $scope.Gender = response.data[0][0].gender;
                    $scope.profession = response.data[0][0].profession;
                    $scope.category = response.data[0][0].category;
                    $scope.amount = response.data[0][0].amount;
                    $scope.paidby = response.data[0][0].paid_by;
                    //$scope.chequeno = response.data[0][0].cheque_no;
                        //$scope.form.paydate = response.data[0][0].
                        //$scope.form.bankname = response.data[0][0].
                    $scope.gstno = response.data[0][0].GST_No;
                    $scope.officetelno = response.data[0][0].office_tel_no;
                    $scope.residentialtelNo = response.data[0][0].residential_tel_no;
                    $scope.specialinterest = response.data[0][0].special_interest;
                    $scope.panno = response.data[0][0].pan_no;
                    $scope.BranchName = response.data[0][0].bank_name;
                       // $scope.form.Activity = response.data[0][0].
                    $scope.Address1 = response.data[0][0].PermAddress1;
                    $scope.Address1 = response.data[0][0].PermAddress2;
                    $scope.Address1 = response.data[0][0].PermAddress3;
                    $scope.pZip = response.data[0][0].Perm_pincode;
                    $scope.pCity = response.data[0][0].Perm_city;
                    $scope.pState = response.data[0][0].Perm_state;
            //$scope.form.SameAsPermAdd_Loc,
            //$scope.form.LAddress2,
            //$scope.form.LAddress2,
            //$scope.form.LAddress2,
            //$scope.form.LZip,
            //$scope.form.LCity,
            //$scope.form.LState,
            //$scope.form.SameAsPermAdd_Offi,
            //$scope.form.Address3,
            //$scope.form.Address3,
            //$scope.form.Address3,
            //$scope.form.Zip,
            //$scope.form.City,
            //$scope.form.State,
            //$scope.form.correspondenceaddress,
            //$scope.form.startdate,
            //$scope.form.expirydate,


                    debugger;
                }
            });





        
            
    }
    $scope.GetMemberData();









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
    }


}]);