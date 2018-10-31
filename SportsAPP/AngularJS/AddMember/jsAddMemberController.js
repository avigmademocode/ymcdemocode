HomeApp.controller('AddMemberController', ['$scope', "$filter", '$window', '$location', 'AjsFactory', function ($scope, $filter, $window, $location, AjsFactory) {


    $scope.MemberId = $scope.MemberId ? $scope.MemberId.split('?')[1] : window.location.search.slice(1);
    alert($scope.MemberId);

    


    $scope.checkErr = function (startDate, expirydate) {
        var curDate = new Date();
        if (new Date(startDate) > new Date(expirydate)) {
            alert("End Date should be greater than start date");
            $scope.form.startDate = "";
            $scope.form.expirydate = "";
            
            return false;
        }
        if (new Date(startDate) < curDate) {
            alert("Invalid Date");
              $scope.form.startDate = "";
              $scope.form.expirydate = "";
            
            return false;
        }
    };

    $scope.Genderx = [
        { id: 1, name: "Male" },
        { id: 2, name: "Female" },
        { id: 3, name: "Other" }
    ];

    $scope.CorresAddrx = [
        { id: 1, name: "Permanent Address" },
        { id: 2, name: "Local Address" }
 
    ];

    $scope.paidbyx = [
        { id: 1, name: "Cash" },
        { id: 2, name: "Cheque" },
        { id: 3, name: "DD" },
        { id: 4, name:"Credit/Debit Card"}
    ];

    $scope.Qualificationx = [
        { id: 1, name: "UG" },
        { id: 2, name: "PG" } 

    ];
    $scope.Religionx = [
        { id: 1, name: "Hinduism" },
        { id: 2, name: "Islam" },
        { id: 3, name: "Buddhism" },
        { id: 4, name: "Buddhism" },
        { id: 5, name: "Judaism" },
        { id: 6, name: "Christianity" },
        { id: 7, name:"Sikhism"}

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
        alert(amount);
        $scope.form.amount = parseFloat(amount);
    }


    // Add member data
    $scope.submitForm = function () {
        debugger;
     



        debugger;

        
        var bool = true;
        bool = EmailValidation($scope.form.Email);
        bool = GSTValidation($scope.form.gstno);
        bool = PanCardValidation($scope.form.panno);


        var Type;
        if ($scope.MemberId == 0) {
            Type = 1;

        }
        else {
            Type = 2;
        }

        
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


            BranchId: $scope.form.BranchId,
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

            pkey_member_id: $scope.MemberId,
            Type: Type,
            UserID: 0,
            is_delete: 1

        };
        alert(JSON.stringify(Data));
        AjsFactory.AddMember(Data)
            .then(function (response) {
                
                // alert(response.data);
                if (response.data.length != 0) {
                    debugger;
                    alert('Request has been saved successfully.');
                    $scope.getMemberData();
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

    //get branch data
    $scope.GetBranchData = function () {
       // debugger;

        AjsFactory.getBranchData()
            .then(function (response) {
         //       debugger;
                //alert(response.data.length);
                if (response.data.length != 0) {
                    //debugger;
                    $scope.branchLst = response.data[0];
                }
            });

    };
    $scope.GetBranchData();

    //get city data
    $scope.GetCityData = function () {
         // debugger;

        AjsFactory.getCityDetailsdata()
            .then(function (response) {
                // debugger;
                if (response.data.length != 0) {
                    // debugger;
                    $scope.citydata = response.data[0];
                  

                }

            });


    };

    $scope.GetCityData();

    //get state data
    $scope.GetStateData = function () {
        // debugger;

        AjsFactory.getStateDetailsdata()
            .then(function (response) {
                // debugger;
                if (response.data.length != 0) {

                    //debugger;
                    $scope.statedata = response.data[0];

                }

            });

    };

    $scope.GetStateData();


    //get special interest Data
    $scope.getspecialinterestData = function () {
        //debugger;

        AjsFactory.GetspecialinterestData()
            .then(function (response) {
                if (response.data.length != 0) {
                    //debugger;
                    $scope.specialinterestLst = response.data[0];
                }
            });
    };
    $scope.getspecialinterestData();

    //get Profession Data 
    $scope.getProfessionData = function () {
        //debugger;
        AjsFactory.GetProfessionData()
            .then(function (response) {
                if (response.data.length != 0) {
                    //debugger;
                    $scope.profQualiLst = response.data[0];
                }
            });
    }
    $scope.getProfessionData();


    //validate email
    function EmailValidation(Email) {
         debugger;
        var reg = /^(("[\w-\s]+")|([\w-]+(?:\.[\w-]+)*)|("[\w-\s]+")([\w-]+(?:\.[\w-]+)*))(@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$)|(@\[?((25[0-5]\.|2[0-4][0-9]\.|1[0-9]{2}\.|[0-9]{1,2}\.))((25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\.){2}(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[0-9]{1,2})\]?$)/;
        if (reg.test(Email)) {
            return true;
        }
        else {
            alert("Invalid EmailID");
            return false;
        }
    }

    //validate pan no
    function PanCardValidation(value) {
         debugger;
        var txt = value.toUpperCase();
        var regpan = /[A-Za-z]{5}\d{4}[A-Za-z]{1}/;

        if (regpan.test(txt)) {
            return true;
        } else {
            alert("Invalid PAN Number");
            return false;
        }
    }

         // validate gstno
        function GSTValidation(value) {
         debugger;
        var gst_value = value.toUpperCase();
        var reg = /^([0]{1}[1-9]{1}|[1-2]{1}[0-9]{1}|[3]{1}[0-7]{1})([a-zA-Z]{5}[0-9]{4}[a-zA-Z]{1}[1-9a-zA-Z]{1}[zZ]{1}[0-9a-zA-Z]{1})+$/;

            if (gst_value.match(reg)) {  
            return true;
            }
            else {
                alert("Invalid GST Number");
            return false;
        }
    }





    //get member data for edit
    $scope.getMemberData = function () {
        debugger;
        var Data = {
            pkey_member_id: $scope.MemberId,
            Type:2
        };

        AjsFactory.GetMemberData(Data)
            .then(function (response) {
                debugger;
                $scope.temp = response.data[0][0];
                if (response.data.length != 0) {
                    $scope.form.ReceiptNo = response.data[0][0].receiptNo;
                    $scope.form.FirstName = response.data[0][0].first_name;
                    $scope.form.LastName = response.data[0][0].last_name;
                    $scope.form.Phone = response.data[0][0].mobile_number;
                    $scope.form.BranchId = response.data[0][0].BranchId;
                    $scope.form.Email = response.data[0][0].email_id;
                   $scope.form.dateofbirth = response.data[0][0].date_of_birth;
                    $scope.form.renewal = response.data[0][0].renewal;
                    $scope.form.age = response.data[0][0].age;
                    $scope.form.qualification = response.data[0][0].qualification;
                    $scope.form.religion = response.data[0][0].religion;
                    $scope.form.maritalstatus = response.data[0][0].marital_Status;
                    $scope.form.Gender = response.data[0][0].gender;
                    $scope.form.profession = response.data[0][0].profession;
                    $scope.form.category = response.data[0][0].category;
                    $scope.form.amount = response.data[0][0].amount;
                    $scope.form.paidby = response.data[0][0].paid_by;
                    $scope.form.chequeno = response.data[0][0].cheque_no;
                    $scope.form.paydate = response.data[0][0].cheque_date;
                    $scope.form.bankname = response.data[0][0].bank_name;
                    $scope.form.gstno = response.data[0][0].GST_No;
                    $scope.form.officetelno = response.data[0][0].office_tel_no;
                    $scope.form.residentialtelNo = response.data[0][0].residential_tel_no;
                    $scope.form.specialinterest = response.data[0][0].special_interest;
                    $scope.form.panno = response.data[0][0].pan_no;
                    //$scope.form.BranchName = response.data.;
                    //$scope.form.Activity = response.data.;
                    $scope.form.Address1 = response.data[0][0].PermAddress1;
                    $scope.form.Address1 = response.data[0][0].PermAddress2;
                    $scope.form.Address1 = response.data[0][0].PermAddress3;
                    $scope.form.pZip = response.data[0][0].Perm_pincode;
                    $scope.form.pCity = response.data[0][0].Perm_city;
                    $scope.form.pState = response.data[0][0].Perm_state;
                    $scope.form.SameAsPermAdd_Loc = response.data[0][0].SameAsPermAdd_Loc;
                    $scope.form.LAddress2 = response.data[0][0].LocalAddress1;
                    $scope.form.LAddress2 = response.data[0][0].LocalAddress2;
                    $scope.form.LAddress2 = response.data[0][0].LocalAddress3;
                    $scope.form.LZip = response.data[0][0].Local_pincode;
                    $scope.form.LCity = response.data[0][0].Local_city;
                    $scope.form.LState = response.data[0][0].Local_state;
                    $scope.form.SameAsPermAdd_Offi = response.data[0][0].SameAsPermAdd_Offi;
                    $scope.form.Address3 = response.data[0][0].OfficeAddress1;
                    $scope.form.Address3 = response.data[0][0].OfficeAddress2;
                    $scope.form.Address3 = response.data[0][0].OfficeAddress3;
                    $scope.form.Zip = response.data[0][0].Off_pincode;
                    $scope.form.City = response.data[0][0].Off_city;
                    $scope.form.State = response.data[0][0].Off_state;
                    $scope.form.correspondenceaddress = response.data[0][0].CorresAddr;
                    $scope.form.startdate = response.data[0][0].StartDate;
                    $scope.form.expirydate = response.data[0][0].ExpiryDate;
                    $scope.form.is_blacklist_member = response.data[0][0].is_blacklist_member;



                }
            });

    };
    $scope.getMemberData();
}]);